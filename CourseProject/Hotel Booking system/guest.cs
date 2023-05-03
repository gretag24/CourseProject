using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
    public class Guest // defining the class as guest
    {

        private static int autoIncreament; // declares private static integer variable called autoIncreament which is used to keep track of guest ID numbers
        internal string? username;

        public int Id { get; set; } // allowing property to be read and updated by other classes. 
        public string Username { get; set; } // getter setter allows username to be read and updated by other classes. 
        public string Password { get; set; } // getter and setter allows the password to be read and updated by other classes. 
        public string FirstName { get; set; } // getter and setter allows first name to be read and updated by other classes. 
        public string LastName { get; set; } // getter and setter allows last name to be read and updated by other classes. 

        public Guest() //defining constructor for guest class. 
        {
            autoIncreament++; //incrementing the guest ID by one. 
            Id = autoIncreament; // insuring each guest ID number will be unique
        }

    }

}






