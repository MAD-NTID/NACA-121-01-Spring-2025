public interface IBeast
{
    string Name { get; }
    double MaxHealth { get; }
    double CurrentHealth { get; }
    double AttackPower { get; }

    void TakeDamage(double damage);
    void Attack(IBeast beast);
    void AbilityAttack(IBeast beast);
}