using Mission4_Main_Program;
using System.ComponentModel.Design;

TicTacToeTools tttt = new TicTacToeTools();

string[] gameBoardInfo = new string[9];
bool player1Turn = true;
bool gameOver = false;
int PlayerNumber = 0;
string Character = "";
int positionPicked = 0;
List<int> numbersPicked = new List<int>();
bool isNotValid = true;
string gameUpdate = "";

Console.WriteLine("Welcome to Tic Tac Toe!");

Console.WriteLine("Directions: type a number (1 - 9) to represent the spot you want to place your X or O.");

//print board
tttt.PrintBoard(gameBoardInfo);

Console.WriteLine("Player 1 (X): Pick a number!");

do
{
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

    
    //This loop runs 
    while (isNotValid = true)
    {
        positionPicked = Convert.ToInt32(Console.ReadLine());

        gameBoardInfo[positionPicked - 1] = Character;

        if (positionPicked >= 1 && positionPicked <= 9)
        {
            Console.WriteLine("You must pick a number between 1 and 9. Try again.");
        }
        else if (numbersPicked.Contains(positionPicked))
        {
            Console.WriteLine("This position is already selected. Try again.");
        }
        else
        {
            numbersPicked.Add(positionPicked);
            gameBoardInfo[positionPicked - 1] = Character;
            isNotValid = false;
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


