public class ReflectingActivity : Activity{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        // this._example = example;
        // this._anotherExample = anotherExample;
    }

    public void Run()
    {
        Console.WriteLine("I'm running");
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("Geting a promp");
    }

    public void GetRandomQuestion()
    {
        Console.WriteLine("Geting a question");
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Here is a prompt");
    }
    public void DisplayQuestion()
    {
        Console.WriteLine("Here is a question?");
    }
}