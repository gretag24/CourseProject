using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system //defines the namespace
{
    public class Reservation //defines a public class that defines a public class that is called reservations
    {
        private static int autoIncreament; //this declares a pivate static variable named autoIncreament and is an integer
        public int Id { get; set; } //defines a public property named ID and is an integer

        public DateTime date { get; set; } // defines a public property named date and is a DateTime


        public Reservation() // defines a public cunstructor called reservation 
        {
            autoIncreament++; //increases the value of autoIncreament by 1
            Id = autoIncreament; // this assigns the value of autoIncreament to the property ID
        }
    }
}
