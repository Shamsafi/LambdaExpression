using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{   //The password must contain at least one uppercase letter
    static void Main(string[] args)
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        Func<string, bool> isValidPassword = (pass) =>
        {
            if (string.IsNullOrEmpty(pass) || pass.Length < 8)
            {
                return false;
            }
            if (!pass.Any(char.IsUpper))
            {
                return false;
            }
            if (!pass.Any(char.IsLower))
            {
                return false;
            }
            if (!pass.Any(char.IsDigit))
            {
                return false;
            }
            if (!pass.Any(c => !char.IsLetterOrDigit(c)))
            {
                return false;
            }
            return true;
        };

        if (isValidPassword(password))
        {
            Console.WriteLine("Valid password.");
        }
        else
        {
            Console.WriteLine("Invalid password!!!");
        }
    }
}