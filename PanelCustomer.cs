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
    public partial class PanelCustomer : Form
    {
        public PanelCustomer()
        {
            InitializeComponent();
            CurrentTabIndicator.Height = btnCusHome.Height;
            CurrentTabIndicator.Top = btnCusHome.Top;
            ctrlCusDetails1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void PanelCustomer_Load(object sender, EventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                txtCusUname.Text = Convert.ToString(UserStatic.Username);
            }
        }

        private void btnCusHome_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnCusHome.Height;
            CurrentTabIndicator.Top = btnCusHome.Top;
            ctrlCusDetails1.BringToFront();
        }

        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnOrderCar.Height;
            CurrentTabIndicator.Top = btnOrderCar.Top;
            ctrlCusCarOrder1.BringToFront();
        }

        private void btnCarPartsOrder_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnCarPartsOrder.Height;
            CurrentTabIndicator.Top = btnCarPartsOrder.Top;
            ctrlCusCarPartOrder1.BringToFront();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            CurrentTabIndicator.Height = btnMyOrders.Height;
            CurrentTabIndicator.Top = btnMyOrders.Top;
            ctrlCusOrderSummary1.BringToFront();
        }
    }
}
