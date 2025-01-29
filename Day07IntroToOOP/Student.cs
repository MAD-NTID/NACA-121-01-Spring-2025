// At this point, you are "encapsulating" everything in this class
// Think of it like a pill that has all the drug in it
class Student
{
    // This is abstraction, you tell the class what kind of data it needs
    // But do not provide actual data here
    public string name, major;
    public int age;
    private string ssn;

    // This is an empty constructor, it will allow you to instantiate without providing parameters
    public Student() {}

    // This is the parameterized constructor (method), it MUST be public
    public Student(string name, string major, int age, string ssn)
    {
        // Validate that name is not empty
        if(string.IsNullOrEmpty(name))
            name = "Undefined Name";

        this.name = name;

        if(string.IsNullOrEmpty(major))
            major = "Undefined Major";

        this.major = major;

        if(age < 0)
            age = 0;

        this.age = age;

        if(string.IsNullOrEmpty(ssn))
            ssn = "000-00-0000";

        this.ssn = ssn;
    }
}