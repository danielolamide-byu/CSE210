public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
    {
        return $"[ {(IsComplete() ? "X" : " ")} ] {_name} ({_description})";
    }

    public override string GetSaveString()
    {
        return base.GetSaveString() + $"|{_isComplete}";
    }

    public override void LoadProgress(string[] parts)
    {
        _isComplete = bool.Parse(parts[4]);
    }
}
