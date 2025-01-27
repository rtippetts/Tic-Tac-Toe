using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Game_Engine
    {

        public string printBoard(string[] ResponseArray)
        {
            string result = "";

            result = ($"{ResponseArray[0]} | {ResponseArray[1]} | {ResponseArray[2]}\n----------\n{ResponseArray[3]} | {ResponseArray[4]} | {ResponseArray[5]}\n----------\n{ResponseArray[6]} | {ResponseArray[7]} | {ResponseArray[8]}");
            return result;
        }

        public (bool, string) checkBoard(string[] ResponseArray, string Player_1, string Player_2, bool gameOver)
        {
            int[][] winningCombos = new int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8},
                new int[] {0,3,6},
                new int[] {1,4,7},
                new int[] {2,5,8},
                new int[] {0,4,8},
                new int[] {2,4,6}
            };

            //Check for winning combo

            foreach (int[] combo in winningCombos)
            {
                
                //check for a winner
                if (ResponseArray[combo[0]] == ResponseArray[combo[1]] &&
                    ResponseArray[combo[1]] == ResponseArray[combo[2]] &&
                    (ResponseArray[combo[0]] == "X" || ResponseArray[combo[0]] == "O"))
                {
                    
                    if (ResponseArray[combo[0]] == "X")
                    {
                        return (true, $"{Player_1} wins!");
                    }

                    if (ResponseArray[combo[0]] == "O")
                    {
                        return (true, $"{Player_2} wins!");
                    }

                }
            }

            //check for a cat

                if (ResponseArray[0] != "1" &&
                    ResponseArray[1] != "2" &&
                    ResponseArray[2] != "3" &&
                    ResponseArray[3] != "4" &&
                    ResponseArray[4] != "5" &&
                    ResponseArray[5] != "6" &&
                    ResponseArray[6] != "7" &&
                    ResponseArray[7] != "8" &&
                    ResponseArray[8] != "9")
                {
                    return (true, "It's a tie!");
                }

                //check for ongoing game

                return (false, "");
            
        }
    }
}

