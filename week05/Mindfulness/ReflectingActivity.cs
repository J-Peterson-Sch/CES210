public class ReflectingActivity : Activity{
    private static string _name = "Reflecting Activity";
    private static string _description = "This activity will help you reflect on times in your "
            + "life when you have shown strenght and resilience. This will help you recognize "
            + "the power you have and how you can use it in outher aspects of your life.";

    private List<string> _prompts = ["Think of a time when you did something really difficult",
    "Think of a time when you acomplished something really great", "Think of a time when you helped someone do something great"];

    private List<string> _questions = ["Why was this experience meaningful to you?", 
    "Have you ever done anything like this before?", "How did you get started?", 
    "How did you feel when it was complete?", 
    "What made this time different than other times when you were not as successful?", 
    "What is your favorite thing about this experience?", 
    "What could you learn from this experience that applies to other situations?", 
    "What did you learn about yourself through this experience?", 
    "How can you keep this experience in mind in the future?"];

    private int _reflectingTime = 8;

    public ReflectingActivity() : base(_name, _description)
    {
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Consider the follwoing prompt:");
        Console.WriteLine("");

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("");
        Console.WriteLine("You may beging in:");
        ShowCountDown(5);
        Console.Clear();

        base.GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }
        DateTime trueEndTime = DateTime.Now;
        base.SetTrueDuration(startTime,trueEndTime);
    }

    public string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(_prompts.Count); // Generate a random index
        return _prompts[randomIndex];
        
    }

    public string GetRandomQuestion()
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(_questions.Count);
        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()}. ---");
        Console.WriteLine("");
    }
    public void DisplayQuestion()
    {   
        Console.Write($"> {GetRandomQuestion()} -");
        ShowSpinner(_reflectingTime);
        Console.WriteLine("");
    }
}