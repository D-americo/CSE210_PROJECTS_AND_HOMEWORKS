using System;

public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        _IsComplete = false;
    }

    public override void RecordEvent()
    {
        _IsComplete = true;
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override string GetDetailsString()
    {
        string status = _IsComplete ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {_IsComplete}";
    }
}