using Tic_Tac_Toe;

Game_Engine ge = new Game_Engine();

bool validSubmission = true;
bool gameOver = false;

// Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

// Ask for the players' names
Console.WriteLine("Player 1, please enter your name: ");
string player1 = Console.ReadLine();

Console.WriteLine("Player 2, please enter your name: ");
string player2 = Console.ReadLine();


// Create a game board array to store the player's choices

char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

// Ask each player in turn for their choice and update the game board array
do
{
    //ge.printBoard(board);

    Console.WriteLine($"{player1} (x), please select a position (0-8).");

    int position = int.Parse(Console.ReadLine());

    // Check to make sure it is a valid submission

    do
    {
        if (position > 8 || position < 0)
        {
            Console.WriteLine("Please select a valid position 0-8.");
            break;

            validSubmission = false;
        }
    } while (!validSubmission);

    //ge.checkBoard()

    //ge.printBoard(board);

    Console.WriteLine($"{player2} (x), please select a position (0-8).");

    position = int.Parse(Console.ReadLine());

    // Check to make sure it is a valid submission

    do
    {
        if (position > 8 || position < 0)
        {
            Console.WriteLine("Please select a valid position 0-8.");
            break;

            validSubmission = false;
        }
    } while (!validSubmission);

    //ge.checkBoard()

} while (!gameOver);

// Print the board by calling the method in the supporting class

//Check for a winner by calling the method in the supporting class, and notify the players when a win has 
// occured and which player won the game