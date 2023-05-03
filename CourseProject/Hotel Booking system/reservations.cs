using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
    public class Reservation
    {
        private static int autoIncreament;
        public int Id { get; set; }

        public DateTime date { get; set; }


        public Reservation()
        {
            autoIncreament++;
            Id = autoIncreament;
        }
    }
}
