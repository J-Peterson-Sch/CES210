public class EternalGoal : Goal
{
    public EternalGoal(string name, String description, string points) : base(name, description, points){}

    public override void RecordEvent(){}

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"|{GetDetailsString()}";
    }
}