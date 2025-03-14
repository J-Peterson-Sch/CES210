using System;
public class JournalProject
{
    static void Main()
    {
        string? userInput;
        bool validInput;

        //Sets the working dir to the same as the project.cs file
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
        Directory.SetCurrentDirectory(projectDirectory);
        
        Journal workingJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator("prompts.txt");

        Console.Clear();
        do {
            Console.WriteLine("Your daily journal app.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Make a selection: ");
            
            // validates user input
            do{
                userInput = Console.ReadLine();
                if(!string.IsNullOrEmpty(userInput)){
                    if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5" ){
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

            //Write an entry
            if (userInput == "1"){
                string prompt;
                Console.Clear();
                prompt = promptGenerator.getRandomPrompt();
                Console.WriteLine(prompt);
                string userEnteredText = Console.ReadLine();
                string timestamp = "";
                workingJournal.addEntry(prompt, userEnteredText, timestamp);
                Console.Clear();
            }
            //Display journal
            else if(userInput == "2"){
                Console.Clear();
                workingJournal.displayAll();
            }
            //Load
            else if(userInput == "3"){
                string[] loadedEntries;
                Console.Clear();
                Console.Write("Enter the file name you want to load from: ");
                string loadFilePath = Console.ReadLine();

                if (File.Exists(loadFilePath))
                {
                    loadedEntries = File.ReadAllLines(loadFilePath);

                    foreach (string entry in loadedEntries){
                        string[] splitEntry = entry.Split("|");
                        workingJournal.addEntry(timestamp: splitEntry[0], promt: splitEntry[1], userEnteredText: splitEntry[2]);
                    }
                }
                else
                {
                    Console.WriteLine("File not found.");
                    loadedEntries = new string[0];
                }

                if (loadedEntries.Length == 0)
                {
                    Console.WriteLine("No entries were loaded.");
                }
            }
            //Save Entries
            else if(userInput == "4"){
                Console.Clear();
                Console.Write("Enter the file name you want to save to: ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName)){
                    foreach (Entry entry in workingJournal._entries)
                    {
                        outputFile.WriteLine(entry.display());
                    }
                }
            }
        } while(userInput != "5");
    }
}
