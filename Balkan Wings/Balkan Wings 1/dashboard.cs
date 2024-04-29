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
    public partial class dashboard : Form
    {

        public User current_user;
        public dashboard(User user)
        {
            InitializeComponent();
            current_user = user;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
           
            label_name.Text = $"{current_user.name} {current_user.surname}";

       
        }

        private void picture_logout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                this.Close();
            }
        }
    }
}
