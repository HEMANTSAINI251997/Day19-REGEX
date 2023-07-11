using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
    }
}
