using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity text = new BreathingActivity("Jumping", "test");

        text.ShowCountDown(100);

    // #nullable enable
    //     string? userInput;
    // #nullable disable
    //     bool validInput;

    //     Console.Clear();
    //     do {
    //         Console.WriteLine("Welcome to Jordan's Minfulness App");
    //         Console.WriteLine("1. Breathing Exercise");
    //         Console.WriteLine("2. Reflection Activity");
    //         Console.WriteLine("3. Listing Activity");
    //         Console.WriteLine("4. Quit");
    //         Console.Write("Make a selection: ");
            
    //         // validates user input
    //         do{
    //             userInput = Console.ReadLine();
    //             if(!string.IsNullOrEmpty(userInput)){
    //                 if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5" ){
    //                     validInput = true;
    //                 }
    //                 else{
    //                     Console.WriteLine("That's not a valid input.");
    //                     validInput = false;
    //                 }
    //             }
    //             else{
    //                 Console.WriteLine("You failed to enter a selection.");
    //                 validInput = false;
    //             }
    //         } while (!validInput);

    //         //Write an entry
    //         if (userInput == "1"){
                
    //         }
    //         //Display journal
    //         else if(userInput == "2"){
                
    //         }
    //         //Load
    //         else if(userInput == "3"){
                
    //         }
    //         //Save Entries
    //         else if(userInput == "4"){
                
    //         }
    //     } while(userInput != "5");
    }
}