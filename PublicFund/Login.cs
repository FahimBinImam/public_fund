using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class Login : Form
    {
        public static string Text1;
        function fn = new function();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(btnShow.Text == "Show")
            {
                btnShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if( txtUsername.Text == "code4ever.masum99@gmail.com")
            {
                AdminForgotPassword adminforgotPassword = new AdminForgotPassword();
                adminforgotPassword.Show();
                this.Hide();
            }
            else
            {
                ForgetPassword forgetPassword = new ForgetPassword();
                forgetPassword.Show();
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "admin" || txtUsername.Text == "Admin" || txtUsername.Text == "code4ever.masum99@gmail.com"))
            {
                if(txtPassword.Text == "1234")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                string query1 = "Select * from sponsor where username = '"+txtUsername.Text+"' or email = '"+txtUsername.Text+"' and password = '"+txtPassword.Text+"'";
                string query2 = "Select * from volunteer where username = '"+txtUsername.Text+"' or email = '"+txtUsername.Text+"' and password = '"+txtPassword.Text+"'";
                DataSet ds1 = fn.getData(query1);
                DataSet ds2 = fn.getData(query2);

                if (ds1.Tables[0].Rows.Count != 0)
                {
                    Text1 = txtUsername.Text;
                    Sponsor sponsor = new Sponsor();
                    sponsor.Show();
                    this.Hide();
                }
                else if (ds2.Tables[0].Rows.Count != 0)
                {
                    Text1 = txtUsername.Text;
                    Volunteer volunteer = new Volunteer();
                    volunteer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
