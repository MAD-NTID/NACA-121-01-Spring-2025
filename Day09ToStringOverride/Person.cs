using System.Text.RegularExpressions;

class Person
{
    //  Personal Identifiable Information
    private string name;
    private int age;
    private double weight, height;
    private string ssn;

    // Default Constructor (Empty)
    public Person() {}

    public Person(string name, int age, double weight, double height, string ssn)
    {
        SetFirstName(name);
        SetAge(age);
        SetWeight(weight);
        SetHeight(height);
        SetSSN(ssn);
    }

    //  Setter Methods
    public void SetFirstName(string name)
    {
        if(string.IsNullOrEmpty(name) || name.Length < 2)
            name = "Undefined";

        this.name = name;
    }

    public void SetAge(int age)
    {
        if(age < 0)
            age = 0;

        this.age = age;
    }

    public void SetWeight(double weight)
    {
        if(weight < 0)
            weight = 0;

        this.weight = weight;
    }

    public void SetHeight(double height)
    {
        if(height < 0)
            height = 0;

        this.height = height;
    }

    public void SetSSN(string ssn)
    {
        string pattern = @"^\d{3}-?\d{2}-?\d{4}$";
        Regex regex = new Regex(pattern);

        // Validate SSN is valid, if not, assign 000-00-0000 as default
        if(!regex.IsMatch(ssn))
            ssn = "000-00-0000";

        this.ssn = ssn;
    }

    // Getter Methods
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public double GetWeight()
    {
        return weight;
    }

    public double GetHeight()
    {
        return height;
    }

    public string GetSSN()
    {
        // How to return something like this ***-**-1234
        string newSSN = ssn[^4..];

        // 123-12-1234
        // ssn.Substring(7);
        return $"***-**-{newSSN}";
        // return ssn;
    }

    public override string ToString()
    {
        return $"Person Name: {name}\nAge: {age}\nHeight: {height}\nWeight: {weight}\nSSN: {ssn}";
    }
}