using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4_Main_Program
{
    internal class TicTacToeTools
    {
        public void PrintBoard(string[] gameBoardInfo)
        {
            aInput = gameBoardInfo;
            // This is the board output with numbers assigned!
            Console.WriteLine($"[ {aInput[0]} ] | [ {aInput[1]} ] | [ {aInput[2]} ] ");
            Console.WriteLine($"[ {aInput[3]} ] | [ {aInput[4]} ] | [ {aInput[5]} ] ");
            Console.WriteLine($"[ {aInput[6]} ] | [ {aInput[7]} ] | [ {aInput[8]} ] ");
        }
        //Print the board in this method
        //Don't return anything
        //Input will look like this [ , ,X, , ,O, , ,O]

        public string[] Winner(string gameBoardInfo)
        //[true, X's]
        //Input will look like this [ , ,X, , ,O, , ,O] 
        //Return string "X" "O" "T" "-" 
    }
}
