using System.Text.RegularExpressions;

class Person
{
    //  Personal Identifiable Information
    private string name;
    public string Name 
    {
        get { return name; }
        
        set 
        {
            if(string.IsNullOrEmpty(value) || value.Length < 2)
                value = "Undefined";

            name = value;
        }
    }

    private int age;
    public int Age 
    {
        get 
        {
            return age;
        }

        set
        {
            if(value < 0)
                value = 0;

            age = value;
        }
    }

    private double weight, height;
    public double Weight
    {
        get
        {
            return weight;
        }

        set
        {
            if(value < 0)
                value = 0;

            weight = value;
        }
    }

    public double Height
    {
        get
        {
            return height;
        }

        set
        {
            if(value < 0)
                value = 0;

            height = value;
        }
    }

    private string ssn;
    public string SSN
    {
        get
        {
            // How to return something like this ***-**-1234
            string newSSN = ssn[^4..];

            return $"***-**-{newSSN}";
        }

        set
        {
            string pattern = @"^\d{3}-?\d{2}-?\d{4}$";
            Regex regex = new Regex(pattern);

            // Validate SSN is valid, if not, assign 000-00-0000 as default
            if(!regex.IsMatch(value))
                value = "000-00-0000";

            ssn = value;
        }
    }

    // type propfull and then the tab key to automatically insert a template
    private string stateLicense;
    public string StateLicense
    {
        get { return stateLicense; }
        set { stateLicense = value; }
    }
    
    // If your properties do not require validation, you can just get; set;
    private string hairColor;
    public string HairColor
    {
        get; set;
    }
    

    // Default Constructor (Empty)
    public Person() {}

    public Person(string name, int age, double weight, double height, string ssn)
    {
        // SetFirstName(name);
        Name = name;
        Age = age;
        Weight = weight;
        Height = height;
        SSN = ssn;
    }
}