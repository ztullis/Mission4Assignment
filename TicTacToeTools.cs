using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mission4_Main_Program
{

    internal class TicTacToeTools
    {
        public void PrintBoard(string[] gameBoardInfo)
        {
            // variable that is assigning gameBoardInfo to an array called input. 
            string[] aInput = gameBoardInfo;
            // This is the board output with numbers assigned!
            Console.WriteLine($"[ {aInput[0]} ] | [ {aInput[1]} ] | [ {aInput[2]} ] ");
            Console.WriteLine($"[ {aInput[3]} ] | [ {aInput[4]} ] | [ {aInput[5]} ] ");
            Console.WriteLine($"[ {aInput[6]} ] | [ {aInput[7]} ] | [ {aInput[8]} ] ");
        }

        public string Winner(string[] gameBoardInfo)

        {
            // defining a variable.
            string winner = "";

            // going through each of the situations to make the game a win, a loss, or a draw.
                if (gameBoardInfo[0] == "X" && gameBoardInfo[1] == "X" && gameBoardInfo[2] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[3] == "X" && gameBoardInfo[4] == "X" && gameBoardInfo[5] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[6] == "X" && gameBoardInfo[7] == "X" && gameBoardInfo[8] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[0] == "X" && gameBoardInfo[3] == "X" && gameBoardInfo[6] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[1] == "X" && gameBoardInfo[4] == "X" && gameBoardInfo[7] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[2] == "X" && gameBoardInfo[5] == "X" && gameBoardInfo[8] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[0] == "X" && gameBoardInfo[4] == "X" && gameBoardInfo[8] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[2] == "X" && gameBoardInfo[4] == "X" && gameBoardInfo[6] == "X")
                {
                    winner = "X";
                }
                else if (gameBoardInfo[0] == "O" && gameBoardInfo[1] == "O" && gameBoardInfo[2] == "O")
                {
                    winner = "O";
                }
                else if (gameBoardInfo[3] == "O" && gameBoardInfo[4] == "O" && gameBoardInfo[5] == "O")
                {
                    winner = "O";
                }
                else if (gameBoardInfo[6] == "O" && gameBoardInfo[7] == "O" && gameBoardInfo[8] == "O")
                {
                    winner = "O";
                }
                else if (gameBoardInfo[0] == "O" && gameBoardInfo[3] == "O" && gameBoardInfo[6] == "O")
                {
                    winner = "O";
                }
                else if (gameBoardInfo[1] == "O" && gameBoardInfo[4] == "O" && gameBoardInfo[7] == "O")
                {
                    winner = "O";
                }
                else if (gameBoardInfo[2] == "O" && gameBoardInfo[5] == "O" && gameBoardInfo[8] == "O")
                {
                    winner = "O";
                }
                else if (gameBoardInfo[0] == "O" && gameBoardInfo[4] == "O" && gameBoardInfo[8] == "O")
                {
                    winner = "O";
                }
                else if (gameBoardInfo[2] == "O" && gameBoardInfo[4] == "O" && gameBoardInfo[6] == "O")
                {
                    winner = "O";
                }
                else if (
                    //checks to see if all the spaces on the board are either x or o. IF so, a tie is declared
                    ((gameBoardInfo[0] == "X") || (gameBoardInfo[0] == "O")) &&
                    ((gameBoardInfo[1] == "X") || (gameBoardInfo[1] == "O")) &&
                    ((gameBoardInfo[2] == "X") || (gameBoardInfo[2] == "O")) &&
                    ((gameBoardInfo[3] == "X") || (gameBoardInfo[3] == "O")) &&
                    ((gameBoardInfo[4] == "X") || (gameBoardInfo[4] == "O")) &&
                    ((gameBoardInfo[5] == "X") || (gameBoardInfo[5] == "O")) &&
                    ((gameBoardInfo[6] == "X") || (gameBoardInfo[6] == "O")) &&
                    ((gameBoardInfo[7] == "X") || (gameBoardInfo[7] == "O")) &&
                    ((gameBoardInfo[8] == "X") || (gameBoardInfo[8] == "O"))
                )
                {
                    // assigning winner
                    winner = "T";
                }

                else
                {
                    winner = "-";
                }

                // you must return the variable
                return winner;
            }
    }
}



