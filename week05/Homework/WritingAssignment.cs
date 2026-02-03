using System;
using System.Reflection.Metadata.Ecma335;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string stundentName, string topic, string title)
    : base(stundentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return _title +  " by "  + _stundentName;
    }
}

