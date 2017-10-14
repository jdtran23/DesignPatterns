using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace MazeGame
{
    /// <summary>
    /// Creates a maze game.
    /// </summary>
    public static class MazeGameBuilder
    {
        // Add a player and implement enter()
        public static Maze CreateMaze()
        {
            Maze maze = new Maze();

            Room r1 = new Room(0);
            Room r2 = new Room(1);

            Door door = new Door(r1, r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.West, door);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            return maze;
        }

        // By pass in the factory, we can create derived classes that override
        // and change the functionality of the factory.
        public static Maze CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();

            Room r1 = factory.MakeRoom(0);
            Room r2 = factory.MakeRoom(1);

            Door door = factory.MakeDoor(r1, r2);

            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.East, door);
            r1.SetSide(Direction.West, factory.MakeWall());

            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            r2.SetSide(Direction.West, door);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            return maze;
        }
    }
}
