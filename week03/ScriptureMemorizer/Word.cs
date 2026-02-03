using System;

public class Word
{
    private string _text;
    private bool _isHidden; // bool → verdadeiro ou falso, true → palavra escondida, false → palavra visível

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden) // Se _isHidden == true → mostra "____"
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text; //Se s _isHidden == False → mostra text
        }
    }

    public void Hide()
    {
        _isHidden=true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    
}