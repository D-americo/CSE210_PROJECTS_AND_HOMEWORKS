using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Assignment a1 = new Assignment("Daniel", "Math");
       Console.WriteLine(a1.GetSummary());

       MathAssigment m1 = new MathAssigment("Daniel",  "Fractions",  "7.3",  "8-19");
       Console.WriteLine(m1.GetSummary());
       Console.WriteLine(m1.GetHomeworkList());

       WritingAssignment w1 = new WritingAssignment("Daniel", "European History", "The Causes of World war 2");
       Console.WriteLine(w1.GetSummary());
       Console.WriteLine(w1.GetWritingInfo());
    }
}