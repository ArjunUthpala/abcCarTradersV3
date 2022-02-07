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
        OrderDetailsDTO orderState = new OrderDetailsDTO();
        public CtrlOrderDetails()
        {
            InitializeComponent();
        }

        private void CtrlOrderDetails_Load(object sender, EventArgs e)
        {
            DisplayDateonLoad();

            orderState = CusOrderBLL.GetOrderStatetypes();

            comboBoxOrderState.DataSource = orderState.OrderState;
            comboBoxOrderState.DisplayMember = "OrderState";
            comboBoxOrderState.ValueMember = "OrderState_ID";
            comboBoxOrderState.SelectedIndex = -1;
        }

        void DisplayDateonLoad()
        {
            List<tbl_cus_order> OrderDetails = new List<tbl_cus_order>();
            OrderDetails = CusOrderBLL.GetAllCusOrderList();
            dataGridViewAllOrders.DataSource = OrderDetails;
            dataGridViewAllOrders.AutoGenerateColumns = false;
            dataGridViewAllOrders.DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular);
            dataGridViewAllOrders.ColumnHeadersDefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            this.dataGridViewAllOrders.Columns["tbl_user"].Visible = false;
        }

    }
}
