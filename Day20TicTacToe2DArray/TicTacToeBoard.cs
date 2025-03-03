using System.Text;

public class TicTacToeBoard
{
    const int ROWS = 3, COLUMNS = 3;

    private char[,] board;
    public char[,] Board
    {
        get { return board; }
    }

    public bool Winner { get; private set; }
    public bool GameOver { get; private set; }

    public TicTacToeBoard() 
    {
        board = new char[ROWS, COLUMNS];
    }

    public void AddPiece(char piece, int row, int col)
    {
        // No Validation (this is to test the CheckWinner method)
        board[row, col] = piece;

        CheckWinner();

        IsGameOver();
    }

    public void IsGameOver()
    {
        // How do we know that the game is over if there's no winner?
        // Nai suggest if all cells are filled without winner
        int cellsFilled = 0;
        for(int r = 0; r < board.GetLength(0); r++)
        {
            for(int c = 0; c < board.GetLength(1); c++)
            {
                // This means, cell is filled with a piece
                if(board[r, c] != '\0')
                    cellsFilled++;
            }
        }

        // Indicates whether game is over or not
        GameOver = cellsFilled == (ROWS * COLUMNS);
    }

    // Method for Determine if TTOe has been won
    // Diagonal left to right, or right to left (2 ways)
    // Straight Line Down top to bottom (any column)
    // Straight Line left to right (any row)
    public void CheckWinner()
    {
        int xConsecutive = 0, oConsecutives = 0;
        
        // Start with Checking Row Winnings
        for(int r = 0; r < board.GetLength(0); r++)
        {
            for(int c = 0; c < board.GetLength(1); c++) 
            {
                if(board[r, c] == 'x')
                    xConsecutive++;
                else if(board[r, c] == 'o')
                    oConsecutives++;
                else
                    continue;
            }

            // Do we have a winner?
            if(xConsecutive == 3 || oConsecutives == 3)
            {
                Winner = true;
                return;   
            }
            else  
            {
                // Set the consecutive count back to zero before movine to the next row
                xConsecutive = 0; 
                oConsecutives = 0; 
            }
        }
    
        // Checking for Column Winnings
        for(int c = 0; c < board.GetLength(1); c++) 
        {
            for(int r = 0; r < board.GetLength(0); r++)
            {
                if(board[r, c] == 'x')
                    xConsecutive++;
                else if(board[r, c] == 'o')
                    oConsecutives++;
                else
                    continue;
            }

            // Do we have a winner?
            if(xConsecutive == 3 || oConsecutives == 3)
            {
                Winner = true;
                return;   
            }
            else  
            {
                // Set the consecutive count back to zero before movine to the next row
                xConsecutive = 0; 
                oConsecutives = 0; 
            }
        }

        // Next we check cross vertical left to right
        if( (board[0,0] == 'x' && board[1,1] == 'x' && board[2,2] == 'x') ||
            (board[0,0] == 'o' && board[1,1] == 'o' && board[2,2] == 'o'))
        {
            Winner = true;
            return;
        }

        // Next we check cross vertical right to left
        if( (board[0,2] == 'x' && board[1,1] == 'x' && board[2,0] == 'x') ||
            (board[0,2] == 'o' && board[1,1] == 'o' && board[2,0] == 'o'))
        {
            Winner = true;
            return;
        }

        // This means no one wins
        Winner = false;
    }

    // We can have a ToString that draws the board
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLUMNS; j++)
            {
                sb.Append(board[i, j] == '\0' ? ' ' : board[i, j]); // Display space for empty cells
                if (j < COLUMNS - 1)
                    sb.Append(" | ");
            }
            if (i < ROWS - 1)
                sb.AppendLine("\n---------");
        }
        
        return sb.ToString();
    }

}