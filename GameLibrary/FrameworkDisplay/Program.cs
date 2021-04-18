using System;
using Obligatorisk_Game_Framework.World;

namespace FrameworkDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GameEngineWorker engine = new GameEngineWorker();
            engine.Player = new Human("Henrik", new Position(1,1,1,1));
            Console.WriteLine(engine.WorldObject.MaxX);
            Console.WriteLine(engine.WorldObject.MaxY);
        }
    }
}
