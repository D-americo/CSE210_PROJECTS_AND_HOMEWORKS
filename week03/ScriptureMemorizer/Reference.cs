using System;

using System.Collections.Generic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference(string book, int chapter, int verse)// porque dentro do () eu não preciso escrever _book ou os outros com o _ também
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }    
    public string GetDisplayText()
    {
        return $"{_book}, {_chapter}, {_verse}";
    }
}