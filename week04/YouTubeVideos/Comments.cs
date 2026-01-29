using System;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name; //_name é atributo da classe, name é parametro
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return $"{_name} : {_text}";
    }
}