public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _completedCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _completedCount++;
        int total = _points;
        if (_completedCount == _targetCount)
        {
            total += _bonus;
        }
        return total;
    }

    public override bool IsComplete()
    {
        return _completedCount >= _targetCount;
    }

    public override string GetStatus()
    {
        return $"[ {(IsComplete() ? "X" : " ")} ] {_name} ({_description}) — Completed {_completedCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return base.GetSaveString() + $"|{_targetCount}|{_completedCount}|{_bonus}";
    }

    public override void LoadProgress(string[] parts)
    {
        _targetCount = int.Parse(parts[4]);
        _completedCount = int.Parse(parts[5]);
        _bonus = int.Parse(parts[6]);
    }
}
