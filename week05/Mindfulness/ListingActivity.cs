using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
   private List<string> _prompts;
   private int _count;

   public ListingActivity(int duration): base("Listing Activity", "This Activity helps you reflect on the good things in your life by listing as many as you can.", duration)
    {
            _prompts = new List<string>()
        {
            "Who are people you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };

         _count = 0;
    }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt; {prompt}");

    }
}