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
    public partial class FrmOrderStateReport : Form
    {
        public FrmOrderStateReport()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.tbl_cus_order1' table. You can move, or remove it, as needed.
            this.tbl_cus_order1TableAdapter.Fill(this.DataSet1.tbl_cus_order1);

            this.reportViewer1.RefreshReport();
        }
    }
}
