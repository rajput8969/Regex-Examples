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
            Regex r = new Regex(@"^[A-Z a-z]{2,25}$");
            //class Regex Repesents an immutable regular expression.  

            string[] str = { "ABc","RAm","SHyam" };
            //Input strings for Match valid pin-code number.  
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid Name with 2 captial.", s,
                r.IsMatch(s) ? "is" : "is not");
                //The IsMatch method is used to validate a string or  
                //to ensure that a string conforms to a particular pattern.  
            }
        }
    }
}
