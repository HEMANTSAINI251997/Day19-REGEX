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
                Console.WriteLine("3. For Email ID");
                Console.WriteLine("4. For Mobile Number");
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
                    case 3:
                        Console.WriteLine("ENTER EMAIL ID");
                        string email = Console.ReadLine();
                        registration.Email(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile Number like e.g = +91 9999868626");
                        string num=Console.ReadLine();
                        if (num.Length == 14)
                        {
                            registration.Number(num);
                        }
                        else
                        {
                            Console.WriteLine("You Have Enter Wrong Number");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }
    }
}

