using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balkan_Wings_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            users.Add(new User("Alex","Willson","alexw123@yahoo.com","072312312","Alexwillson123."));
            users.Add(new User("John", "Doe", "johndoe@gmail.com", "071234567", "JohnDoe@123"));
            users.Add(new User("Emily", "Smith", "emilysmith@hotmail.com", "075555555", "Emily@Smith2022"));
            users.Add(new User("Sophia", "Martinez", "sophiamartinez@yahoo.com", "0799999999", "Sophia_2023"));
            users.Add(new User("Olivia", "Wilson", "olivia.wilson@example.com", "0700000000", "Olivia@2023"));
            users.Add(new User("James", "Miller", "james.miller@gmail.com", "0711111111", "MillerJames@123"));
            users.Add(new User("Isabella", "Anderson", "isabella.anderson@hotmail.com", "0722222222", "AndersonIsabella."));
            users.Add(new User("Benjamin", "Thompson", "bthompson@yahoo.com", "0733333333", "ThompsonBenjamin#"));

        }

        public List<User> users = new List<User>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_Click(object sender, EventArgs e)
        {

            signup_function();

        }

        public void signup_function()
        {
            signup signup = new signup();

            DialogResult result = signup.ShowDialog();

            if ( result == DialogResult.OK)
            {
                User new_user = signup.user;

                List<User> usersCopy = new List<User>(users);

                bool flag = false;

                foreach (User user in usersCopy)
                {

                    if (user.email == new_user.email && user.phone == new_user.phone)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                        
                    }
                }

                if (flag)
                {
                    MessageBox.Show("User with the same details already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    users.Add(new_user);
                    MessageBox.Show("Your account has been successfully entered into our database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if(result == DialogResult.No)
            {
                login_function();
            }

        }

        private void sing_up_picture_Click(object sender, EventArgs e)
        {
            signup_function();

        }

        public void login_function()
        {
            login login = new login();

            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                User new_user = login.user;

                List<User> usersCopy = new List<User>(users);
                bool flag=false;
                foreach (User user in usersCopy)
                {

                    if (user.email == new_user.email && user.password == new_user.password)
                    {
                        flag = true; 
                        new_user=user;
                        break;

                    }
                    else
                    {
                        flag = false;
                        
                    }
                }

                if (flag == false)
                {
                    MessageBox.Show("The user does not exist in our database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    dashboard dashboard = new dashboard(new_user);
                    this.Hide();
                    if (dashboard.ShowDialog() == DialogResult.OK)
                    {

                        this.Show();
                    }
                  
                }

            }
            else if(result==DialogResult.No)
            {
                signup_function();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            login_function();
        }



        private void login_picture_Click(object sender, EventArgs e)
        {
            login_function();
        }
    }
}
