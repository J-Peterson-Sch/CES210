using System;

class Program
{
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber (int number)
    {
        return number * number;
    }
    static void DisplayResult (string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}