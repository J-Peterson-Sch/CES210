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

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");

        int userInput;
        bool isValid = false;

        while (!isValid)
        {
            Console.WriteLine("How long, in seconds, would you like your session to last?: ");
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
        Console.WriteLine("Get ready...");
        ShowCountDown(5);

    }

    public void DisplayEndingMessage()
    {
        // Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Good job!");
        ShowSpinner(5);

        Console.Clear();
        Console.WriteLine($"You spent {_duration} seconds preforming the {_name} activity.");
        ShowSpinner(5);
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

    public void ShowMovingDots(int seconds)
    {
        int characterSetLength = 0;
        Console.Write("\r{0, "+characterSetLength+"}", " ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("       .   .   .   .   .");
            Thread.Sleep(200);

            Console.Write("\r{0, "+characterSetLength+"}", " ");
            Console.Write("   .       .   .   .   .");

            Thread.Sleep(200);

            Console.Write("\r{0, "+characterSetLength+"}", " ");
            Console.Write("   .   .       .   .   .");

            Thread.Sleep(200);

            Console.Write("\r{0, "+characterSetLength+"}", " ");
            Console.Write("   .   .   .       .   .");

            Thread.Sleep(200);

            Console.Write("\r{0, "+characterSetLength+"}", " ");
            Console.Write("   .   .   .   .       .");

            Thread.Sleep(200);

            Console.Write("\r{0, "+characterSetLength+"}", " ");
            Console.Write("   .   .   .   .   .    ");

            Thread.Sleep(200);

            Console.Write("\r{0, "+characterSetLength+"}", " ");
        }
    }

    public void ShowCountDown(int seconds)
    {
        // Get initial cursor position
        int leftPosition = Console.CursorLeft;

        for (int i = seconds; i >= 0; i--)
        {
            Console.SetCursorPosition(leftPosition, Console.CursorTop);
            Console.Write(" {0}  ", i); 
            Thread.Sleep(1000); 
        }

        Console.WriteLine(); 
    }
}