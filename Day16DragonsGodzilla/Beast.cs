public class Beast : IBeast
{
    private string name;
    public string Name 
    { 
        get
        {
            return name;
        }

        set
        {
            name = string.IsNullOrEmpty(value) ? "Undefined Name" : value;
        }
    }
    
    private double maxHealth;
    public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
    private double currentHealth;
    public double CurrentHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
    private string weakness;
    public string Weakness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public virtual void Attack(IBeast beast, double damage)
    {
        throw new NotImplementedException();
    }

    public virtual void TakeDamage(double damage)
    {
        throw new NotImplementedException();
    }

    public virtual string HelloWorld()
    {
        return $"Hello, I am Dad";
    }
}