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
    public partial class myprofile : Form
    {

        public User current_user;
        public User old_info;
        public myprofile(User user)
        {
            InitializeComponent();
            current_user = user;
            old_info = user;
        }

        private void myprofile_Load(object sender, EventArgs e)
        {
            lb_name.Text = $"{current_user.name} {current_user.surname}";
            tb_first_name.Text = current_user.name;
            tb_surname.Text = current_user.surname;
            tb_email.Text = current_user.email;
            tb_phone.Text = current_user.phone;
            tb_address.Text = current_user.Address;
            tb_passport_num.Text = current_user.passport_num;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string name = tb_first_name.Text;
            string surname = tb_surname.Text;
            string email = tb_email.Text;
            string phone = tb_phone.Text;   
            string address = tb_address.Text;
            string passport = tb_passport_num.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
            string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            current_user = new User(name,surname,email,phone,current_user.password);
            current_user.Address = address;
            current_user.passport_num = passport;

            MessageBox.Show("Your profile has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            myprofile_Load(sender,e);

        }

        private bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhone(string phone)
        {
            
            string pattern = @"^\d+$"; 

            return Regex.IsMatch(phone, pattern);
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            current_user = old_info;

            MessageBox.Show("Your profile has been successfully reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            myprofile_Load(sender, e);

        }

        private void myprofile_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void myprofile_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }

        private void picture_back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }

}
