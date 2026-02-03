using System;

public class Assignment
{
    protected string _stundentName;
    protected string _topic;

    public Assignment(string stundentName, string topic)
    {
        _stundentName = stundentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return _stundentName + " - " + _topic;
    }
}