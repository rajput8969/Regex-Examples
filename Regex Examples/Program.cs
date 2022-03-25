using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            //class Regex Repesents an immutable regular expression.  

            string[] str = { "anmol@gmail.com", "anm@", "teest@gmail.com", "test@gmail.com" };
            //Input strings for Match valid mobile number.  
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid gmail.", s,
                r.IsMatch(s) ? "is" : "is not");
                //The IsMatch method is used to validate a string or  
                //to ensure that a string conforms to a particular pattern.  
            }
        }
    }
}
