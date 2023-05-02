using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
    public class Program
    {
        private static guests guest;
        private static List<reservations> reservations;
        private static List<CguestReservations> guestsReservations;
        private static guest authenticatedguest;


        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");
            Initialize();
            Menu();
        }

        static void Initialize()
        {
            var g1 = new guest
            {
                FirstName = "Sarah",
                LastName = "Smith",
                Username = "sarah",
                Password = "1234",
            };

            var g2 = new guest
            {
                FirstName = "Terence",
                LastName = "Ow",
                Username = "terence",
                Password = "2345",
            };
            var r1 = new reservations();
            var r2 = new reservations();
            var r3 = new reservations();

            var gr1 = new guestReservations(g1, r1);
            var gr2 = new guestReservations(g1, r2);
            var gr3 = new guestReservations(g2, r3);

            guests = new guests();
            guests.guests.Add(g1);
            guests.guests.Add(g2);

            reservations = new List<reservations>();
            reservations.Add(gr1);
            reservations.Add(gr2);
            reservations.Add(gr3);

            guestReservations = new List<guestReservations>();
            guestReservations.Add(gr1);
            guestReservations.Add(gr2);
            guestReservations.Add(gr3);


        }


        static void Menu()
        {
            boolean done = false;

            while (!done)
            {
                Console.WriteLine("Options: Login 1 --- Logout 2 --- Sign Up: 3 --- Reservations: 4 --- Clear Screen: c --- Quit: q ---  ")
                Console.WriteLine("Choice: ")
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
                        GetCurrentReservationstMenu();
                        break;
                    case "c":
                        Console.Clear(); ..
                        break;
                    case "q":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

            }

        }


        static void LoginMenu()
        {
            if (authenticatedguest == null)
            {
                Console.WriteLine("Enter your username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                authenticatedguests = guests.Authenticate(username, password);
                if (authenticatedguests != null)
                {
                    Console.WriteLine($"Welcome {authenticatedguest.FirstName}");
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }

            }
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedguest.Username}");
            }

        }

        static void LogoutMenu()
        {
            authenticatedguest = null;
            Console.WriteLine("Logged Out!");
        }

        static void SignUpMenu()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReaLine();
            Console.Write("Last Name: ");
            string lasttName = Console.ReaLine();
            Console.Write("UserName: ");
            string username = Console.ReaLine();
            Console.Write("Password: ");
            string password = Console.ReaLine();

            var newguest = new guest
            {
                firstName = firstName,
                lasttName = lasttName,
                username = username,
                Password = password
            };

            guests.guests.Add(newguests);

            Console.WriteLine("Profile created!");

        }

        static void GetCurrentReservationstMenu()
        {
            if (authenticatedguest == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }

            var ReservationsList = guestReservations.Where(o => o.guest.Username == authenticatedguest.Username);


            if (reservationstList.Count() == 0)
            {
                Console.WriteLine("0 reservations found.");
            }
            else
            {
                foreach (var reservations in ReservationstList)
                {
                    Console.WriteLine(reservations.reservations.date);
                }
            }

        }

    }

} 




