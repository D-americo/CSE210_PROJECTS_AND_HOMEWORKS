using System;


public class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(); //public Fraction()   _top = 1;     _bottom = 1;
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5); // aqui testamos do file fraction.cs public Fraction(int wholeNumber)
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4); // aqui testamos  public Fraction(int top, int bottom)
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3); // porque aqui usou dois parametros sendo que só tem uma função que tem dois parametros, a resposta foi essa, O C# escolhe QUAL construtor usar baseado nos parâmetros que você passa.
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}