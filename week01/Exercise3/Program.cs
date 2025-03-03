using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number;
        int guess = -1;
        int numGuesses = 0;
        int hightNumber = 20;
        string continuePlay;

        number = randomNumber.Next(1,hightNumber+ 1);
        Console.WriteLine($"I'm thinking of a number between 1 and {hightNumber}");
        
        do
        {
            Console.Write("What is the magic number?: ");
            guess = int.Parse(Console.ReadLine());
            if (guess != number)
            {
                numGuesses++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
            }
            else
                {
                    Console.WriteLine($"Good job! You've guessed it in {numGuesses + 1} guesses.");
                    Console.Write("Do you want to play again? (y/n): ");
                    continuePlay = Console.ReadLine().ToLower();

                    if (continuePlay == "y")
                    {
                        guess = -1;
                        numGuesses = 0;
                        number = randomNumber.Next(1,21);
                    }
                }
        } while (guess != number);
    }
}