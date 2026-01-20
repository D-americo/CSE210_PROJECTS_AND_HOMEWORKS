using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();// 🧠 O que está acontecendo aqui? // 1️⃣ Criamos o gerador
        Journal journal = new Journal();
       

        bool running = true; // Variável que controla o loop.

        while (running) // Enquanto running for true, o menu aparece.
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                 Entry entry = new Entry(); // O que está acontecendo? 1️⃣ new Entry(),
 
                 entry._date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                 string prompt = generator.GetRandomPrompt(); //2️⃣ Pedimos uma pergunta
        Console.WriteLine(prompt);// mostramos na tela//2️⃣ Pedimos uma pergunta
                 entry._entryText = Console.ReadLine();
                
                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter the file name to load; ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

               else if (choice == "4")
            {
                Console.Write("Enter the file name to save: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (choice == "5")
            {
                running = false;
            }
        }

    }
}



 