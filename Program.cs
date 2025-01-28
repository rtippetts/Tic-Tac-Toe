// Group 2-8; Spencer Layton, Rob Gardner, Spencer Davis, Rex Tippetts

using Tic_Tac_Toe;

// Creates an instance of game engine
Game_Engine ge = new Game_Engine();

// Declare global variables
bool validSubmission = true;
bool gameOver = false;
int position = 0;
bool playAgain = false;
string again = "";

do
{
    // Welcome the user to the game
    Console.WriteLine("Welcome to Tic Tac Toe!");

    // Ask for the players' names
    Console.WriteLine("Player 1, please enter your name: ");
    string player1 = Console.ReadLine();

    Console.WriteLine("Player 2, please enter your name: ");
    string player2 = Console.ReadLine();

    // Create a game board array to store the player's choices
    string[] board = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

    // Ask each player in turn for their choice and update the game board array
    do
    {
        // Start player X's turn
        do
        {
            // Print the current board before player X's move
            ge.printBoard(board);
            Console.WriteLine($"{player1} (X), please select a position (0-8).");

            // Error checking to ask for new input if it isn't a valid integer 0-8
            string input = Console.ReadLine();
            validSubmission = int.TryParse(input, out position); // Try to parse the input to an integer

            if (!validSubmission)
            {
                Console.WriteLine("Please enter a valid number between 0 and 8.");
            }
            else if (position < 0 || position > 8)
            {
                Console.WriteLine("Please select a valid position 0-8.");
                validSubmission = false;
            }
            else if (board[position] == "X" || board[position] == "O")
            {
                Console.WriteLine("That space is taken. Choose another.");
                validSubmission = false;
            }

        } while (!validSubmission);

        // Update the board with X's move
        board[position] = "X";

        // Check for a winner after X's move
        var result = ge.checkBoard(board, player1, player2);
        gameOver = result.Item1;
        string message = result.Item2;
        Console.WriteLine(message);

        if (gameOver) break; // If game over, exit the loop after X's turn

        // Start player O's turn
        do
        {
            // Print the current board before player X's move
            ge.printBoard(board);
            Console.WriteLine($"{player2} (O), please select a position (0-8).");

            // Error checking to ask for new input if it isn't a valid integer 0-8
            string input = Console.ReadLine();
            validSubmission = int.TryParse(input, out position); // Try to parse the input to an integer

            if (!validSubmission)
            {
                Console.WriteLine("Please enter a valid number between 0 and 8.");
            }
            else if (position < 0 || position > 8)
            {
                Console.WriteLine("Please select a valid position 0-8.");
                validSubmission = false;
            }
            else if (board[position] == "X" || board[position] == "O")
            {
                Console.WriteLine("That space is taken. Choose another.");
                validSubmission = false;
            }

        } while (!validSubmission);

        // Update the board with O's move
        board[position] = "O";

        // Check for a winner after O's move
        result = ge.checkBoard(board, player1, player2);
        gameOver = result.Item1;
        message = result.Item2;
        Console.WriteLine(message);

    } while (!gameOver); // Repeat until the game is over

    Console.WriteLine("Thanks for playing!");

    // Ask if the players want to play again
    do
    {
        Console.WriteLine("Do you want to play again? Y/N");
        again = Console.ReadLine().ToUpper();

        if (again == "Y")
        {
            playAgain = true;
        }
        else if (again == "N")
        {
            playAgain = false;
        }
        else
        {
            Console.WriteLine("Invalid Input. Please enter Y or N.");
        }
    } while (again != "Y" && again != "N");

} while (playAgain == true);