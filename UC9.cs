using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] emails = {
            "abc@example.com",
            "def.gmail@com",
            "ghi123@hotmail.com",
            "jkl.mno@xyz.co.in",
            "invalid.email",
            "abc@.com",
            "@example.com",
            "abc@.com.",
            "abc@example..com"
        };

        Func<string, bool> emailValidator = (email) =>
            Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        for (int i = 0; i < emails.Length; i++)
        {
            if (emailValidator(emails[i]))
            {
                Console.WriteLine($"Email {emails[i]} is valid. Clearing...");
                emails[i] = "";
            }
        }

        Console.WriteLine("Valid emails:");
        foreach (string email in emails)
        {
            if (!string.IsNullOrEmpty(email))
            {
                Console.WriteLine(email);
            }
        }
    }
}
