using System;

class Program
{
    static void Main(string[] args)
    {
       bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
 switch (choice)
            {
                case "1":
                    Console.Write("Enter duration in seconds: ");
                    int duration1 = int.Parse(Console.ReadLine());
                    BreathingActivity breathing = new BreathingActivity(duration1);
                    breathing.Run();
                    break;

                case "2":
                    Console.Write("Enter duration in seconds: ");
                    int duration2 = int.Parse(Console.ReadLine());
                    ListingActivity listing = new ListingActivity(duration2);
                    listing.Run();
                    break;

                case "3":
                    Console.Write("Enter duration in seconds: ");
                    int duration3 = int.Parse(Console.ReadLine());
                    ReflectingActivity reflecting = new ReflectingActivity(duration3);
                    reflecting.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
