﻿using System;
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
            ctrlOrderDetails1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
