public class BreathingActivity : Activity {

    private int _breathCount = 10; //breath count in seconds
    public static string _name = "Breathing Activity";
    private static string _description = "This activity will help you relax by walking you through "
                                    + "breathing in and out slowly. Clear your mind and focus "
                                    + "on your breathing.";

    public BreathingActivity() : base(_name, _description)
    {

    }

    public void Run()
    {
        base.GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("...Breath in...");
            ShowCountDown(_breathCount);

            Console.Clear();
            Console.WriteLine("...Breath out...");
            ShowCountDown(_breathCount);

        }

    }
}