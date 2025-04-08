public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radious) : base (color)
    {
        _radius = radious;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}