public class Circle : Shape
{
    private double radius;
    public double Radius
    {
        get { return radius; }
        set { radius = value < 0 ? 0 : value; }
    }    

    public Circle(double radius) : base("Circle") 
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}