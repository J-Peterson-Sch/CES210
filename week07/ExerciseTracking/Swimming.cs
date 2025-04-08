public class Swimming : Activity
 {

    private int _laps;

    public Swimming(double duration, int laps) :base (duration)
    {
        _laps = laps;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {this.GetType()} ({GetActivityDuration()} min)- Distance {GetDistance()} "
        + $"miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile");
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetActivityDuration() * 60;
    }
    public override double GetPace()
    {
        return GetActivityDuration() / GetDistance();
    }
}