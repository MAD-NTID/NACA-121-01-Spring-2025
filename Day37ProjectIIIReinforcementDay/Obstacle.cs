public class Obstacle : GameObject
{
    private string[] obstacleNames = 
    {
        "Water Fall",
        "Falling Rocks",
        "Spiked Road"
    };

    // For each obstacle, you need to attach a solution
    // Then prompt the user to select a solution
    // If the solution is mapped correctly to the obstacle
    // Then the character can go around it successfully
    // Otherwise, what are the consequences?
    // ...

    public Obstacle() 
    {
        Random random = new();

        Name = obstacleNames[random.Next(0, obstacleNames.Length - 1)];
    }

    public override string ToString()
    {
        return $"Obstacle: {base.ToString}";
    }
}