using System;

public class Dragon : Beast
{
    public Dragon(string name) : base(name) {}

    // Override to specify that the Dragon uses fire breath.
    public override void AbilityAttack(IBeast beast)
    {
        double damage = GetAbilityAttackDamage();
        Console.WriteLine($"{Name} uses Fire Breath on {beast.Name} for {damage:F1} damage!");
        beast.TakeDamage(damage);
    }
}
