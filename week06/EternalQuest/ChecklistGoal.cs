public class ChecklistGoal : Goal
{
    private int _amountComplete = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, String description, string points, int target, int amountComplete, int bonus) : base(name, description, points)
    {
        _target = target;
        _amountComplete = amountComplete;
        _bonus = bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetAmountComplete()
    {
        return _amountComplete;
    }

    public override void RecordEvent()
    {
        _amountComplete++;
    }

    public override bool IsComplete()
    {
        if (_amountComplete >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"|{GetDetailsString()}|{_target}|{_amountComplete}|{_bonus}";
    }
}