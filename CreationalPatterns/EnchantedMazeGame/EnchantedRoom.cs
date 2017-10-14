using MazeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnchantedMazeGame
{
    public class EnchantedRoom : Room
    {
        public EnchantedRoom (int roomNumber) : base(roomNumber)
        {
            Console.WriteLine("Enchanted!");
        }
    }
}
