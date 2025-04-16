public class Loot : GameObject
{
    private string[] lootNames = 
    {
        "Phoenix Feather",
        "Mystic Orb",
        "Health",
        "Dragon Scale"
    };

    public Loot() 
    {
        Random random = new();

        Name = lootNames[random.Next(0, lootNames.Length - 1)];
    }

    public override string ToString()
    {
        return $"Loot: {base.ToString}";
    }
}