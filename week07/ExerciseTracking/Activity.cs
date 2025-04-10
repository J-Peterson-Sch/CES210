public  abstract class Activity {

    private DateTime _date;
    private double _duration; //in minutes

    public Activity(double duration)
    {
        _date = DateTime.Today;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date.ToString("dd MMM yyyy");
    }

    public double GetActivityDuration()
    {
        return _duration;
    }

    public void GetSummary()
    {  Console.WriteLine($"{GetDate()} {GetType()} ({GetActivityDuration()} min)- Distance {GetDistance()} "
        + $"miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile");
    }
    public abstract double GetDistance();

    public abstract double GetSpeed();
    public abstract double GetPace();
}

