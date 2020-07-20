using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Ship
    {
        int size;
        char firstLetter;
        string name;

        public Ship(string name, int size)
        {
            this.name = name;
            this.size = size;
            firstLetter = name.First();
        }
    }
}
