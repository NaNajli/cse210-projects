public class Circle:Shape
{
    private double _radius;

    public Circle(string color , double radius ):base(color)
    {
     double _radius = radius;
    }
    public double SetRadius(double radius)
    {
       return radius;
    }
    public void GetRadius(double radius)
    {
     double _radius = radius;
    }
    public override double GetArea()
    {
        return _radius /2;
    }
}