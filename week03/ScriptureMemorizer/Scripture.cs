using System;
using System.Collections.Generic; // Por que System.Collections.Generic, Por que System.Collections.Generic, Porque vamos usar: List<Word>




public class Scripture
{
private Reference _reference; // O que cada um faz?  _reference Guarda livro + capítulo + versículo

private List<Word> _words; // _words, Lista de objetos Word, Cada palavra da escritura vira um Word
 
public Scripture(Reference reference, string text)
    {
        _reference = reference; // Guarda a referência recebida.
        _words = new List<Word>(); // Cria a lista que vai guardar as palavras.

        string[] parts = text.Split(" "); // Divide o texto em palavras usando o espaço.

        foreach (string part in parts)
        {
            Word word = new Word(part); // Cria um objeto Word com aquela palavra.
            _words.Add(word);// _words.Add(word);
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

    public void HideRamdomWords(int numberToHide)
    {
        Random random = new Random(); // porque tem que repetir o nome, Ramdom ai reandon? porque alguns usam <> e outros como esse só escrever new Ramdom()
        int hidden = 0;

        while(hidden < numberToHide)
        {
            int index = random.Next(_words.Count); // porque index, e aqui está usando o .Next e o .Count para fazer o que?

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++; // para o que serve esse ++ aqui 
            }
        }
    
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}