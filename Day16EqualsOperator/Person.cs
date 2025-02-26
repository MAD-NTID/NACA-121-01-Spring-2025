public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    // If you do not OVERRIDE this method, it will behave by default like a reference comparator ==
    public override bool Equals(object? obj)
    {
        // This is a new feature of .net 9
        return obj is Person other && Name == other.Name;
    }

    public override string ToString()
    {
        return $"Person Name: {Name}";
    }
}