using Mission4_Main_Program;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

TicTacToeTools tttt = new TicTacToeTools();

//Initializing all the variables
string [] gameBoardInfo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool player1Turn = true;
bool gameOver = false;
int PlayerNumber = 0;
string Character = "";
string positionPickedString = "";
List<int> numbersPicked = new List<int>();
bool isNotValid = true;
string gameUpdate = "";

gameBoardInfo = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];

//Welcome statement and directions
Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine("Directions: type a number (1 - 9) to represent the spot you want to place your X or O. \nTry to get 3 in a row before your opponent!");

//print board by calling the PrintBoard method
tttt.PrintBoard(gameBoardInfo);

//This do while loop runs for each player's turn
do
{
    //initializing variables
    isNotValid = true;

    Console.WriteLine("");

    //This if statement changes for each player, changing the player number to 1 or 2, and the character to X or O
    if (player1Turn == true)
    {
        PlayerNumber = 1;
        Character = "X";
    }
    else
    {
        PlayerNumber = 2;
        Character = "O";
    }

    //Ask the user where they want to place their character
    Console.WriteLine($"Player {PlayerNumber}, where would you like to place your {Character}?");

    //This runs for each thing the user inputs, making sure it is valid (not too long/too short, must be a number, between 0 and 9, isn't already taken, etc.)
    while (isNotValid)
    {
        positionPickedString = Console.ReadLine();

        if (positionPickedString.Length != 1)
        {
            Console.WriteLine("Your input can only be 1 character long. Try again.");
        }
        else
        {
            char positionPicked;

            if (char.TryParse(positionPickedString, out positionPicked))
            {
                if (char.IsDigit(positionPicked))
                {
                    int parsedPosition = int.Parse(positionPicked.ToString());

                    if (parsedPosition >= 1 && parsedPosition <= 9)
                    {
                        if (!numbersPicked.Contains(parsedPosition))
                        {
                            numbersPicked.Add(parsedPosition);
                            gameBoardInfo[parsedPosition - 1] = Character;
                            isNotValid = false;
                        }
                        else
                        {
                            Console.WriteLine("This position is already selected. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You must pick a number between 1 and 9. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number from 1 to 9.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid character.");
            }
        }
    }

    //Print the board after each player's turn
    tttt.PrintBoard(gameBoardInfo);

    //Check to see if there is a winner
    gameUpdate = tttt.Winner(gameBoardInfo);

    //If there is a winner, print out who won and stop the program from taking turns.
    if (gameUpdate == "X")
    {
        Console.WriteLine("Congratulations Player 1 (X), you won!");
        gameOver = true;
    }
    else if (gameUpdate == "O")
    {
        Console.WriteLine("Congratulations Player 2 (O), you won!");
        gameOver = true;
    }
    else if (gameUpdate == "T") //If there is a tie, end the game but print no winner
    {
        Console.WriteLine("The game was tie!");
        gameOver = true;
    }
    else //Swap player's turn if nobody has won and it isn't a tie yet.
    {
        player1Turn = !player1Turn;
    }
    
} while (!gameOver);