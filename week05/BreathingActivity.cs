public class BreathingActivity : Activity {

    private int breathCount = 10; //breath count in seconds

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // this._example = example;
        // this._anotherExample = anotherExample;
    }

    public void Run()
    {
        Console.WriteLine("I'm running");
    }
}