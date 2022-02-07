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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            PanelIndicator.Width = btnLoginPanel.Width;
            PanelIndicator.Top = btnLoginPanel.Bottom;
            panelIndicator2.Top = btnRegisterPanel.Top;
            ctrlSignIn1.BringToFront();
        }

        private void btnRegisterPanel_Click(object sender, EventArgs e)
        {
            PanelIndicator.Width = btnRegisterPanel.Width;
            PanelIndicator.Top = btnRegisterPanel.Top;
            panelIndicator2.Top = btnRegisterPanel.Bottom;
            ctrlRegister1.BringToFront();
         
        }

        private void btnLoginPanel_Click(object sender, EventArgs e)
        {
            PanelIndicator.Width = btnLoginPanel.Width;
            PanelIndicator.Top = btnLoginPanel.Bottom;
            panelIndicator2.Top = btnRegisterPanel.Top;
            ctrlSignIn1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult CloseConfirmation = MessageBox.Show("Do you want to quit?", "Quit application", MessageBoxButtons.OKCancel);
            if (CloseConfirmation == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
