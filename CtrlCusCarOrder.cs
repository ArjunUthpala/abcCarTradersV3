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
        string customer_NIC = Convert.ToString(UserStatic.NICNum);
        public CtrlCusCarOrder()
        {
            InitializeComponent();
        }

        private void CtrlCustomerCarOrder_Load(object sender, EventArgs e)
        {
            DisplayDataonLoad();
        }

        void DisplayDataonLoad()
        {
            //create data grid view for Car Details
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
               OrderDetails = CustomerCarOrderBLL.GetOrderDetails(customer_NIC);
            dataGridViewOrderDetails.DataSource = OrderDetails;
            dataGridViewOrderDetails.AutoGenerateColumns = false;
            dataGridViewOrderDetails.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
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
        }

      

        void Clear()
        {
            txtCarbrand.Clear();
            txtCarModel.Clear();
            txtYOM.Clear();
            txtItemCode.Clear();
           
            txtTotalAmt.Clear();

            txtQTY.Clear();
            txtPrice.Clear();


        }

        string orderState = "Pending";
   
        private void btnOder_Click(object sender, EventArgs e)
        {
            if (numericUpDown.Value != 0) { 
                int availableQTY = Convert.ToInt32(txtQTY.Text);
                int orderQTY = Convert.ToInt32(numericUpDown.Value);
                decimal unitPrice = Convert.ToDecimal(txtPrice.Text);

                if (availableQTY>=orderQTY)
                {
                    tbl_cus_order order = new tbl_cus_order();
                    order.OrderDate = DateTime.Today;
                    order.NICNum = customer_NIC;
                    order.TotalAmount = Convert.ToInt32(txtTotalAmt.Text);
                    order.OrderState = orderState;
                    order.ItemCode = txtItemCode.Text;
                    order.OrderItemQty = Convert.ToInt32(numericUpDown.Value); 
                    CustomerCarOrderBLL.OrderCar(order);

                    int remainingQTY = availableQTY - orderQTY;
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
            int orderQTY = Convert.ToInt32(numericUpDown.Value);
            int unitPrice = Convert.ToInt32(txtPrice.Text);
            int TotAmount = (orderQTY * unitPrice);
            txtTotalAmt.Text = Convert.ToString(TotAmount);
        }
    }
}
