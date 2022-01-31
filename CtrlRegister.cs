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
    public partial class CtrlRegister : UserControl
    {
        public CtrlRegister()
        {
            InitializeComponent();
        }

        private void CtrlRegister_Load(object sender, EventArgs e)
        {
            checkBoxIsCustomer.Visible = false;
        }
    }
}
