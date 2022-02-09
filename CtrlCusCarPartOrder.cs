using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;
using DAL.DTO;
using System.IO;

namespace abcCarTradersV1
{
    public partial class CtrlCusCarPartOrder : UserControl
    {
        int Carpart_id;
        string item_code;
        int orderQTY;
        int availableQTY;
        int unitPrice;
        int TotAmount;
        int remainingQTY;
        string CBrand = "";
        string CModel = "";
        string imgPath = "";
        string orderType = "Car Part";
        string orderState = "Pending";
        string customer_NIC = Convert.ToString(UserStatic.NICNum);
        CarDTO carDTO = new CarDTO();
        public CtrlCusCarPartOrder()
        {
            InitializeComponent();
        }

        private void CtrlCusCarPartOrder_Load(object sender, EventArgs e)
        {
            DisplayDataonLoad();

            carDTO = CarDetailsBLL.GetAll();
            comboBoxCarBrand.DataSource = carDTO.CarBrands;
            comboBoxCarBrand.DisplayMember = "CarBrand";
            comboBoxCarBrand.ValueMember = "CarBrand_ID";
            comboBoxCarBrand.SelectedIndex = -1;


            comboBoxCarModel.DataSource = carDTO.CarModels;
            comboBoxCarModel.DisplayMember = "CarModel";
            comboBoxCarModel.ValueMember = "CarModel_ID";
            comboBoxCarModel.SelectedIndex = -1;
            combofull = true;
        }

        void DisplayDataonLoad()
        {
            //load data grid view for Car Parts Details
            List<tbl_car_part> CarPartDetails = new List<tbl_car_part>();
            CarPartDetails = CarPartsDetailsBLL.GetCarPartsDetails();
            dataGridViewCarPartsDetails.DataSource = CarPartDetails;
            dataGridViewCarPartsDetails.AutoGenerateColumns = false;
            dataGridViewCarPartsDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewCarPartsDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewCarPartsDetails.Columns["tbl_inventory"].Visible = false;
            this.dataGridViewCarPartsDetails.Columns["Part_ID"].Visible = false;

            //load data grid view for Car Parts Order Details
            List<tbl_cus_order> OrderDetails = new List<tbl_cus_order>();
            OrderDetails = CusOrderBLL.GetOrderDetails(customer_NIC, orderType);
            dataGridViewOrderDetails.DataSource = OrderDetails;
            dataGridViewOrderDetails.AutoGenerateColumns = false;
            dataGridViewOrderDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewOrderDetails.Columns["tbl_user"].Visible = false;
            this.dataGridViewOrderDetails.Columns["OrderType"].Visible = false;
        }

        private void dataGridViewCarPartsDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //assiging values from data grid to the relavant input fields
            Carpart_id = Convert.ToInt32(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPartName.Text = dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPartBrand.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[2].Value.ToString());     
            txtCarModel.Text = Convert.ToString(dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtItemCode.Text = dataGridViewCarPartsDetails.Rows[e.RowIndex].Cells[7].Value.ToString();

            item_code = txtItemCode.Text;
            tbl_inventory item = new tbl_inventory();
            item = InventoryBLL.GetOneItem(item_code);
            txtQTY.Text = Convert.ToString(item.QTY);
            txtPrice.Text = Convert.ToString(item.Price);

            tbl_car_part carpart = new tbl_car_part();
            carpart = CarPartsDetailsBLL.MatchCarPart(Carpart_id);
            imgPath = Application.StartupPath + "\\images\\" + carpart.ImagePath;
            pictureBoxCarPart.ImageLocation = imgPath;
        }

        void Clear()
        {
            //clear textboxes when refreshing
            txtPartName.Clear();
            txtPartBrand.Clear();
            txtCarModel.Clear();
            txtItemCode.Clear();
            txtTotalAmt.Clear();

            txtQTY.Clear();
            txtPrice.Clear();


        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            orderQTY = Convert.ToInt32(numericUpDown.Value);
            unitPrice = Convert.ToInt32(txtPrice.Text);
            TotAmount = (orderQTY * unitPrice);
            txtTotalAmt.Text = Convert.ToString(TotAmount);
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            if (numericUpDown.Value != 0)
            {
                availableQTY = Convert.ToInt32(txtQTY.Text);
                orderQTY = Convert.ToInt32(numericUpDown.Value);


                if (availableQTY >= orderQTY)
                {
                    tbl_cus_order order = new tbl_cus_order();
                    order.OrderDate = DateTime.Today;
                    order.NICNum = customer_NIC;
                    order.TotalAmount = Convert.ToInt32(txtTotalAmt.Text);
                    order.OrderState = orderState;
                    order.ItemCode = txtItemCode.Text;
                    order.OrderItemQty = Convert.ToInt32(numericUpDown.Value);
                    order.OrderType = orderType;
                    CusOrderBLL.OrderItem(order);

                    remainingQTY = availableQTY - orderQTY;
                    tbl_inventory item = new tbl_inventory();
                    item = InventoryBLL.MatchItem(item_code);
                    item.QTY = remainingQTY;
                    InventoryBLL.UpdateItem(item);
                    numericUpDown.Value = 0;
                }
                else
                {
                    MessageBox.Show("Please Lower the Quantity", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DisplayDataonLoad();
                Clear();

            }
            else
            {
                MessageBox.Show("Please Select Quantity", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarPartSearch_Click(object sender, EventArgs e)
        {
            CBrand = comboBoxCarBrand.Text;
            CModel = comboBoxCarModel.Text;
            List<tbl_car_part> CarPartDetails = new List<tbl_car_part>();
            CarPartDetails = CarPartsDetailsBLL.SearchCarParts(CBrand,CModel);
            dataGridViewCarPartsDetails.DataSource = CarPartDetails;
            dataGridViewCarPartsDetails.AutoGenerateColumns = false;
            dataGridViewCarPartsDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewCarPartsDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewCarPartsDetails.Columns["tbl_inventory"].Visible = false;
            this.dataGridViewCarPartsDetails.Columns["Part_ID"].Visible = false;
        }


        bool combofull = false;
        private void comboBoxCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combofull)
            {
                comboBoxCarModel.DataSource = carDTO.CarModels.Where(x => x.CarBrand_ID ==
                Convert.ToInt32(comboBoxCarBrand.SelectedValue)).ToList();
            }
        }
    }
}
