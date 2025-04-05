public class ListingActivity : Activity{

    private static string _name = "Listing Activity";
    private static string _description = "This activity will help you reflect on the good things in your "
                                        + "life by having you list as many things as you can i a cetain area.";

            
    private int _count = 0;
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", 
                "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", 
                "Who are some of your personal heroes?"
];

    public ListingActivity() : base(_name, _description)
    {
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        
        base.GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _count ++;
        }
        DateTime trueEndTime = DateTime.Now;
        base.SetTrueDuration(startTime,trueEndTime);

        Console.WriteLine($"You listed {_count} items!");

    }

    public void GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(_prompts.Count); // Generate a random index
        
        Console.WriteLine($"--- {_prompts[randomIndex]} ---");
    }

    // public List<string> GetListFromUser()
    // {
    //     Console.WriteLine("Give me your list");
    //     return;
    // }
}