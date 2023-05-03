using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
        public class guestReservations //defines a public class named guestReservations
        {

            public Guest guest { get; set; } //defines a public property named guest that is type Guest with a getter and setter method

            public Reservation reservation { get; set; } // defines a public propert reservation that is the type reservation with a getter and setter method

            public guestReservations(Guest c, Reservation a) // defines the constructor named getReservation
            {
                guest = c; //assignes value of the parameters to the guest properties class
                reservation = a; //asssigns values of the parameter to the reservation properties class
            }
        }
    }



