public interface IBoard
{
    // Returns the 2d Array of IPiece(s)
    public IPiece[,] GetCells();

    public void Initialize();

    public bool Place(int row, int col, IPiece piece);

    public bool IsEmptySpot(int row, int col);

    public IPiece GetPiece(int row, int col);

    
}