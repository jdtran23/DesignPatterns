using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    /// <summary>
    /// Represents a door in a maze that connects two rooms.
    /// </summary>
    public class Door : MapSite
    {
        Room _room1;
        Room _room2;
        bool _isOpen;

        public Door(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
            _isOpen = false;
        }

        public Room OtherSideFrom(Room room)
        {
            // Probably would need a deep check.
            if (room == _room1)
            {
                return _room2;
            }
            else if (room == _room2)
            {
                return _room1;
            }
            else
            {
                throw new Exception("There is no room on the otherside.");
            }
        }

        public void OpenDoor()
        {
            _isOpen = true;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
