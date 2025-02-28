// Build a Tic Tac Toe Board
TicTacToeBoard board = new();

// Because No Winner is False, we need to invert it to True
// In order to continue the loop
// Remember while() expects true to continue looping, 
// false breaks the loop
while(!board.Winner && !board.GameOver) 
{
    // Show the board each time we loop
    Console.WriteLine(board);

    Console.Write("Enter 'x' or 'y': ");
    char pieceInput = Console.ReadLine().ToLower()[0];

    Console.Write("Enter Row (0, 2): ");
    int rowInput = int.Parse(Console.ReadLine());

    Console.Write("Enter Column (0, 2): ");
    int colInput = int.Parse(Console.ReadLine());

    board.AddPiece(pieceInput, rowInput, colInput);
}

// If reached this point, we have a winner or no winner
if(board.Winner)
{
    Console.WriteLine("We have a winner");
}
else 
{
    Console.WriteLine("No Winner");
}

if(board.GameOver)
{
    Console.WriteLine("The board is full");
}