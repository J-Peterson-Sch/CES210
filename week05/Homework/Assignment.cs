public class Assignment {

    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        this._topic = topic;
        this._studentName = name;
    }

    public string GetSummary()
    {
        return $"{_studentName}, {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}