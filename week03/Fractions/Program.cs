using System;
using System.Security.Cryptography.X509Certificates;


public class Program
{
    static void Main(string[] args)
    {
      Fraction f1 = new Fraction();//cada um desse é um construtor
      Console.WriteLine(f1.GetFractionString());
      Console.WriteLine(f1.GetDecimalValue());

      Fraction f2 = new Fraction(5); // o c# entende qual class usar pelos parametros
      Console.WriteLine(f2.GetFractionString());
      Console.WriteLine(f2.GetDecimalValue());

      Fraction f3 = new Fraction(3, 4);
      Console.WriteLine(f3.GetFractionString());
      Console.WriteLine(f3.GetDecimalValue());
    }
}