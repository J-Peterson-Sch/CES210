public class ListingActivity : Activity{

    private static string _name = "Listing Activity";
    private static string _description = "This activity will help you reflect on times in your"
            + "life when you have shown strenght and resilience. This will help you recognize "
            + "the power you have and how you can use it in outher aspects of your life.";
    private int _count;
    private List<string> _prompts = ["Think of a time when you did something really difficult",
    "Think of a time when you acomplished something really great", "Think of a time when you helped someone do something great"];

    public ListingActivity() : base(_name, _description)
    {
        // this._example = example;
        // this._anotherExample = anotherExample;
    }

    public void Run()
    {
        
        

    }

    public void GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(_prompts.Count); // Generate a random index
        
        Console.WriteLine($"--- {_prompts[randomIndex]}. ---");
        Console.WriteLine("");
    }
    
    // public List<string> GetListFromUser()
    // {
    //     Console.WriteLine("Give me your list");
    //     return;
    // }
}