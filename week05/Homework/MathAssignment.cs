public class MathAssignment : Assignment {

    private string _testbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string testbookSection, string problems) : base(name, topic)
    {
        this._testbookSection = testbookSection;
        this._problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_testbookSection} Problems {_problems}";
    }
}