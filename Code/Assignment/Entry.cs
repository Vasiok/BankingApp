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

namespace Assignment
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on Login.Click these items become visible
            btnLogin.Visible = true;
            lblPassword.Visible = true;
            lblUserName.Visible = true;
            txtPassword.Visible = true;
            txtUserName.Visible = true;

            // sets cursor focus on Username text box
            txtUserName.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // To enter the system:
            bool retVal = false;

            // setting input to variables
            string inputUsername = txtUserName.Text;
            string inputPassword = txtPassword.Text;

            // calling business layer
            BLLLogInManager bllLogin = new BLLLogInManager();

            // returning true if the input username and password are correct
            retVal = bllLogin.CheckLogin(inputUsername, inputPassword);

            if (retVal)
            {
                MessageBox.Show("Login success!");

                MainDisplay tDGV = new MainDisplay();
                tDGV.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!");
                txtPassword.Text = "";
                txtUserName.Text = "";
            }
        }
    }
}
