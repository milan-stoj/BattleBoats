using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Board
    {
        public char[,] playerBoard;

        public Board()
        {
            playerBoard = new char[10, 10];
        }
        public void PrintXAxis(Player player)
        {
            Console.Write("     1  2  3  4  5  6  7  8  9  10\n");
            Console.Write("   ╔═╧══╧══╧══╧══╧══╧══╧══╧══╧══╧═╗");
        }

        public void PrintBoard(char[,] board, Player player)
        {
            PrintXAxis();
            char A = 'A';
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\n {Convert.ToChar((A + i))} ╢");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"({board[i, j]})");
                }
                Console.Write("║");
            }
            PrintBottomFrame();
        }

        public void PrintBottomFrame()
        {
            Console.Write("\n   ╚══════════════════════════════╝");
        }

        public void AddShipToBoard()
        {

        }
    }
}
