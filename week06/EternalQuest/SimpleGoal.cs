public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, String description, string points) : base(name, description, points){}

    public SimpleGoal(string name, String description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"|{GetDetailsString()}|{_isComplete}";
    }
}