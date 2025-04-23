public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Person(string? name, int age)
    {
        Name = string.IsNullOrEmpty(name) ? "No Name" : name;
        Age = age < 0 ? 0 : age;
    }

    public override string ToString()
    {
        return $"Name: {Name} - Age: {Age}";
    }
}