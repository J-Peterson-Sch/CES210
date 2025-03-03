using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        
        do {
            Console.Write("Enter a list of numbers, type 0 when finished.  ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0) {
                numbers.Add(number);    
            }
            
        } while (number != 0);

        Console.WriteLine($"Sum: {numbers.Sum()}");
        Console.WriteLine($"Average: {numbers.Sum() / numbers.Count}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}