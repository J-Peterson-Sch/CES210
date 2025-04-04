// Jordan Peterson
// For my createive bit, I count the actual time that a user spends on an activity and display that to
// the user at the end.

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // BreathingActivity text = new BreathingActivity("Jumping", "test");

        // text.DisplayEndingMessage();

        // System.Console.WriteLine("|test{0,3}|","+");

    #nullable enable
        string? userInput;
    #nullable disable
        bool validInput;

        do {
            Console.Clear();
            Console.WriteLine("Welcome to Jordan's Minfulness App");
            Console.WriteLine("   1. Start a Breathing Exercise");
            Console.WriteLine("   2. Start a Reflection Activity");
            Console.WriteLine("   3. Start a Listing Activity");
            Console.WriteLine("   4. Quit");
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
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndingMessage();
            }
            //Display journal
            else if(userInput == "2"){
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.DisplayStartingMessage();
                reflecting.Run();
                reflecting.DisplayEndingMessage();
            }
            else if(userInput == "3"){
                ListingActivity listing = new ListingActivity();
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
            }
            //Save Entries
            else if(userInput == "4"){
                
            }
        } while(userInput != "4");
    }
}