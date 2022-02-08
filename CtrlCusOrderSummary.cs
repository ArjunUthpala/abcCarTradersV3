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
    public partial class CtrlCusOrderSummary : UserControl
    {
        string customer_NIC = Convert.ToString(UserStatic.NICNum);
        public CtrlCusOrderSummary()
        {
            InitializeComponent();
        }

        private void CtrlCusOrderSummary_Load(object sender, EventArgs e)
        {
           DisplayDateonLoad();
        }

        void DisplayDateonLoad()
        {
            List<tbl_cus_order> OrderDetails = new List<tbl_cus_order>();       
            OrderDetails = CusOrderBLL.GetAllCusOrders(customer_NIC);    
            dataGridViewMyOrders.DataSource = OrderDetails;
            dataGridViewMyOrders.AutoGenerateColumns = false;
            dataGridViewMyOrders.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewMyOrders.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewMyOrders.Columns["tbl_user"].Visible = false;
        }

   

        private void comboBoxOrderType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxOrderType.SelectedIndex != -1)
            {
                if (comboBoxOrderType.SelectedItem.ToString() == "Car")
                {
                    string orderType = "Car";
                    List<tbl_cus_order> OrderDetails = new List<tbl_cus_order>();
                    OrderDetails = CusOrderBLL.GetOrderDetails(customer_NIC, orderType);
                    dataGridViewMyOrders.DataSource = OrderDetails;
                    dataGridViewMyOrders.AutoGenerateColumns = false;
                    dataGridViewMyOrders.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
                    dataGridViewMyOrders.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    this.dataGridViewMyOrders.Columns["tbl_user"].Visible = false;
                    this.dataGridViewMyOrders.Columns["OrderType"].Visible = false;
                }
                else
                {
                    string orderType = "Car Part";
                    List<tbl_cus_order> OrderDetails = new List<tbl_cus_order>();
                    OrderDetails = CusOrderBLL.GetOrderDetails(customer_NIC, orderType);
                    dataGridViewMyOrders.DataSource = OrderDetails;
                    dataGridViewMyOrders.AutoGenerateColumns = false;
                    dataGridViewMyOrders.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
                    dataGridViewMyOrders.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    this.dataGridViewMyOrders.Columns["tbl_user"].Visible = false;
                    this.dataGridViewMyOrders.Columns["OrderType"].Visible = false;
                }
            }
            else
            {
                DisplayDateonLoad();
            }
        }

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            comboBoxOrderType.SelectedIndex = -1;
            DisplayDateonLoad();
        }

        private void dataGridViewMyOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderIDDisplay.Text = dataGridViewMyOrders.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtItemCode.Text = dataGridViewMyOrders.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOrderType.Text = dataGridViewMyOrders.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtOrderDate.Text = dataGridViewMyOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDownQTY.Value = Convert.ToInt32(dataGridViewMyOrders.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtTotalAmt.Text = dataGridViewMyOrders.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCurrOrderState.Text = dataGridViewMyOrders.Rows[e.RowIndex].Cells[4].Value.ToString();
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
