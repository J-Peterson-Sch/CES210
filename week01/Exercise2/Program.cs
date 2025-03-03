using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string gradeModifier = "";
        Console.Write("What is your grade percent? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90) {
            letter = "A";
        }
        else if (grade >= 80) {
            letter = "B";
        }
        else if (grade >= 70) {
            letter = "C";
        }
        else if (grade >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        if (grade < 97 && grade >= 60) {
            if (grade % 10 >= 7 ) {
                gradeModifier = "+";
            }
            else if (grade % 10 < 3) {
                gradeModifier = "-";
            }
        }

        Console.WriteLine($"You got a {letter}{gradeModifier}.");

        if (grade > 70) {
            Console.WriteLine("You passed the class.");
        }
        else {
            Console.WriteLine("You didn't pass. Better luck next time.");
        }
    }
}