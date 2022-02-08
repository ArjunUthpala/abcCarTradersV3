using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class CtrlCustomerProfile : UserControl
    {
        string customer_NIC = Convert.ToString(UserStatic.NICNum);
        public CtrlCustomerProfile()
        {
            InitializeComponent();
        }

        private void CtrlCusProfile_Load(object sender, EventArgs e)
        {
            DataOnLoad();
        }

        void DataOnLoad()
        {
            tbl_customer cus = new tbl_customer();
            cus = CustomerBLL.GetCustomer(customer_NIC);
            txtFirstName.Text = Convert.ToString(cus.FirstName);
            txtLastName.Text = Convert.ToString(cus.LastName);
            txtNIC.Text = Convert.ToString(cus.NICNum);
            txtContactNum.Text = Convert.ToString(cus.ContactNum);
            txtAddress.Text = Convert.ToString(cus.HomeAddress);
        }

        private void btnUpdateCus_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "")
                MessageBox.Show("Please Your Enter First Name");
            else if (txtLastName.Text.Trim() == "")
                MessageBox.Show("Please Your Enter Last Name");
            else if (txtContactNum.Text.Trim() == "")
                MessageBox.Show("Please Your Enter Contact Number");
            else if (txtAddress.Text.Trim() == "")
                MessageBox.Show("Please Your Enter Home Address");
            else
            {
                tbl_customer cus = new tbl_customer();
                cus = CustomerBLL.GetCustomer(customer_NIC);
                cus.FirstName = txtFirstName.Text;
                cus.LastName = txtLastName.Text;
                cus.ContactNum = Convert.ToInt32(txtContactNum.Text);
                cus.HomeAddress = txtAddress.Text;
                CustomerBLL.UpdateCustomer(cus);
                DataOnLoad();
                MessageBox.Show("Profile Successfully Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
