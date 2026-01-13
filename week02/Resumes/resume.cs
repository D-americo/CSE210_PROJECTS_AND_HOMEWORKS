using System;

public class Resume
{
    public string _name; // porque aqui teve que usar public string _name
    public List<Job> _jobs = new List<Job>(); // porque aqui foi usado List<Job> _jobs = new List<Job>();


    public void Display() // essa aqui é a main function?
    {
        Console.WriteLine($"Name: {_name}"); // ele vai escrever o nome da pessoa que ela vai colocar onde?
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs) // porque foi usado um for each no job job in jobs, 
        {
            job.Display();
        }
    }
}
