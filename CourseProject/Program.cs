﻿namespace CourseProject
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

        }








    }
}