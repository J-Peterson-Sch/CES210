public class BreathingActivity : Activity {

    private int breathCount = 10; //breath count in seconds

    public BreathingActivity(string name, string description) : base(name, description)
    {
        // this._example = example;
        // this._anotherExample = anotherExample;
    }

    public void Run()
    {
        base.DisplayStartingMessage();
    }
}