using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
        public class guestReservations
        {

            public Guest guest { get; set; }

            public Reservation reservation { get; set; }

            public guestReservation(Guest c, Reservation a)
            {
                guest = c;
                reservation = a;
            }
        }
    }



