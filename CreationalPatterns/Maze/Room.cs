using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    /// <summary>
    /// Represents a room in a maze.
    /// </summary>
    public class Room : MapSite
    {
        int _roomNumber;
        // Could be a hashmap.
        List<MapSite> _sites;

        public Room(int roomNumber)
        {
            _roomNumber = roomNumber;
            _sites = new List<MapSite>(4);
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }

        public MapSite GetSide(Direction direction)
        {
            return _sites[(int)direction];
        }

        public void SetSide(Direction direction, MapSite site)
        {
            _sites.Insert((int)direction, site);
        }

        public int GetRoomNumber()
        {
            return _roomNumber;
        }
    }
}
