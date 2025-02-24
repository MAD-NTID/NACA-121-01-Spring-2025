public class Alien : BipedalHumanoid
{
    public Alien(string name, int age) : base(name, age) {}

    public override string Talk()
    {
        return "echo location... (gibberish)";
    }
}