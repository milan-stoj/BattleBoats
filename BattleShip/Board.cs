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
        public Player player;
        public char[,] playerBoard;

        public Board()
        {
            playerBoard = new char[10, 10];
        }
    }
}
