public class World
{
    const int DEFAULT_WORLD_SIZE = 3;

    // We need a randomizer for randomizing GameObjects in the world
    private Random random;

    // We need a 2D array to hold the cells that represent the world
    private Cell[,] world;

    // We need two variables to determine the length of the 2d arrays, x, and y
    private int XLength { get; }
    private int YLength { get; }

    public World(int xLength = 0, int yLength = 0)
    {
        // Force the world to be at least 3x3 if user provides invalid values
        XLength = xLength < DEFAULT_WORLD_SIZE ? DEFAULT_WORLD_SIZE : xLength;
        YLength = yLength < DEFAULT_WORLD_SIZE ? DEFAULT_WORLD_SIZE : yLength;

        // Build the world - Initialize the 2D Array
        world = new Cell[XLength, YLength];

        // ... now it's your responsibility from here to continue the project
    }
}