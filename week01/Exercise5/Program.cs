using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args) // FUNÇÃO QUE VAI CHAMAR TODAS AS OUTRAS QUE ESTÃO ABAIXO
    {
        displaywelcome();
        string username = promptusername();
        int usernumber = PromptUserNumber();

        int squared = PromptySquareNumber(usernumber);      

        displayResult(username, squared);
    }
    static void displaywelcome()
    {
        Console.WriteLine("Welcome to this task!!!");
    }

    static string promptusername()
    {
        Console.WriteLine("Enter your name please: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
        
    }

    static int PromptySquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void displayResult(string name, int square)
    {
        Console.WriteLine($"{name} your favorit number squared is {square}.");
    }
}

