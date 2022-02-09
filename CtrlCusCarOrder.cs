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
    public partial class CtrlCusCarOrder : UserControl
    {
        int Car_id;
        string item_code;
        int orderQTY;
        int availableQTY;
        int unitPrice;
        int TotAmount;
        int remainingQTY;
        string imgPath = "";
        string CBrand = "";
        string CModel = "";
        int Model ;
        string orderType = "Car";
        string orderState = "Pending";
        string customer_NIC = Convert.ToString(UserStatic.NICNum);
        CarDTO carDTO = new CarDTO();
   //     CarDetailsDTO detail = new CarDetailsDTO();
        public CtrlCusCarOrder()
        {
            InitializeComponent();
        }

        private void CtrlCustomerCarOrder_Load(object sender, EventArgs e)
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
            //load data grid view for Car Details
            List<tbl_car> CarDetails = new List<tbl_car>();
            CarDetails = CarDetailsBLL.GetCarDetails();
            dataGridViewCarDetails.DataSource = CarDetails;
            dataGridViewCarDetails.AutoGenerateColumns = false;
            dataGridViewCarDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewCarDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewCarDetails.Columns["tbl_inventory"].Visible = false;
            this.dataGridViewCarDetails.Columns["Car_ID"].Visible = false;

            //create data grid view for Car Order Details
         //    tbl_customer cus =new tbl_customer();
         //    cus = CustomerBLL.GetCustomer(customer_NIC);
  
            //    OrderDetails = CustomerCarOrderBLL.GetOrderDetails();
           //   tbl_cus_order CustomerOrder = new tbl_cus_order();
          
            List<tbl_cus_order> OrderDetails = new List<tbl_cus_order>();
            //  OrderDetails = CustomerCarOrderBLL.GetOneCustomerOrderlist(customer_NIC);
            // correct*      OrderDetails = CustomerCarOrderBLL.GetOrderDetails(customer_NIC);
            OrderDetails = CusOrderBLL.GetOrderDetails(customer_NIC, orderType);
            dataGridViewOrderDetails.DataSource = OrderDetails;
            dataGridViewOrderDetails.AutoGenerateColumns = false;
            dataGridViewOrderDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewOrderDetails.Columns["tbl_user"].Visible = false;
            this.dataGridViewOrderDetails.Columns["OrderType"].Visible = false;
            // this.dataGridViewCarDetails.Columns["tbl_inventory"].Visible = false;
            // this.dataGridViewCarDetails.Columns["Car_ID"].Visible = false;
        }

        private void dataGridViewCarDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //assiging values from data grid to the relavant input fields
            Car_id = Convert.ToInt32(dataGridViewCarDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCarbrand.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCarModel.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtYOM.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtItemCode.Text = dataGridViewCarDetails.Rows[e.RowIndex].Cells[11].Value.ToString();

            //retrive inventory details matching for the selected car
            item_code = txtItemCode.Text;
            tbl_inventory item = new tbl_inventory();
            item = InventoryBLL.GetOneItem(item_code);
            txtQTY.Text = Convert.ToString(item.QTY);
            txtPrice.Text = Convert.ToString(item.Price);

            tbl_car car = new tbl_car();
            car = CarDetailsBLL.MatchCar(Car_id);
            imgPath = Application.StartupPath + "\\images\\" + car.ImagePath;
            pictureBoxCar.ImageLocation = imgPath;
        }

      

        void Clear()
        {
            //clear textboxes when refreshing
            txtCarbrand.Clear();
            txtCarModel.Clear();
            txtYOM.Clear();
            txtItemCode.Clear();
            txtTotalAmt.Clear();

            txtQTY.Clear();
            txtPrice.Clear();


        }

       
   
        private void btnOder_Click(object sender, EventArgs e)
        {
            if (numericUpDown.Value != 0) { 
                availableQTY = Convert.ToInt32(txtQTY.Text);
                orderQTY = Convert.ToInt32(numericUpDown.Value);
 

                if (availableQTY>=orderQTY)
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

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text.Trim() == "")
                MessageBox.Show("Please Select a Car");
            else
            {
                orderQTY = Convert.ToInt32(numericUpDown.Value);
                unitPrice = Convert.ToInt32(txtPrice.Text);
                TotAmount = (orderQTY * unitPrice);
                txtTotalAmt.Text = Convert.ToString(TotAmount);
            }
               
        }

        private void btnCarSearch_Click(object sender, EventArgs e)
        {
            CBrand = comboBoxCarBrand.Text;
            CModel = comboBoxCarModel.Text;
        //   Model = Convert.ToInt32(dateTimePicker2.Value);
            List<tbl_car> CarDetails = new List<tbl_car>();
               CarDetails = CarDetailsBLL.SearchCarDetails(CBrand, CModel);
               dataGridViewCarDetails.DataSource = CarDetails;
               dataGridViewCarDetails.AutoGenerateColumns = false;
               dataGridViewCarDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
               dataGridViewCarDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
               this.dataGridViewCarDetails.Columns["tbl_inventory"].Visible = false;
               this.dataGridViewCarDetails.Columns["Car_ID"].Visible = false;

      /*    List<tbl_car> CarDetails = new List<tbl_car>();
            CarDetails = CarDetailsBLL.TestSearch(Model);
            dataGridViewCarDetails.DataSource = CarDetails;
            dataGridViewCarDetails.AutoGenerateColumns = false;
            dataGridViewCarDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewCarDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewCarDetails.Columns["tbl_inventory"].Visible = false;
            this.dataGridViewCarDetails.Columns["Car_ID"].Visible = false;*/


            /*     List<CarDetailsDTO> list = dto.Cars;
                 if (comboBoxBrand.SelectedIndex != -1)
                     list = list.Where(x => x.CarBrand == comboBoxBrand.Text).ToList();
                 if (comboBoxModel.SelectedIndex != -1)
                     list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
                 dataGridViewCarDetails.DataSource = list;*/
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
