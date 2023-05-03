using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
    public class Program
    {
        private static Guest authenticatedGuest;
        private static Guests guests;
        private static List<Reservation> reservations;
        private static List<guestReservations> guestsReservations;
        private static List<guestReservations> guestReservations;



        //Each of this field present a private access modifier in which they can only be accessed through the program class

        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");
            Initialize();
            Menu();
        }
        //This line of code above represents the main method, which asks to write initializing when asked to follow the method initialize

        static void Initialize()
        {
            var g1 = new Guest
            {
                FirstName = "Sarah",
                LastName = "Smith",
                Username = "sarah",
                Password = "1234",
            };

            var g2 = new Guest
            {
                FirstName = "Terence",
                LastName = "Ow",
                Username = "terence",
                Password = "2345",
            };
            //This line above is just some random information on our new guest. Guest objects allows for user authentication or to create reservations for specific guests that come to our hotel

            var r1 = new Reservation();
            var r2 = new Reservation();
            var r3 = new Reservation();

            var gr1 = new guestReservations(g1, r1);
            var gr2 = new guestReservations(g1, r2);
            var gr3 = new guestReservations(g2, r3);
            //With this line of code above me creates reservation and guestReservations as a object that help to determine manage reservations for specific guests and events or dates


            guests = new Guests();
            guests.guests.Add(g1);
            guests.guests.Add(g2);
           
            List<Reservation> reservations = new List<Reservation>();
            reservations = new List<Reservation>();
            reservations.Add(r1);
            reservations.Add(r2);
            reservations.Add(r3);

            guestReservations = new List<guestReservations>();
            guestReservations.Add(gr1);
            guestReservations.Add(gr2);
            guestReservations.Add(gr3);

            //This lines of code above me displaying objects including guests, reservations, and guestReservations help manage reservations and guest information, and may be updated as new reservations are made or guests are added or removed.

        }


        static void Menu()
        {
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Options: Login 1 --- Logout 2 --- Sign Up: 3 --- Reservations: 4 --- Clear Screen: c --- Quit: q ---  ");
                Console.WriteLine("Choice: "); 
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        LogoutMenu();
                        break;
                    case "3":
                        SignUpMenu();
                        break;
                    case "4":
                        GetCurrentReservationsMenu();
                        break;
                    case "c":
                        Console.Clear(); 
                        break;
                    case "q":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
                //These lines of code from Static void define the "Menu' function in which it allows the users select any of the options from login,logout,signup,reservations,clear screen,and quit
                //this piece of code uses a while loop and a switch statement o allow the user to interact with our program application
            }

        }


        static void LoginMenu()
        {
            if (authenticatedGuest == null)
            {
                Console.WriteLine("Enter your username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                authenticatedGuest = guests.Authenticate(username, password);
                if (authenticatedGuest != null)
                {
                    Console.WriteLine($"Welcome {authenticatedGuest.FirstName}");
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }

            }
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedGuest.username}");
            }
            //These lines of code from Static void define the "LoginMenu' function in which it allows the users enter their username and password
            //this piece of code then uses authenticate() method to authenticate the user from their credntials 

        }

        static void LogoutMenu()
        {
            authenticatedGuest = null;
            Console.WriteLine("Logged Out!");
        }
        //These line of code essentially allows the guest to logout of their account, in which the user will have to log back in using their credentials once again 

        static void SignUpMenu()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("UserName: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            var newGuest = new Guest
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };

            guests.guests.Add(newGuest);

            Console.WriteLine("Profile created!");

        }
        //These lines of code are for the Signup menu. it prompts the user to input information and create a profile in when making a new account with our hotel like firstname, lastname, username, and password

        static void GetCurrentReservationsMenu()
        {
            if (authenticatedGuest == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }

            var ReservationsList = guestReservations.Where(o => o.guest.Username == authenticatedGuest.Username);


            if (ReservationsList.Count() == 0)
            {
                Console.WriteLine("0 reservations found.");
            }
            else
            {
                foreach (var reservation in ReservationsList)
                {
                    Console.WriteLine(reservation.reservation.date);
                }
            }

        }
        //these lines of code allows users to select their reservations from the main menu
        //if the reservation is stored in our database, it will display a lists of reservations made by the user once logged in and autheticated by the program.

    }

} 




