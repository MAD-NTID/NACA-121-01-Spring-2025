using System;

public class Godzilla : Beast
{
    public Godzilla(string name) : base(name) {}

    // Override to specify that Godzilla throws spikes.
    public override void AbilityAttack(IBeast beast)
    {
        double damage = GetAbilityAttackDamage();
        Console.WriteLine($"{Name} throws spikes at {beast.Name} for {damage:F1} damage!");
        beast.TakeDamage(damage);
    }
}
