public abstract class Piece : IPiece
{
    public string Owner { get; }

    public char Symbol { get; }

    public Piece(string owner, char symbol)
    {
        Owner = owner;
        Symbol = symbol;
    }
}