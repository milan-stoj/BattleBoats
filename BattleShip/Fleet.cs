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
            fleet.Add(new Ship("Destroyer", 4));
            fleet.Add(new Ship(""))
        }
    }
}
