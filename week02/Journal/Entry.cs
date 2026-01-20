public class Entry // cada entry é uma entrada ou um dia do diario
{
   public string _date; // serve para gaurdar a data e horário
   public string _promptText; // serve para guardar a pergunta
   public string _entryText; // serve para guardar o texto que você escreveu

     public void Display() // void → não devolve nada, Ele só mostra informações
    {
        Console.WriteLine(_date); // mostra a data
        Console.WriteLine(_promptText); // mostra a pergunta
        Console.WriteLine(_entryText); // mostra o texto escrito
        Console.WriteLine();
    }
}