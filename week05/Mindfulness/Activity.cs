using System;


public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
    }

    public void EndMessage()
    {
        Console.WriteLine($"Good job!  you completed {_duration} seconds of {_name}.");
    }

    public void ShowCountdown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);// faz o programa esperar 1 segundo antes de contar para dar a sensação de contagem regressiva 
            Console.Write("\b \b"); // aqui serve para apagar o número anterior e o novo aparecer no mesmo lugar, assim não fica um atras do outro e sim no mesmo lugar dando a sensação de contagem
    
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>(){"|", "/", "-", "\\"};

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);

            Thread.Sleep(200);
            Console.Write("\b \b");

            i++; if(i>=spinner.Count){i = 0;}
        }
    }
}