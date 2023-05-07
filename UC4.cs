using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your mobile number: ");
        string mobile = Console.ReadLine();

        Func<string, bool> isValidMobile = (number) =>
        {
            if (string.IsNullOrEmpty(number) || number.Length != 13)
            {
                return false;
            }
            if (!number.StartsWith("91 "))
            {
                return false;
            }
            if (!long.TryParse(number.Substring(3), out long result))
            {
                return false;
            }
            return true;
        };

        if (isValidMobile(mobile))
        {
            Console.WriteLine("Valid mobile number.");
        }
        else
        {
            Console.WriteLine("Invalid mobile number.");
        }
    }
}