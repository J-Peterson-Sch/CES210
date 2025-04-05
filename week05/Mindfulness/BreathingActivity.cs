public class BreathingActivity : Activity {

    private int _breathInCount = 5; 
    private int _breathOutCount = 10; 
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

            Console.Clear();
        while (DateTime.Now < endTime)
        {
            Console.Write("...Breath in...");
            ShowCountDown(_breathInCount);
            Console.Write("...Breath out...");
            ShowCountDown(_breathOutCount);

            Console.WriteLine("");
        }

    }
}