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
    public partial class bookflight : Form
    {
        public List<Flight> flights;
        public User current_user;
        public bookflight(List<Flight> f,User user)
        {
            InitializeComponent();
            flights = f;
            current_user = user;
        }

        private Flight search_flight=null;

        private void bookflight_Load(object sender, EventArgs e)
        {

            tb_name.Text=current_user.name;
            tb_surname.Text=current_user.surname;
            tb_email.Text=current_user.email;
            tb_phone.Text=current_user.phone;
            tb_pas.Text = current_user.passport_num;

        }

        private void picture_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string flight_num = tb_flight_num_search.Text.Trim(); 

            if (!string.IsNullOrWhiteSpace(flight_num)) 
            {

                foreach (Flight flight in flights)
                {
                    if (flight_num == flight.FlightNumber)
                    {
                        search_flight = flight;
                        break;
                    }
                }

                if (search_flight != null)
                {
                    tb_f_num.Text = search_flight.FlightNumber.ToString();
                    tb_from.Text= search_flight.DepartureLocation.ToString();
                    tb_to.Text=search_flight.ArrivalLocation.ToString();
                    tb_from_time.Text=search_flight.DepartureTime.ToString();
                    tb_to_time.Text=search_flight.ArrivalTime.ToString();
                    tb_num_seats.Text=search_flight.TotalSeats.ToString();
                    tb_avail.Text=search_flight.AvailableSeats.ToString();
                    tb_price.Text = search_flight.Price.ToString()+" $";
                    tb_aircraft.Text=search_flight.AircraftType.ToString();

                    int total = (int)num_ticket.Value * (int)search_flight.Price;
                    tb_total_price.Text=total.ToString();

                    bt_book.Enabled = search_flight.AvailableSeats > 0;

                }
                else
                {
                    MessageBox.Show("Flight not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a flight number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void num_ticket_ValueChanged(object sender, EventArgs e)
        {
            int total = (int)num_ticket.Value * (int)search_flight.Price;
            tb_total_price.Text = total.ToString();
        }

        private void bt_book_Click(object sender, EventArgs e)
        {

            string passportNumber = tb_pas.Text.Trim();
            if (!string.IsNullOrWhiteSpace(passportNumber))
            {
                if (search_flight != null && search_flight.AvailableSeats > 0)
                {
                    search_flight.bookseats((int)num_ticket.Value);
                    current_user.booked_flights.Add(search_flight);

                    MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                }
                
            }
            else
            {
                MessageBox.Show("Please enter a passport number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        }
    }
}
