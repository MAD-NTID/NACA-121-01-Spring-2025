class Alien
{
    public const string 
        CAPTAIN = "Captain", 
        CHIEF_OFFICER = "Chief Officer", 
        NAVIGATOR = "Navigator", 
        PILOT = "Pilot", 
        ENGINEER = "Engineer", 
        DOCTOR = "Doctor";

    private string name;
    public string Name
    {
        get { return name; }
        set { name = string.IsNullOrEmpty(value) ? "Undefined" : value; }

        // set 
        // {
        //     if(string.IsNullOrEmpty(value))
        //         name = "Undefined";
        //     else
        //         name = value;
        // }
    }
    
    private string role;
    public string Role
    {
        get { return role; }
        set { role = IsValidRole(value) ? value : "Unknown Role"; }
    }

    public Alien(string name, string role)
    {
        Name = name;
        Role = role;
    }

    private bool IsValidRole(string role)
    {
        // This will return either true or false depending on local 'role' value
        // return 
        //     role.Equals(CAPTAIN, StringComparison.CurrentCultureIgnoreCase) || 
        //     role.Equals(CHIEF_OFFICER, StringComparison.CurrentCultureIgnoreCase) ||
        //     role.Equals(NAVIGATOR, StringComparison.CurrentCultureIgnoreCase) ||
        //     role.Equals(PILOT, StringComparison.CurrentCultureIgnoreCase) ||
        //     role.Equals(ENGINEER, StringComparison.CurrentCultureIgnoreCase) ||
        //     role.Equals(DOCTOR, StringComparison.CurrentCultureIgnoreCase);

        return 
            role.Equals("captain", StringComparison.CurrentCultureIgnoreCase) || 
            role.Equals("chief officer", StringComparison.CurrentCultureIgnoreCase) ||
            role.Equals("navigator", StringComparison.CurrentCultureIgnoreCase) ||
            role.Equals("pilot", StringComparison.CurrentCultureIgnoreCase) ||
            role.Equals("engineer", StringComparison.CurrentCultureIgnoreCase) ||
            role.Equals("doctor", StringComparison.CurrentCultureIgnoreCase);
    }

    public override string ToString()
    {
        return $"Name: {name} - Role: {role}";
    }
}