public class Human : BipedalHumanoid
{
    public Human(string name, int age) : base(name, age) {}

    public override string Talk()
    {
        return "Hello world, ... yh I can talk";
    }
}