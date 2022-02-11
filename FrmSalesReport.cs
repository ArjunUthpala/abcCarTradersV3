using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcCarTradersV1
{
    public partial class FrmSalesReport : Form
    {
        public FrmSalesReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            this.DataTable1TableAdapter.Fill(this.SalesDataset.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
