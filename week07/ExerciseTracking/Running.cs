public class Running : Activity
 {
    private double _distance;

    public Running(double duration, double distance) :base (duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetActivityDuration() * 60;
    }
    public override double GetPace()
    {
        return GetActivityDuration() / _distance;
    }
}