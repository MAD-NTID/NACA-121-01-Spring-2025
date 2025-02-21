public class Shape : IShape
{
    public string Name 
    {
        // this means, public can get (read-only), but only this
        // class can write to the Property Name (hence private)
        get; private set;
    }

    public Shape(string name)
    {
        Name = name;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Shape {Name}");
    }

    // Setting this method to virtual allows you to override in the 
    // derived classes (child classes)
    public virtual double GetArea()
    {
        // this is like a default value
        return 0;
    }
}