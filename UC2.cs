using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Func<string, bool> lastNameValidator = (lastName) =>
            !string.IsNullOrEmpty(lastName) && char.IsUpper(lastName[0]) && lastName.Length >= 3;

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        if (lastNameValidator(lastName))
        {
            Console.WriteLine("Valid last name.");
        }
        else
        {
            Console.WriteLine("Invalid last name.");
        }
    }
}
