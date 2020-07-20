using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Fleet
    {
        List<Ship> fleet;

        public Fleet()
        {
            fleet = new List<Ship>();
            fleet.Add(new Ship("Carrier", 5));
            fleet.Add(new Ship("Battleship", 4));
            fleet.Add(new Ship("Cruiser", 3));
            fleet.Add(new Ship("Submarine", 3));
            fleet.Add(new Ship("Patrol Boat", 2));
        }
    }
}
