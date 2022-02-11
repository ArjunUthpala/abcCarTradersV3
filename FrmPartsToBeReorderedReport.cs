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
    public partial class FrmPartsToBeReorderedReport : Form
    {
        public FrmPartsToBeReorderedReport()
        {
            InitializeComponent();
        }

        private void FrmPartsToBeReorderedReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.tbl_inventory1' table. You can move, or remove it, as needed.
            this.tbl_inventory1TableAdapter.Fill2(this.DataSet1.tbl_inventory1);

            this.reportViewer1.RefreshReport();
        }
    }
}
