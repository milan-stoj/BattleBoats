using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Player
    {
        public string name;
        public Board board;
        public Fleet fleet;
        
        public Player(string name)
        {
            this.name = name;
            fleet = new Fleet();
            board = new Board();
        }

        public void PrintXAxis()
        {
            Console.Write($"               {name}\n");
            Console.Write("     1  2  3  4  5  6  7  8  9  10\n");
            Console.Write("   ╔═╧══╧══╧══╧══╧══╧══╧══╧══╧══╧═╗");
        }

        public void PrintBoard()
        {
            PrintXAxis();
            char A = 'A';
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\n {Convert.ToChar((A + i))} ╢");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"({board.playerBoard[i, j]})");
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
