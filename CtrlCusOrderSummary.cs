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

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxOrderType.SelectedIndex = -1;
            DisplayDateonLoad();
        }
    }
}
