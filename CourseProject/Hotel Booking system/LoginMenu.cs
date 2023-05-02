using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Hotel_Booking_system
{
   
    


        static void LoginMenu()
        {
            if (authenticatedCustomer == null)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                authenticatedCustomer = customers.FirstOrDefault(c => c.Username == username && c.Password == password);
                if (authenticatedCustomer != null)
                {
                    Console.WriteLine($"Welcome {authenticatedCustomer.FirstName}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedCustomer.Username}");
            }
        }



    
}
