public class Activity {

    private string _name;
    private string _description;
    private int _duration = 0;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
        // this._duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"You are about to start the {_name}");
        Console.WriteLine(_description);

        int userInput;
        bool isValid = false;

        while (!isValid)
        {
            Console.WriteLine("How many seconds would you like your session to last?: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userInput))
            {
                isValid = true;
                _duration = userInput;
            }
            else
            {
                Console.WriteLine("Please enter a number of seconds you would like the session to last: ");
            }
        }

        Console.Clear();
        Console.WriteLine("You have 5 seconds to prepare your self...");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("This is the ending message");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\u2014");
            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        Console.Clear();
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}"); // \r sends the cursor to the beginning of the line
            Thread.Sleep(200);          // Pause for one second

        // Clear any extra characters from previous outputs
            Console.Write("\r{0, " + seconds.ToString().Length + "}", " ");
        }
        
        Console.WriteLine(); // New line after the countdown finishes
    }
}