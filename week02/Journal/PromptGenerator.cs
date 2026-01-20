using System;
using System.Collections.Generic;

public class PromptGenerator // é a pessoa que te faz as perguntas
{
    public List<string> _prompt = new List<string>(); // Explicando devagar:List<string> → lista de textos, _prompts → nome da lista, new List<string>() → cria a lista de verdade
    Random random = new Random(); //cria algo que gera números aleatórios
    public PromptGenerator() // O que está acontecendo?, PromptGenerator() → roda automaticamente quando o objeto é criado, .Add() → adiciona uma pergunta na lista
    {
        _prompt.Add("How was your day?");
        _prompt.Add("What was the hardest thing of your day?");
        _prompt.Add("Who made you smile today?");
        _prompt.Add("Who did you help today?");
        _prompt.Add("Did you remember of Jesus Cristh today? if yes what did you do to Him?");
        _prompt.Add("What are you gratefull today?");
        _prompt.Add("Did you remender of Agatha today? If yes why?");
    }

    public string GetRandomPrompt() // 
    {
        int index = random.Next(_prompt.Count); // Gera um número entre 0 E A QUANTIDADE DE PERGUNTAS como tme 6 então é 0 até 5
        return _prompt[index]; // serve para devolver a pergunta sorteada
    }
}