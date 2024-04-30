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

            generator();

        }

        public List<User> users = new List<User>();
        public List<Flight> flights = new List<Flight>();

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

                    dashboard dashboard = new dashboard(new_user,flights);
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


        public void generator()
        {
            for (int i = 0; i < 200; i++)
            {
                string flightNumber = "BW" + (i + 1).ToString("000");
                string departureLocation = GetRandomLocation();
                string arrivalLocation = GetRandomLocation();
                if (departureLocation != arrivalLocation)
                {

                }
                else
                {
                   
                    while (departureLocation == arrivalLocation)
                    {
                        departureLocation = GetRandomLocation();
                    }
                }
                    DateTime departureTime = GetRandomDateTime();
                    DateTime arrivalTime = departureTime.AddHours(new Random().Next(1, 12));
                    string aircraftType = GetRandomAircraftType();
                    int totalSeats = new Random().Next(100, 400);
                    int a = new Random().Next(0, totalSeats);

                    Flight flight = new Flight(flightNumber, departureLocation, arrivalLocation,
                                               departureTime, arrivalTime, aircraftType, totalSeats, a);

                    flights.Add(flight);
                
                
            }


        }

        public static string[] locations = { "New York", "London", "Paris", "Tokyo", "Dubai",
                                     "Los Angeles", "Sydney", "Moscow", "Berlin", "Rome",
                                     "Beijing", "Toronto", "Istanbul", "Mumbai", "Cairo",
                                     "Athens", "Vienna", "Madrid", "Lisbon", "Stockholm" };

        static string GetRandomLocation()
        {
            return locations[new Random().Next(locations.Length)];
        }

        static DateTime GetRandomDateTime()
        {
            DateTime start = new DateTime(2024, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(new Random().Next(range));
        }

        static string[] aircraftTypes = { "Boeing 777", "Airbus A380", "Boeing 787",
                                          "Airbus A350", "Embraer E190", "Bombardier CRJ900",
                                          "Boeing 737", "Airbus A320" };

        static string GetRandomAircraftType()
        {
            return aircraftTypes[new Random().Next(aircraftTypes.Length)];
        }


    }
}
