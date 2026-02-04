using System;

public class BreathingActivity : Activity
{
    // Construtor
    public BreathingActivity(int duration) 
        : base("Breathing Activity", 
               "This Activity helps you relax by guiding you through breathing in and out slowly", 
               duration)
    {
        // Nada extra aqui
    }

    // Método Run
    public void Run()
    {
        StartMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }

        TimeSpan elapsed = DateTime.Now - startTime;
        Console.WriteLine($"Good job! You completed {elapsed.Seconds} seconds of Breathing Activity.");

        
    }
}
