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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            CurrentTabIndicator.Height = btnDash.Height;
            CurrentTabIndicator.Top = btnDash.Top;
            ctrlAdminDash1.BringToFront();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnDash.Height;
            CurrentTabIndicator.Top = btnDash.Top;
            ctrlAdminDash1.BringToFront();
        }


        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnOrderDetails.Height;
            CurrentTabIndicator.Top = btnOrderDetails.Top;
            ctrlOrderDetails2.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult CloseConfirmation = MessageBox.Show("Do you want to quit?", "Quit application", MessageBoxButtons.OKCancel);
            if (CloseConfirmation == DialogResult.OK)
            {
                Application.Exit();
            }
  
        }

        private void btnCarDetails_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnCarDetails.Height;
            CurrentTabIndicator.Top = btnCarDetails.Top;
            ctrlCarDetails1.BringToFront();
        }

        private void btnCarPartsDetails_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnCarPartsDetails.Height;
            CurrentTabIndicator.Top = btnCarPartsDetails.Top;
            ctrlCarPartsDetails1.BringToFront();
           
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            if(UserStatic.isAdmin)
            {
                txtAdminUname.Text = Convert.ToString(UserStatic.Username);
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnReports.Height;
            CurrentTabIndicator.Top = btnReports.Top;
            ctrlReports2.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
