using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ValidateZipCodeRegEx : 5463 hd : " + ValidateZipCodeRegEx("5463 hd"));

            Console.WriteLine("ValidateZipCodeRegEx : 0463 hd : " + ValidateZipCodeRegEx("0463 hd"));

            Console.WriteLine("ValidateZipCodeRegEx : 5463hd : " + ValidateZipCodeRegEx("5463hd"));

            Console.WriteLine("ValidateZipCodeRegEx : 54d63 hd : " + ValidateZipCodeRegEx("54d63 hd"));
        }

        static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, 
                @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", 
                RegexOptions.IgnoreCase);

            return match.Success;
        }
    }
}
