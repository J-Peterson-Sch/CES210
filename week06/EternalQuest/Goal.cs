public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return $"{_shortName}|{_description}|{_points}";
    }

    public abstract string GetStringRepresentation();
}