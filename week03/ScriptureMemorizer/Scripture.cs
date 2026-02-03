using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;          // Guarda livro + capítulo + versículo(s)
    private List<Word> _words;             // Lista de objetos Word
    private Random _random = new Random(); // Random criado uma vez só

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" "); // Divide o texto em palavras
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;
    }

    public void HideRandomWords(int numberToHide)
    {
        // Conta quantas palavras ainda estão visíveis
        int visibleCount = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleCount++;
            }
        }

        // Se pedir para esconder mais do que resta, ajusta
        if (numberToHide > visibleCount)
        {
            numberToHide = visibleCount;
        }

        int hidden = 0;
        while (hidden < numberToHide)
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // ainda existe palavra visível
            }
        }
        return true; // todas escondidas
    }
}
