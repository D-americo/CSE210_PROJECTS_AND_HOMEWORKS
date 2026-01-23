using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16,19);

        string text = "For God so loved the world that he gave his only begotten Son";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or press 'quit' to finish. ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")// o que é essa função .ToLower, serve pq o usuario pode digir quit maiusculo ou minusculo, tanto faz
            {
                break;
            }

            scripture.HideRamdomWords(3); // o que é isso HideRamdomWords, “Peça para a escritura esconder 3 palavras aleatórias.”
        }

    
    }
}