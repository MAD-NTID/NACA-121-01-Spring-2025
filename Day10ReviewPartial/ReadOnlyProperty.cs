class SomeClass
{
    // How to declare read-only property
    private string myVar;
    public string MyVar
    {
        get { return myVar; }
    }

    public bool RoleValid(string role)
    {
        string[] roles = {
            // put the roles in here
        };

        for(int i = 0; i < roles.Length; i++)
            if(roles[i].Equals(role, StringComparison.CurrentCultureIgnoreCase))
                return true;

        return false;
    }
}