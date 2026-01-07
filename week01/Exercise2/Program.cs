using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string gradefromuser = Console.ReadLine();

        int grade = int.Parse(gradefromuser);

        if (grade > 90)
        {
            Console.WriteLine ("Congratulations you have passed of year with an A Score");
            {
            if (grade >= 97)
            {
                Console.WriteLine ("And exactly you got a A+");
            }
            else if (grade < 93 && grade >=90)
            {
                Console.WriteLine ("And exactly you got a A-"); 
            }
            else
                {
                Console.WriteLine ("");
                }
            }
        }

        else if (grade > 80)
        {
            Console.WriteLine ("Congratulations you have passed of year with a B Score");
            {
                if (grade >= 87)
            {
                Console.WriteLine ("And exactly you got a B+");
            }
            else if (grade < 83 && grade >=80)
            {
                Console.WriteLine ("And exactly you got a B-"); 
            }
            else
                {
                 Console.WriteLine ("");
                }
            }
        }

        else if (grade >= 70)
        {
            Console.WriteLine ("Congratulations you have passed of year with a c Score");
            {
                if (grade >= 77)
            {
                Console.WriteLine ("And exactly you got a C+");
            }
            else if (grade < 73 && grade >=70)
            {
             Console.WriteLine ("And exactly you got a C-"); 
            }
            else
                {
                Console.WriteLine ("");
                }
            }
        }

        else 
        {
            Console.WriteLine ("you have not passed of year because your grade is D or even worse F, study more and search for help. ");
        }
    }
       
}