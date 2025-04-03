public class ListingActivity : Activity{

    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
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

    // public List<string> GetListFromUser()
    // {
    //     Console.WriteLine("Give me your list");
    //     return;
    // }
}