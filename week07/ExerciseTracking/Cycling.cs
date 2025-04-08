public class Cycling : Activity
 {

    private double _speed;

    public Cycling(double duration, double speed) :base (duration)
    {
        _speed = speed;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {this.GetType()} ({GetActivityDuration()} min)- Distance {GetDistance()} "
        + $"miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile");
    }

    public override double GetDistance()
    {
        return _speed * GetActivityDuration() / 60;
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