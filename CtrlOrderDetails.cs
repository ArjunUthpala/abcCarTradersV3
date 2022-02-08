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
    public partial class CtrlOrderDetails : UserControl
    {
        string cusNIC = "";
        int order_ID;
     //   int car_ID;
     //   string item_code = "";
        OrderDetailsDTO orderState = new OrderDetailsDTO();
        public CtrlOrderDetails()
        {
            InitializeComponent();
        }

        private void CtrlOrderDetails_Load(object sender, EventArgs e)
        {
            DisplayDataonLoad();

            orderState = CusOrderBLL.GetOrderStatetypes();

            comboBoxOrderState.DataSource = orderState.OrderState;
            comboBoxOrderState.DisplayMember = "OrderState";
            comboBoxOrderState.ValueMember = "OrderState_ID";
            comboBoxOrderState.SelectedIndex = -1;
        }

        void DisplayDataonLoad()
        {
            List<tbl_cus_order> OrderDetails = new List<tbl_cus_order>();
            OrderDetails = CusOrderBLL.GetAllCusOrderList();
            dataGridViewAllOrders.DataSource = OrderDetails;
            dataGridViewAllOrders.AutoGenerateColumns = false;
            dataGridViewAllOrders.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewAllOrders.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewAllOrders.Columns["tbl_user"].Visible = false;
        }

        private void dataGridViewAllOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderIDDisplay.Text = dataGridViewAllOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtItemCode.Text = dataGridViewAllOrders.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOrderType.Text = dataGridViewAllOrders.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtOrderDate.Text = dataGridViewAllOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDownQTY.Value = Convert.ToInt32(dataGridViewAllOrders.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtTotalAmt.Text = dataGridViewAllOrders.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxOrderState.Text = dataGridViewAllOrders.Rows[e.RowIndex].Cells[4].Value.ToString();

            cusNIC = dataGridViewAllOrders.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbl_customer cus = new tbl_customer();
            cus = CustomerBLL.GetCustomer(cusNIC);
            txtCusName.Text = Convert.ToString(cus.FirstName);
            txtCusContact.Text = Convert.ToString(cus.ContactNum);
            txtCusAddress.Text = Convert.ToString(cus.HomeAddress);
        }

        void Clear()
        {
            comboBoxOrderState.SelectedIndex = -1;
           
            txtOrderID.Clear();
            txtOrderIDDisplay.Clear();
            txtItemCode.Clear();
            txtOrderType.Clear();
            txtOrderDate.Clear();
            txtCusName.Clear();
            txtCusContact.Clear();
            txtCusAddress.Clear();
            txtTotalAmt.Clear();
        }

        private void btnSetState_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderState.SelectedIndex != 0)
            {
                order_ID = Convert.ToInt32(txtOrderIDDisplay.Text);
                tbl_cus_order order = new tbl_cus_order();
                order = CusOrderBLL.MatchOrder(order_ID);
                order.OrderState = comboBoxOrderState.Text;
                CusOrderBLL.UpdateOrder(order);
                DisplayDataonLoad();
                MessageBox.Show("Order State Successfully Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

       

        private void btnGetItem_Click(object sender, EventArgs e)
        {
            if (txtOrderType.Text == "Car")
            {
                FrmCarView frmCar = new FrmCarView();
                FrmCarView.itemcode = Convert.ToString(txtItemCode.Text);
                frmCar.Show();
            }
            else// if(txtOrderType.Text == "Car Part")
            {
                FrmCarPartView frmCarPart = new FrmCarPartView();
                FrmCarPartView.itemcode = Convert.ToString(txtItemCode.Text);
                frmCarPart.Show();
            }
           
        }
    }
}
