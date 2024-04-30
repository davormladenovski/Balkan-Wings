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
    public partial class searchflight : Form
    {

        public List<Flight> flights;
        public searchflight(List<Flight> f)
        {
            InitializeComponent();
            flights = f;
            box_from.Items.AddRange(locations);
            box_to.Items.AddRange(locations);
        }

        private void searchflight_Load(object sender, EventArgs e)
        {
            //fligts_data_grid.DataSource = flights;
        }

        public static string[] locations = { "New York", "London", "Paris", "Tokyo", "Dubai",
                                     "Los Angeles", "Sydney", "Moscow", "Berlin", "Rome",
                                     "Beijing", "Toronto", "Istanbul", "Mumbai", "Cairo",
                                     "Athens", "Vienna", "Madrid", "Lisbon", "Stockholm" };

        private void picture_back_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string selectedFrom = box_from.SelectedItem?.ToString();
            string selectedTo = box_to.SelectedItem?.ToString();

            if (selectedFrom != null && selectedTo != null)
            {
                
                var filteredFlights = flights.Where(flight =>
                    flight.DepartureLocation.Equals(selectedFrom, StringComparison.OrdinalIgnoreCase) &&
                    flight.ArrivalLocation.Equals(selectedTo, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                
                fligts_data_grid.DataSource = filteredFlights;
            }
            else
            {
                MessageBox.Show("Please select both departure and arrival locations.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            box_from.Text = " ";
            box_to.Text = " ";
        }
    }
}
