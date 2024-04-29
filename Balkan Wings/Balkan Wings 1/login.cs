using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balkan_Wings_1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            tb_pass.MaxLength = 20;
            tb_pass.PasswordChar = '*';
        }

        public User user { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_signup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();

        }

        private bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            int error = 0;

            string email = tb_email.Text;

            if (email == "" || email == "E-Mail")
            {
                error_empty.SetError(tb_email, "Please enter your E-mail.");
                error += 1;
            }
            else
            {
                error_empty.SetError(tb_email, "");
            }

            string password = tb_pass.Text;

            if (error != 0)
            {
                return;
            }


            user = new User("", "", email, "", password);
            this.DialogResult = DialogResult.OK;

        }

        private void tb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void picture_show_pass_Click_1(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = tb_pass.PasswordChar == '*' ? '\0' : '*';

        }

        private void tb_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_empty.SetError(tb_email, "");

            bool isValidEmail = IsValidEmail(tb_email.Text.Trim());

            if (!isValidEmail)
            {
                error_email.SetError(tb_email, "Invalid email format.");
            }
            else
            {
                error_email.SetError(tb_email, "");
            }

        }
    }
}
