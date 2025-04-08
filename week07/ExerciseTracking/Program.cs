using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(30,3);
        activities.Add(running);

        Cycling cycling = new Cycling(30,15);
        activities.Add(cycling);

        Swimming swimming = new Swimming(30,50);
        activities.Add(swimming);


        Console.Clear();
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine("");
        }
    }
}