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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Balkan_Wings_1
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();

            tb_pass.MaxLength = 20;
            tb_pass.PasswordChar = '*';

        }

        public User user { get; set; }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void bt_signup_Click(object sender, EventArgs e)
        {

            int error = 0;

            string name = tb_name.Text;

            if(name == "" || name =="First name")
            {
                error_empty.SetError(tb_name, "Please enter your name.");
                error += 1;
            }
            else
            {
                error_empty.SetError(tb_name, "");
            }

            string surname = tb_surname.Text;

            if (surname == "" || surname == "Surname")
            {
                error_empty.SetError(tb_surname, "Please enter your surname.");
                error += 1;
            }
            else
            {
                error_empty.SetError(tb_surname, "");
            }

            string email = tb_email.Text;

            if (email == "" || email == "E-Mail")
            {
                error_empty.SetError(tb_email, "Please enter your E-mail.");
                error += 1;
            }
            else
            {
                error_empty.SetError(tb_email,"");
            }

            string emailError = error_email.GetError(tb_email);
            if (!string.IsNullOrEmpty(emailError))
            {
                error += 1;
            }

            string phone = tb_phone.Text;

            if (phone == "" || phone == "Phone number")
            {
                error_empty.SetError(tb_phone, "Please enter your Phone number.");
                error += 1;
            }
            else
            {
                error_empty.SetError(tb_phone, "");
            }

            string phoneError = error_non_digit.GetError(tb_phone);
            if (!string.IsNullOrEmpty(phoneError))
            {
                error += 1;
            }

            if (error!=0)
            {
                return;
            }

            string password = tb_pass.Text;

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must have at least 15 characters, including one uppercase letter, one number, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user = new User(name, surname, email, phone, password);
            this.DialogResult= DialogResult.OK;


        }

        private bool IsValidEmail(string email)
        {
           
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            error_empty.SetError(tb_phone, "");


            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                error_non_digit.SetError(tb_phone, "Only numeric input is allowed.");
            }
            else
            {
                error_non_digit.SetError(tb_phone, "");
            }
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

        private bool IsValidPassword(string password)
        {
            
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\d\s]).{7,}$";

          
            return Regex.IsMatch(password, pattern);
        }

        private void picture_show_pass_Click(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = tb_pass.PasswordChar == '*' ? '\0' : '*';
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_empty.SetError(tb_name, "");
        }

        private void tb_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            error_empty.SetError(tb_surname, "");
        }

        private void lb_login_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
