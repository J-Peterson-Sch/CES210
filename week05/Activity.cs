public class Activity {

    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        this._name = example;
        this._description = description;
        this._duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("This is the starting message");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("This is the ending message");
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("spinner here");
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("counting down...");
    }
}