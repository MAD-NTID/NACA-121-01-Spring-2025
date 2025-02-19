public interface IBeast
{
    public const string WATER = "Water";
    public const string LIGHTNING = "Lightning";

    public string Name { get; set; }
    public double MaxHealth { get; set; }
    public double CurrentHealth { get; set; }
    public string Weakness { get; set; }

    // How much damage is this beast getting
    public void TakeDamage(double damage);

    // Who is this beast attacking, and how much damage
    public void Attack(IBeast beast, double damage);
}