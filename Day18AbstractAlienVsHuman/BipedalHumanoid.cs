public abstract class BipedalHumanoid
{
    private string name;
    private int age;

    public BipedalHumanoid(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Common method but different behavior
    public abstract string Talk();

    // Common method and same behavior
    public string Run()
    {
        return $"Run on its two legs";
    }

    public override string ToString()
    {
        return $"My name is {name} and I am {age} years old. I am {GetType()}";
    }
}