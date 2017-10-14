using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    /// <summary>
    /// Represents a Wall in a maze.
    /// </summary>
    public class Wall : MapSite
    {
        public Wall()
        {
            // Empty. Just a wall.
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
