using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkan_Wings_1
{
    public class Flight
    {
        public string FlightNumber { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string AircraftType { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public int Price { get; set; }


        public Flight(string flightNumber, string departureLocation, string arrivalLocation, DateTime departureTime, DateTime arrivalTime, string aircraftType, int totalSeats, int availableSeats, int price)
        {
            FlightNumber = flightNumber;
            DepartureLocation = departureLocation;
            ArrivalLocation = arrivalLocation;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            AircraftType = aircraftType;
            TotalSeats = totalSeats;
            AvailableSeats = availableSeats;
            Price = price;
        }

        public void bookseats(int num_tickets)
        {
            if (AvailableSeats > 0)
            {
                AvailableSeats-=num_tickets;
            }
        }


    }
}
