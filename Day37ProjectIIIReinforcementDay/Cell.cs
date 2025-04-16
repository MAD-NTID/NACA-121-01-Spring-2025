public class Cell
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public GameObject GameObject { get; private set; }

    public Cell(int x, int y, GameObject gameObject)
    {
        X = x;
        Y = y;
        GameObject = gameObject;
    }

    // How can we tell if this cell is a Loot, an Obstacle, or a Safe cell
    public bool IsEmpty()
    {
        return GameObject is null;
    }

    public override string ToString()
    {
        string gameObject = IsEmpty() ? "Empty" : GameObject.ToString();
        
        return $"Cell: ({X}, {Y}) - {gameObject}";
    }
}