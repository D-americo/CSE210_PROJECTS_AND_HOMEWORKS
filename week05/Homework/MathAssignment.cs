using System;
// classe filha vai herdar tudo do Assigment porém vai ter coisas especificas

public class MathAssigment : Assignment
{
    private string _section;
    private string _problems;

    public MathAssigment(string stundentName, string topic, string section, string problems) : base(stundentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return " Section "  +  _section  +  " Problems "  +  _problems;
    }
}