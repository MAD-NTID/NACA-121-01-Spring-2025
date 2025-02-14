// this means, Character inherits from ICharacter
public class Character : ICharacter
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int health;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(ICharacter target)
    {
        throw new NotImplementedException();
    }

    public void Defend()
    {
        throw new NotImplementedException();
    }
}