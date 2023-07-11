using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace REGEXASSIGNMENT
{
    public class Registration
    {
        
        public void FirstName(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
          //  Regex regex = new Regex(pattern);
            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("VALID FIRST NAME");
            }
            else
            {
                Console.WriteLine("NOT VALID FIRST NAME");
            }

        }
        public void LastName(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("VALID FIRST NAME");
            }
            else
            {
                Console.WriteLine("NOT VALID FIRST NAME");
            }
        }
        public void Email(string email)
        {
            string pattern = "^[A-Z a-z 0-9 ._%+-]+@[A-Z a-z 0-9 .-]+.[A-Z a-z]{2,}$";
            if (Regex.IsMatch(email,pattern))
            {
                Console.WriteLine("VALID Email ID");
            }
            else
            {
                Console.WriteLine("NOT VALID Email ID");
            }
        }
        public void Number(string num)
        {
            string pattern = "^[+]{1}[0-9]{2}\\s[0-9]{10}$";
            if (Regex.IsMatch(num, pattern))
            {
                Console.WriteLine("VALID MOBILE NUMBER");
            }
            else
            {
                Console.WriteLine("NOT A VALID MOBILE NUMBER");
            }
        }
    }
}
