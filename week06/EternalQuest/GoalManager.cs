public class GoalManager
{
    private int _score = 0;
    private List<Goal> goals = new List<Goal>();

    public GoalManager()
    {
    }
    
    public void Start()
    {
        #nullable enable
        string? userInput;
        #nullable disable
        bool validInput;

        do {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest");
            DisplayPlayerInfo();
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Make a selection: ");
            
            // validates user input
            do{
                userInput = Console.ReadLine();
                if(!string.IsNullOrEmpty(userInput)){
                    if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5" || userInput == "6" ){
                        validInput = true;
                    }
                    else{
                        Console.WriteLine("That's not a valid input.");
                        validInput = false;
                    }
                }
                else{
                    Console.WriteLine("You failed to enter a selection.");
                    validInput = false;
                }
            } while (!validInput);

            // Create New Goal
            if (userInput == "1"){
                userInput = "";
                do
                {
                    Console.Clear();
                    Console.WriteLine("The types of goals are...");
                    Console.WriteLine("   1. Simple Goal");
                    Console.WriteLine("   2. Eternal Goal");
                    Console.WriteLine("   3. Checklist Goal");
                    userInput = Console.ReadLine();
                } while (userInput != "1" && userInput != "2" && userInput != "3");

                if (userInput == "1")
                {
                    CreateGoalWithPrompt("SimpleGoal");
                }
                else if(userInput == "2")
                {
                    CreateGoalWithPrompt("EternalGoal");
                }
                else if(userInput == "3")
                {
                    CreateGoalWithPrompt("ChecklistGoal");
                }

            }

            // List Goals
            else if(userInput == "2"){
                Console.Clear();
                Console.WriteLine("Your goals are...");
                
                int counter = 1;
                foreach (Goal goal in goals)
                {
                    if (goal.GetType().ToString() == "EternalGoal")
                    {
                        Console.Write($"{counter}. [ ] ");
                    }
                    else
                    {
                        if (goal.IsComplete())
                        {
                            Console.Write($"{counter}. [X] ");
                        }
                        else
                        {
                            Console.Write($"{counter}. [ ] ");
                        }
                    }
                    
                    ListGoalNames(goal);
                    ListGoalDetails(goal);
                    counter ++;
                }
                Console.WriteLine("");
                Console.WriteLine("Hit enter to continue...");
                Console.ReadLine();
            }
            // Save Goals
            else if(userInput == "3"){
                SaveGoals();
            }
            // Load Goals
            else if(userInput == "4"){
                LoadGoals();
            }
            // Record Event
            else if(userInput == "5")
            {
                RecordEvent();
            }

        } while(userInput != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points.");
    }

    public void ListGoalNames(Goal goal)
    {
        Console.Write($"{goal.GetName()} ");
    }

    public void ListGoalDetails(Goal goal)
    {
        Console.Write($"({goal.GetDescription()})");
        if (goal.GetType().ToString() == "ChecklistGoal")
        {
            string[] goalData = goal.GetStringRepresentation().Split("|");
            string target = goalData[4];
            string amountCompleated = goalData[5];
            Console.Write($" -- {amountCompleated}/{target}");
        }
        Console.WriteLine("");
    }
    public void CreateGoalWithPrompt(string goalType)
    {
        string goalName;
        string shortDescription;
        string points;
        string target;
        string bonus;

        Console.Clear();
        Console.Write("What is the name of your goal?: ");
        goalName = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is a short description of this goal?: ");
        shortDescription = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("How many point for compleating this goal?: ");
        points = Console.ReadLine();
        List<string> goalData = new List<string>();
        goalData = [goalName, shortDescription, points];

        if (goalType == "SimpleGoal")
        {
            CreateGoal("SimpleGoal", goalData);
        }
        else if (goalType == "EternalGoal")
        {
            CreateGoal("EternalGoal", goalData);
        }
        else if (goalType == "ChecklistGoal")
        {
            Console.WriteLine("");
            Console.Write("How may times does the goal need to be accomplished for a bonus?: ");
            target = Console.ReadLine();
            goalData.Add(target);

            Console.WriteLine("");
            Console.Write("How many bonus points will you achive?: ");
            bonus = Console.ReadLine();
            string amountComplete = "0";
            goalData.Add(amountComplete);
            goalData.Add(bonus);
            CreateGoal("ChecklistGoal", goalData);
        }
        else
        {
            Console.WriteLine("There was an error creating the goal. Unkown goal type.");
        }
    }

    public void CreateGoal(string goalType, List<string> goalData)
    {
        string name = goalData[0];
        string description = goalData[1];
        string points = goalData[2];    

        if (goalType == "SimpleGoal")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            goals.Add(goal);
        }
        else if (goalType == "EternalGoal")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            goals.Add(goal);
        }
        else if (goalType == "ChecklistGoal")
        {
            int target = int.Parse(goalData[3]);
            int amountComplete = int.Parse(goalData[4]);
            int bonus = int.Parse(goalData[5]);
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, amountComplete, bonus);
            goals.Add(goal);
        }
        else
        {
            Console.WriteLine("There was an error creating the goal. Unkown goal type.");
        }
    }
    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Your goals are...");
        
        int counter = 1;
        foreach (Goal goal in goals)
        {
            Console.Write($"{counter}. ");
            ListGoalNames(goal);
            Console.WriteLine("");
            counter ++;
        }
        Console.WriteLine("");
        Console.Write("Which goal did you accomplish?: ");
        string userInput = Console.ReadLine();
        Goal accomplishedGoal = goals[int.Parse(userInput)-1];
        accomplishedGoal.RecordEvent();
        _score += int.Parse(accomplishedGoal.GetPoints());

        if (accomplishedGoal.GetType().ToString() == "ChecklistGoal")
        {
            if (accomplishedGoal.IsComplete())
            {
                string[] goalData = accomplishedGoal.GetStringRepresentation().Split("|");
                string bonus = goalData[6];
                _score += int.Parse(bonus);
            }
        }
    }
    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("Enter the file name you want to save to: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");

            foreach (Goal goal in goals)
            {
                outputFile.Write(goal.GetType().ToString());
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("Enter the file name you want to load from: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int counter = 0;
        goals = [];

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (counter == 0)
            {
                _score = int.Parse(parts[0]);
                counter++;
            }
            else
            {
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                    goals.Add(simpleGoal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal simpleGoal = new EternalGoal(name, description, points);
                    goals.Add(simpleGoal);
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int amountComplete = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    ChecklistGoal simpleGoal = new ChecklistGoal(name, description, points, target, amountComplete, bonus);
                    goals.Add(simpleGoal);
                }
            }
        }
    }
}    