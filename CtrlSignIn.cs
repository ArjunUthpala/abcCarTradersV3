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

namespace abcCarTradersV1
{
    public partial class CtrlSignIn : UserControl
    {
        public CtrlSignIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                if (txtUsername.Text == "" && txtPassword.Text == "") //Error when all text box are blank
                {
                    MessageBox.Show("Please fill Username and Password", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    try
                    {
                        List<tbl_user> userlist = UserBLL.GetUser(txtUsername.Text, txtPassword.Text);
                        if (userlist.Count == 0)
                            MessageBox.Show("Please check Credentials!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            tbl_user user = new tbl_user();
                            user = userlist.First();
                            UserStatic.NICNum = user.NICNum;
                            UserStatic.Username = user.Username;
                            UserStatic.isAdmin = Convert.ToBoolean(user.IsAdmin);

                            if (!UserStatic.isAdmin)
                            {
                                PanelCustomer customerPanel = new PanelCustomer();
                                this.Hide();
                                customerPanel.ShowDialog();
                            }
                            else
                            {
                                AdminPanel adminPanel = new AdminPanel();
                                this.Hide();
                                adminPanel.ShowDialog();
                            }                       
                        }
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void CtrlSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
