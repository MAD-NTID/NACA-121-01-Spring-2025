class Student
{
    private const string INVALID_GRADE = "Invalid";

    private string name;
    public string Name
    {
        get { return name; }
        set { name = string.IsNullOrEmpty(value) ? "Undefined" : value; }
    }

    private string letterGrade;
    public string LetterGrade
    {
        get { return letterGrade; }
        set 
        { 
            if(
                value.Equals("a", StringComparison.CurrentCultureIgnoreCase) ||
                value.Equals("b", StringComparison.CurrentCultureIgnoreCase) ||
                value.Equals("c", StringComparison.CurrentCultureIgnoreCase) ||
                value.Equals("d", StringComparison.CurrentCultureIgnoreCase) ||
                value.Equals("f", StringComparison.CurrentCultureIgnoreCase)) {
                    letterGrade = value.ToUpper(); 
                }
            else
                letterGrade = null;
        }
    }



    public string Passing()
    {
        // If grade is invalid, return "Invalid Grade"
        if(string.IsNullOrEmpty(letterGrade))
            return INVALID_GRADE;

        //  Passing is a, b, c, d. Fail is f
        return letterGrade.Equals("f", StringComparison.CurrentCultureIgnoreCase) ? "Fail" : "Pass";
    }
    

    public override string ToString()
    {
        return $"Student Name: {name}\n" +
                $"Grade: {letterGrade}\n" +
                $"Status: {Passing()}";
    }
}