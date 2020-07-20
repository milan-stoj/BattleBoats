using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Milan");
            player.PrintBoard();
            Console.ReadLine();
        }
    }
}
