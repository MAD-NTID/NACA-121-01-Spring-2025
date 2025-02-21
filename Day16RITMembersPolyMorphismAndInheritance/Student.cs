// This is a child class (derived class), inherits from parent RITMember (base class)
public class Student : RITMember
{
    // This child class only difference is GPA, Program, in additiona
    // To the parent's Name, Role, UID
    public double GPA { get; set; }
    public string Program { get; private set; }

    // Child class's constructor
    public Student(string name, string uid, string program, double gpa) : base(name, "Student", uid)
    {
        Program = string.IsNullOrEmpty(program) ? "Unknown" : program;
        GPA = gpa < 0 || gpa > 4 ? 0 : gpa; // make sure gpa is between 0 and 4
    }

    public bool SetProgram(string program)
    {
        if(program.Equals("aas", StringComparison.CurrentCultureIgnoreCase) || 
        program.Equals("as", StringComparison.CurrentCultureIgnoreCase) ||
        program.Equals("bs", StringComparison.CurrentCultureIgnoreCase) ||
        program.Equals("ms", StringComparison.CurrentCultureIgnoreCase) ||
        program.Equals("p.h.d", StringComparison.CurrentCultureIgnoreCase))
        {
            Program = program;
            return true;
        }

        return false;
    }

    public override void Work()
    {
        base.Work();

        Console.WriteLine($"{Role} take classes, do homework, eat and sleep without showering for a whole year");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nProgram: {Program}\nGPA: {GPA}";
    }
}