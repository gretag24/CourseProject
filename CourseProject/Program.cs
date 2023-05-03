namespace CourseProject
{
    public class Program
    {
        private static Customers customers;
        private static List<Appointment> appointments;
        private static List<CustomerAppointment> customerAppointments;
        private static Customer authenticatedCustomer;


        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");
            Initialize();
            Menu();
        }

        static void Initialize()
        {
            var c1 = new Customer
            {
                FirstName = "Sarah",
                LastName = "Smith",
                Username = "sarah",
                Password = "1234",
            };

            var c2 = new Customer
            {
                FirstName = "Terence",
                LastName = "Ow",
                Username = "terence",
                Password = "2345",
            };
            var a1 = new Appointment();
            var a2 = new Appointment();
            var a3 = new Appointment();

            var ca1 = new CustomerAppointment(c1, a1);
            var ca2 = new CustomerAppointment(c1, a2);
            var ca3 = new CustomerAppointment(c2, a3);

            customers = new Customers();
            customers.customers.Add(c1);
            customers.customers.Add(c2);

            appointments = new List<Appointment>();
            appointments.Add(ca1);
            appointments.Add(ca2);
            appointments.Add(ca3);

            customerAppointments = new List<CustomerAppointment>();
            customerAppointments.Add(ca1);
            customerAppointments.Add(ca2);
            customerAppointments.Add(ca3);


        }


        static void Menu()
        {
            boolean done = false;

            while (!done)
                ///instead of appointments written below, we can place it as reservations for our project
            {
                Console.WriteLine("Options: Login 1 --- Logout 2 --- Sign Up: 3 --- Appointments: 4 --- Clear Screen: c --- Quit: q ---  ");
                Console.WriteLine("Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1" :
                        LoginMenu();
                        break;
                    case "2" :
                        LogoutMenu();
                        break;
                    case "3" :
                        SignUpMenu();
                        break;
                    case "4" :
                        GetCurrentAppointmentMenu();
                        break;
                    case "c" :
                        Console.Clear();
                        break;
                    case "q" :
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
            if(authenticatedCustomer == null)
            {
                Console.WriteLine("Enter your username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                authenticatedCustomers = customers.Authenticate(username, password);
                if(authenticatedCustomer != null)
                {
                    Console.WriteLine($"Welcome {authenticatedCustomer.FirstName}");
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                }

            }
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedCustomer.Username}");
            }

        }

        static void LogoutMenu()
        {
            authenticatedCustomer = null;
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

            var newCustomer = new Customer
            {
                firstName = firstName,
                lasttName = lasttName,
                username = username,
                Password = password
            };
            
            customers.customers.Add(newCustomer);

            Console.WriteLine("Profile created!");

        }
                
       static void GetCurrentAppointmentMenu()
       {
            if(authenticatedCustomer == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }

            var appointmentList = customerAppointments.Where(o => o.customer.Username == authenticatedCustomer.Username);


            if (appointmentList.Count() == 0)
            {
                Console.WriteLine("0 appointment found.");
            }
            else
            {
                foreach(var appointment in appointmentList)
                {
                    Console.WriteLine(appointment.appointment.date);
                }
            }






       }

        




    }
}