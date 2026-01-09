using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      
      int usernumber = -1;

        while (usernumber != 0)
        {
            
         Console.WriteLine("ENTER a number, TYPE (O) TO QUIT. ");
            string useranswer = Console.ReadLine();

            usernumber = int.Parse(useranswer);

           // se eu quiser adicionar a lista eu tenho que criar uma condicional

           if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }
             int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is {sum}");

            float average = ((float)sum / numbers.Count);
            Console.WriteLine($"The average is {average}");

            int max = 0;
            foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
            Console.WriteLine($"The max number is {max}"); 

            int min = int.MaxValue;
            foreach(int number in numbers)
        {
            if (number < min)
            min = number;
        }
            Console.WriteLine($"The min number is {min}");


    }

}