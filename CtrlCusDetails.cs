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
    public partial class CtrlCusDetails : UserControl
    {
        string customer_NIC = Convert.ToString(UserStatic.NICNum);
        public CtrlCusDetails()
        {
            InitializeComponent();
        }

        private void CtrlCusDetails_Load(object sender, EventArgs e)
        {
          //  DisplayDataonLoad();
        }

        void DisplayDataonLoad()
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
                tbl_customer customer = new tbl_customer();
                customer = CustomerBLL.GetCustomer(customer_NIC);
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.ContactNum = Convert.ToInt32(txtContactNum.Text);
                customer.HomeAddress = txtAddress.Text;
                CustomerBLL.UpdateCustomer(customer);
                DisplayDataonLoad();
                MessageBox.Show("Profile Successfully Updated!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "") //Error when all text box are blank
            {
                MessageBox.Show("Please fill Username and Old Password", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "") //Error when username isn't filled
            {
                MessageBox.Show("Please fill Username", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "") //Error when password isn't filled
            {
                MessageBox.Show("Please fill Password", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                List<tbl_user> userlist = UserBLL.GetUser(txtUsername.Text, txtPassword.Text);
                if (userlist.Count == 0)
                    MessageBox.Show("Please check Credentials!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txtNewPassword.Text == txtPasswordCheck.Text)
                    {
                        tbl_user user = new tbl_user();
                        user = userlist.First();
                        UserStatic.NICNum = user.NICNum;

                        user.Password = txtNewPassword.Text;
                        UserBLL.UpdateUser(user);

                        MessageBox.Show("Successfully password changed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        FrmLogin frm = new FrmLogin();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please enter matching passwords", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CtrlCusDetails_VisibleChanged(object sender, EventArgs e)
        {
           // DisplayDataonLoad();
        }
    }
}
