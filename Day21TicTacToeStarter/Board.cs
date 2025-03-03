public class Board : IBoard
{
    private IPiece[,] cells;
    const int ROWS = 3, COLS = 3;

    public Board(int rows, int cols)
    {

    }

    public IPiece[,] GetCells()
    {
        return null;
    }

    public IPiece GetPiece(int row, int col)
    {
        return null;
    }

    public void Initialize()
    {
        throw new NotImplementedException();
    }

    public bool IsEmptySpot(int row, int col)
    {
        return false;
    }

    public bool Place(int row, int col, IPiece piece)
    {
        return false;
    }
}