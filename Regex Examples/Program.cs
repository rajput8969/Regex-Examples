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
            Regex r = new Regex(@"^[1-9]{1}[0-9]{2}\\s{0,1}[0-9]{3}$");
            //class Regex Repesents an immutable regular expression.  

            string[] str = { "132103", "9767101", "732103", "067101", "8967101" };
            //Input strings for Match valid mobile number.  
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid pin-code number.", s,
                r.IsMatch(s) ? "is" : "is not");
                //The IsMatch method is used to validate a string or  
                //to ensure that a string conforms to a particular pattern.  
            }
        }
    }
}
