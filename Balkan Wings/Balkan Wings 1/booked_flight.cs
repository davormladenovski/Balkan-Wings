using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkan_Wings_1
{
    public class booked_flight
    {
        public Flight flight { get; set; }
        public int num_tickets { get; set; }

        public booked_flight(Flight flight, int num_tickets)
        {
            this.flight = flight;
            this.num_tickets = num_tickets;
        }
    }
}
