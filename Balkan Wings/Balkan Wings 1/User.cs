using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkan_Wings_1
{
    public class User
    {

        public string name { get; set; }
        public string surname { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string password { get; set; }

        public string Address = " "; 

        public string passport_num = " ";

        public List<booked_flight> booked_flights {  get; set; }


        public User(string name, string surname, string email, string phone, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.phone = phone;
            this.password = password;
            booked_flights= new List<booked_flight>();
        }

        public User()
        {
        }
    }
}
