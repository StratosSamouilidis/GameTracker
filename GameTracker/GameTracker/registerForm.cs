using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (userNameTxtBox != null && passwordTxtBox != null)
            {
                string uname = userNameTxtBox.Text;
                string passwd = passwordTxtBox.Text;
                int exists = (int)userTableAdapter1.UserExists(uname);
                if (exists == 0)
                {
                    userTableAdapter1.InsertQuery(uname, passwd);
                    verificationLabel.Text = "user " + uname + " added";
                }
                else {
                    verificationLabel.Text = "User Already exists";
                }
            }
        }

        private void goLoginBtn_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }
    }
}
