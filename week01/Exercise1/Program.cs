using System;
using System.Linq.Expressions;

class Program
{
    // This is prep 1
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {first_name}");
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}