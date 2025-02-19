using System;

public class Beast : IBeast
{
    private static readonly Random random = new Random();
    private const int MIN_HEALTH = 80, MAX_HEALTH = 100;
    private const int MIN_ATTACK_POWER = 10, MAX_ATTACK_POWER = 20;

    public string Name { get; }
    public double MaxHealth { get; }
    public double CurrentHealth { get; private set; }
    public double AttackPower { get; }

    public Beast(string name)
    {
        Name = string.IsNullOrEmpty(name) ? "Unnamed Beast" : name;
        MaxHealth = CurrentHealth = random.Next(MIN_HEALTH, MAX_HEALTH + 1);
        AttackPower = random.Next(MIN_ATTACK_POWER, MAX_ATTACK_POWER + 1);
    }

    public void TakeDamage(double damage)
    {
        CurrentHealth = Math.Max(0, CurrentHealth - damage);
    }

    // Physical attack deals damage equal to AttackPower.
    public void Attack(IBeast beast)
    {
        Console.WriteLine($"{Name} attacks {beast.Name} for {AttackPower} damage!");
        beast.TakeDamage(AttackPower);
    }

    // Ability attack deals 15% - 20% (randomized) additional damage on top of the physical attack.
    public int GetAbilityAttackDamage()
    {
        return (int) (AttackPower * (1.15 + random.NextDouble() * (1.15 - 1.20)));
    }

    public virtual void AbilityAttack(IBeast beast)
    {
        double damage = GetAbilityAttackDamage();
        Console.WriteLine($"{Name} uses its special ability on {beast.Name} for {damage:F1} damage!");
        beast.TakeDamage(damage);
    }

    public override string ToString()
    {
        return  $"Name: {Name}\n" +
                $"Health: {CurrentHealth}/{MaxHealth}\n" +
                $"Attack Power: {AttackPower}";
    }
}