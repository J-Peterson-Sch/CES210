using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignment = new Assignment("Sally", "Reconstruction");
        Console.Clear();
        Console.WriteLine(testAssignment.GetSummary());

    }
}