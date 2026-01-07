using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess1 = -1;

        while (guess1 != number)
        {
             Console.Write("What is your guess? ");
                guess1 = int.Parse(Console.ReadLine());

            if (guess1 < number)
            {
                {
                    Console.WriteLine("greater");
                }
            }


            else if (guess1 > number)
            {
                {
                    Console.WriteLine("Lower");
                }
            }


            else
                {
                    Console.WriteLine("You got it!!!");
                }
        }


    }


}