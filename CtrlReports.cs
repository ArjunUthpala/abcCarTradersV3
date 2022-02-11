using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcCarTradersV1
{
    public partial class CtrlReports : UserControl
    {
        public CtrlReports()
        {
            InitializeComponent();
        }

        private void CtrlReports_Load(object sender, EventArgs e)
        {

        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            FrmSalesReport frmSales = new FrmSalesReport();
            frmSales.Show();
        }

        private void btnRestockReport_Click(object sender, EventArgs e)
        {
            FrmPartsToBeReorderedReport frmRestock = new FrmPartsToBeReorderedReport();
            frmRestock.Show();
        }

        private void btnOrderStateReport_Click(object sender, EventArgs e)
        {
            FrmOrderStateReport frmorderState = new FrmOrderStateReport();
            frmorderState.Show();
        }
    }
}
