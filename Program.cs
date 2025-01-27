using Tic_Tac_Toe;

// Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");

// Ask for the players' names
Console.WriteLine("Player 1, please enter your name: ");
string player1 = Console.ReadLine();

Console.WriteLine("Player 2, please enter your name: ");
string player2 = Console.ReadLine();


// Create a game board array to store the player's choices

char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

// Ask each player in turn for their choice and update the game board array

// Print the board by calling the method in the supporting class

//Check for a winner by calling the method in the supporting class, and notify the players when a win has 
// occured and which player won the game