using System;
using System.Collections.Generic; // precisamos usar isso pois se não o c# não entende o List<Job>

public class Resume
{
    public string _name; // isso serve para o curriculo saber de quem é o curriculo
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
