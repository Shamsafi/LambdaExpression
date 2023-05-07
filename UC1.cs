using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Func<string, bool> firstNameValidator = (firstName) =>
            !string.IsNullOrEmpty(firstName) && char.IsUpper(firstName[0]) && firstName.Length >= 3;

        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        if (firstNameValidator(firstName))
        {
            Console.WriteLine("Valid first name.");
        }
        else
        {
            Console.WriteLine("Invalid first name.");
        }
    }
}
