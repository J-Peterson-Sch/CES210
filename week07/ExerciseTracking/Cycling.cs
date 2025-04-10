public class Cycling : Activity
 {

    private double _speed;

    public Cycling(double duration, double speed) :base (duration)
    {
        _speed = speed;
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