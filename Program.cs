﻿using Tic_Tac_Toe;

Game_Engine ge = new Game_Engine();

bool validSubmission = true;
bool gameOver = false;
int position = 0;
var result = "";

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

   

    // Check to make sure it is a valid submission
    
    do
    {
        Console.WriteLine($"{player1} (x), please select a position (0-8).");
        
        position = int.Parse(Console.ReadLine());
        
        validSubmission = true;
        if (position > 8 || position < 0)
        {
            Console.WriteLine("Please select a valid position 0-8.");

            validSubmission = false;
        }

        if (board[position] == 'X' || board[position] == 'O')
        {
            Console.WriteLine("That space is taken. Choose another.");
            validSubmission = false;
        }
    } while (!validSubmission);

    board[position] = 'X';
    
    Console.WriteLine(board);
    
    
    

    //ge.printBoard(board);

    
    ge.checkBoard(board, player1, player2);
    gameOver = result.Item1;
    string message = result.Item2;
    Console.WriteLine(message);
    // Check to make sure it is a valid submission

    do
    {
        Console.WriteLine($"{player2} (o), please select a position (0-8).");

        position = int.Parse(Console.ReadLine());
        
        validSubmission = true;
        if (position > 8 || position < 0)
        {
            Console.WriteLine("Please select a valid position 0-8.");

            validSubmission = false;
        }
        if (board[position] == 'X' || board[position] == 'O')
        {
            Console.WriteLine("That space is taken. Choose another.");
            validSubmission = false;
        }
    } while (!validSubmission);
    
    board[position] = 'O';
    Console.WriteLine(board);

    ge.checkBoard(board, player1, player2);
    gameOver = result.Item1;
    string message = result.Item2;
    Console.WriteLine(message);

} while (!gameOver);

Console.WriteLine("Thanks for playing!");

Console.WriteLine("Do you want to play again? Y/N");



// Print the board by calling the method in the supporting class



//Check for a winner by calling the method in the supporting class, and notify the players when a win has 
// occured and which player won the game