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
    public partial class bookedflights : Form
    {
        public User current_user;
        public List<Flight> flights;
        public bookedflights(User u, List<Flight> flights)
        {
            InitializeComponent();
            current_user = u;
            this.flights = flights;
        }

        private void bookedflights_Load(object sender, EventArgs e)
        {
            booked_flights_data_grid.Rows.Clear();
            booked_flights_data_grid.ColumnCount = 8;
            booked_flights_data_grid.Columns[0].Name = "Flight Number";
            booked_flights_data_grid.Columns[1].Name = "Departure";
            booked_flights_data_grid.Columns[2].Name = "Destination";
            booked_flights_data_grid.Columns[3].Name = "Departure Time";
            booked_flights_data_grid.Columns[4].Name = "Arrival Time";
            booked_flights_data_grid.Columns[5].Name = "Price";
            booked_flights_data_grid.Columns[6].Name = "Number of tickets";
            booked_flights_data_grid.Columns[7].Name = "Total Price";

            if (current_user.booked_flights.Count == 0)
            {
                DialogResult result = MessageBox.Show("You don't have any booked flights.", "No Booked Flights", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }

            }

            foreach (booked_flight booked in current_user.booked_flights)
            {
                booked_flights_data_grid.Rows.Add(booked.flight.FlightNumber,booked.flight.DepartureLocation,booked.flight.ArrivalLocation
                    ,booked.flight.DepartureTime,booked.flight.ArrivalTime,booked.flight.Price+" $",booked.num_tickets,booked.flight.Price*booked.num_tickets+" $");
            }

            booked_flights_data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            booked_flights_data_grid.AllowUserToResizeRows = false;
            booked_flights_data_grid.AllowUserToResizeColumns = false;


        }

        private void picture_back_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string searchTerm = tb_flight_num_search.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataGridViewRow row = FindRowByFlightNumber(searchTerm);
                if (row != null)
                {
                    booked_flights_data_grid.ClearSelection();
                    row.Selected = true;
                    booked_flights_data_grid.FirstDisplayedScrollingRowIndex = row.Index;
                }
                else
                {
                    MessageBox.Show("No flight found with the specified flight number.", "Flight Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a flight number to search.", "Search Term Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataGridViewRow FindRowByFlightNumber(string flightNumber)
        {
            foreach (DataGridViewRow row in booked_flights_data_grid.Rows)
            {
                if (row.Cells["Flight Number"].Value != null && row.Cells["Flight Number"].Value.ToString().Equals(flightNumber, StringComparison.OrdinalIgnoreCase))
                {
                    return row;
                }
            }
            return null;
        }

        private void bt_pay_Click(object sender, EventArgs e)
        {


            if (booked_flights_data_grid.SelectedRows.Count > 0)
            {
                
                

                if (booked_flights_data_grid.SelectedRows[0].Cells["Flight Number"].Value == null) {
                    MessageBox.Show("Please select a flight to proceed with payment.", "No Flight Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedFlightNumber = booked_flights_data_grid.SelectedRows[0].Cells["Flight Number"].Value.ToString();

                booked_flight selectedBookedFlight = current_user.booked_flights.FirstOrDefault(f => f.flight.FlightNumber == selectedFlightNumber);

                payment payment = new payment(selectedBookedFlight);
                if(payment.ShowDialog()== DialogResult.OK)
                {
                    Flight selectedFlight = flights.FirstOrDefault(f => f.FlightNumber == selectedFlightNumber);
                    if (selectedFlight != null)
                    {
                        selectedFlight.AvailableSeats -= selectedBookedFlight.num_tickets; 
                                                                                           
                    }

                    current_user.booked_flights.Remove(selectedBookedFlight);
                    bookedflights_Load(sender, e);

                    int index = flights.FindIndex(f => f.FlightNumber == selectedFlightNumber);
                    if (index != -1)
                    {
                        flights[index] = selectedFlight;
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Please select a flight to proceed with payment.", "No Flight Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void bt_unbook_Click(object sender, EventArgs e)
        {
            if (booked_flights_data_grid.SelectedRows.Count > 0)
            {
                if (booked_flights_data_grid.SelectedRows[0].Cells["Flight Number"].Value == null)
                {
                    MessageBox.Show("Please select a flight to unbook.", "No Flight Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedFlightNumber = booked_flights_data_grid.SelectedRows[0].Cells["Flight Number"].Value.ToString();

                booked_flight selectedBookedFlight = current_user.booked_flights.FirstOrDefault(f => f.flight.FlightNumber == selectedFlightNumber);

                if (selectedBookedFlight != null)
                {
                    
                    current_user.booked_flights.Remove(selectedBookedFlight);
                    MessageBox.Show("Flight unbooked successfully.", "Unbooking Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bookedflights_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Selected flight not found in booked flights list.", "Flight Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a flight to unbook.", "No Flight Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
