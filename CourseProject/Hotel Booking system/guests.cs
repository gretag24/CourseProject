using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
    public class Guest
    {

        public List<Guest> guests { get; set; }

        public Guests()
        {
            guest = new List<Guest>();
        }

        public Guest Authenticate(string username, string password)
        {
            var g = guest.Where(o => o.Username == username) && (o.Password == password);

            if (g.Count() > 0)
            {
                return g.First();
            }
            else
            {
                return null;
            }

        }



    }
}
