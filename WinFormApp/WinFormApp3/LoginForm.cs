using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm3;

namespace WinFormApp3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //set focus to Username input
            tbUsername.Focus();

            //1. get username & password from Login Form
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            //2. validate username & password
            //2.1 username & password are empty
            if (username == "" || password == "")
            {
                //show error
                MessageBox.Show("Username & Password are required !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //2.2 username & password are incorrect
            else if (username != "admin" || password != "admin")
            {
                //show error
                MessageBox.Show("Login failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                //clear input
                tbUsername.Text = "";
                tbPassword.Text = "";
            }
            //2.3 username & password are correct
            else
            {
                //show success message
                MessageBox.Show("Login succeed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //hide Login Form (this)
                this.Hide();

                //show Admin Form
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
        }
    }
}
