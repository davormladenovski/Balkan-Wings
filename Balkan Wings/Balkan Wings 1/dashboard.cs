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
        public List<Flight> flights;
        public dashboard(User user,List<Flight> f)
        {
            InitializeComponent();
            current_user = user;
            flights = f;
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
                
                this.DialogResult = DialogResult.OK;
            }
        }

        private void picture_my_profile_Click(object sender, EventArgs e)
        {
            myprofile myprofile = new myprofile(current_user);
            this.Hide();
            if(myprofile.ShowDialog() == DialogResult.OK) {

               current_user = myprofile.current_user;
               this.Show();
               dashboard_Load(sender, e);
               

            }
        }

        private void picture_flight_search_Click(object sender, EventArgs e)
        {
            searchflight searchflight = new searchflight(flights);
            this.Hide();
            if(searchflight.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void picture_book_flight_Click(object sender, EventArgs e)
        {
            bookflight bookflight = new bookflight(flights,current_user);
            this.Hide();
            if(bookflight.ShowDialog() == DialogResult.OK)
            {
                flights=bookflight.flights;
                current_user=bookflight.current_user;
                this.Show();
            }
        }
    }
}
