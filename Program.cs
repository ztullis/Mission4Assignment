using Mission4_Main_Program;
using System.ComponentModel.Design;

TicTacToeTools tttt = new TicTacToeTools();

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

Console.WriteLine("Welcome to Tic Tac Toe!");

Console.WriteLine("Directions: type a number (1 - 9) to represent the spot you want to place your X or O. \nTry to get 3 in a row before your opponent!");

//print board
tttt.PrintBoard(gameBoardInfo);

Console.WriteLine("Player 1 (X): Pick a number!");

do
{
    isNotValid = true;

    Console.WriteLine("");

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

    Console.WriteLine($"Player {PlayerNumber}, where would you like to place your {Character}?");

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

    tttt.PrintBoard(gameBoardInfo);

    gameUpdate = tttt.Winner(gameBoardInfo);

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
    else if (gameUpdate == "T")
    {
        Console.WriteLine("The game was tie!");
        gameOver = true;
    }
    else
    {
        player1Turn = !player1Turn;
    }
    
} while (!gameOver);


