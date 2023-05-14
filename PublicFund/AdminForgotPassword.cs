using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class ForgetPassword : Form
    {
        string randomCode;
        public static string to;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        int vCode =1000;
        private void btnSend_Click(object sender, EventArgs e)
        {
            timVcode.Stop();    
            string to, from, pass, mail;
            to = (txtUserEmail.Text).ToString();
            from = "code4ever.masum99@gmail.com"; //Insert mail account
            mail = vCode.ToString();
            pass = "lijgyaqizsphyzgh"; //Insert app password
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Public Fund varification code"; 
            message.Body = mail;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification code sent to your Email successfully!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information); 
                txtOTP.Enabled = true;
                btnVerify.Enabled = true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
            
        }

        private void timVcode_Tick(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999) { vCode = 1000; }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(txtOTP.Text == vCode.ToString()) 
            { 
                ChangePassword changePassword = new ChangePassword(); 
                changePassword.Show();
                this.Hide();    

            }
            else
            {
                MessageBox.Show("Invalid verification code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }
    }
}
