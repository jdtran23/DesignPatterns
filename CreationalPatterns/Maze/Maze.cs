using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    /// <summary>
    /// Generates a 16 room maze;
    /// </summary>
    public class Maze
    {
        List<Room> _maze;
        // Default constructor
        public Maze()
        {
            _maze = new List<Room>(16);
        }

        public void AddRoom(Room room)
        {
            // Make sure room number isn't the same.
            _maze.Add(room);
        }

        public Room GetRoom(int roomNumber)
        {
            foreach (Room room in _maze)
            {
                if (room.GetRoomNumber() == roomNumber)
                {
                    return room;
                }
            }

            return null;
        }
    }
}
