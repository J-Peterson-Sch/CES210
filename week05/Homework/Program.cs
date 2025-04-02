using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignment = new Assignment("Sally", "Reconstruction");
        Console.Clear();
        Console.WriteLine(testAssignment.GetSummary());

        MathAssignment testMathAssignemnt = new MathAssignment("Billy Bob", "Algibra", "12.2", "1-15 odds only");
        Console.WriteLine("");
        Console.WriteLine(testMathAssignemnt.GetSummary());
        Console.WriteLine(testMathAssignemnt.GetHomeworkList());

        WritingAssignment testWritingAssignemnt = new WritingAssignment("Googly Sam", "The Great War", "Drug use in the trenches");
        Console.WriteLine("");
        Console.WriteLine(testWritingAssignemnt.GetSummary());
        Console.WriteLine(testWritingAssignemnt.GetWritingInformation());
    }
}