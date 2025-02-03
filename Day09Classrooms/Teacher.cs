class Teacher
{
    private string name;
    public string Name
    {
        get { return name; }
        set 
        { 
            // this is ternary operator
            name = string.IsNullOrEmpty(value) ? "Undefined" : value; 

            // The above is the same thing as the below
            // if(string.IsNullOrEmpty(value))
            //     value = "Undefined";

            // name = value;
        }
    }

    public override string ToString()
    {
        return $"Teacher Name: {name}";
    }
}