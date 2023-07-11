using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEXASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Registration registration = new Registration();
            while (true)
            {
                Console.WriteLine("1. For First Name ");
                Console.WriteLine("2. For Last Name");
                Console.WriteLine("ENTER YOUR CHOICE");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("ENTER FIRST NAME");
                        string firstname = Console.ReadLine();
                        registration.FirstName(firstname);
                        break;
                    case 2:
                        Console.WriteLine("ENTER LAST NAME");
                        string lastname = Console.ReadLine();
                        registration.LastName(lastname);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }
    }
}

