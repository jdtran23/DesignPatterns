using MazeGame;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Maze maze = MazeGameBuilder.CreateMaze();
            Maze maze2 = MazeGameBuilder.CreateMaze(new MazeFactory());
        }
    }
}
