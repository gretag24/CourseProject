using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
    public class Guests // names and creates a public class
    {
        
        public List<Guest> guests { get; set; } // getter setter allows guest to be read and updated by other classes.

        public Guests() // creates guest as a public varible 
        {
            guests = new List<Guest>(); // initializes a new instance of the List class and assigns it to the variable guest.
        }

        public Guest Authenticate(string username, string password) // names a public class "Authenticate" that takes two string parameters username and password.
        {
            var g = guests.Where(o => (o.Username == username) && (o.Password == password)); // creates a new variable "g" that contains a query result obtained from guest

            if (g.Count() > 0) // states if "g" is greater than zero what to do.
            {
                return g.First(); // shows the return if "g" is greater than zero
            }
            else // what do to if "g" is less than or equal to zero
            {
                return null; // shows the return if "g" is less than or equal to zero
            }

        }



    }
}
