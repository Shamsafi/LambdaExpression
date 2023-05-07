using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Func<string, bool> emailValidator = (email) =>
            Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@(abc)+\.(bl)+\.(co)(\.(xyz|in))?");  //EX:-sam.smith@abc.bl.co.in

        Console.Write("Enter email address: ");
        string email = Console.ReadLine();

        if (emailValidator(email))
        {
            Console.WriteLine("Valid email address.");
        }
        else
        {
            Console.WriteLine("Invalid email address.");
        }
    }
}
