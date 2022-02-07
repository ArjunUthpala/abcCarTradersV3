using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class CtrlRegister : UserControl
    {
        public CtrlRegister()
        {
            InitializeComponent();
        }

        private void CtrlRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "")
                MessageBox.Show("Please Your Enter First Name");
            else if (txtLastName.Text.Trim() == "")
                MessageBox.Show("Please Your Enter Last Name");
            else if (txtNIC.Text.Trim() == "")
                MessageBox.Show("Please Your Enter NIC Number");
            else if (txtContactNum.Text.Trim() == "")
                MessageBox.Show("Please Your Enter Contact Number");
            else if (txtAddress.Text.Trim() == "")
                MessageBox.Show("Please Your Enter Home Address");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Please enter Password section one");
            else if (txtPasswordCheck.Text.Trim() == "")
                MessageBox.Show("Please enter Password section two");
            else if (txtUName.Text.Trim() == "")
                MessageBox.Show("Please enter new username");
            else if (txtPassword.Text == txtPasswordCheck.Text)
            {
                List<tbl_user> usernameList = UserBLL.GetUsername(txtUName.Text);

                if (usernameList.Count == 0)
                {
                    tbl_user user = new tbl_user();
                    user.NICNum = txtNIC.Text;
                    user.IsAdmin = false;
                    user.Username = txtUName.Text;
                    user.Password = txtPassword.Text;
                    user.DateCreated = DateTime.Today;
                    UserBLL.AddUser(user);

                    tbl_customer cus = new tbl_customer();
                    cus.FirstName = txtFirstName.Text;
                    cus.LastName = txtLastName.Text;
                    cus.NICNum = txtNIC.Text;
                    cus.HomeAddress = txtAddress.Text;
                    cus.ContactNum = Convert.ToInt32(txtContactNum.Text);
                    CustomerBLL.AddNewCustomer(cus);

                    MessageBox.Show("Thanks for Registering! Now you can Login!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmLogin frm = new FrmLogin();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username Already exist!, please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter matching passwords", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
