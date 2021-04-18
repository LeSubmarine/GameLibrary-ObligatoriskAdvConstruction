using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Tracing;
using Obligatorisk_Game_Framework.World;

namespace FrameworkDisplay
{
    public class GameEngineWorker
    {
        public GameEngineWorker()
        {
            WorldObject = new World(new WorldObjectManager(), "C:\\Users\\henri\\Desktop\\C#Adv\\Solutions\\GameLibrary-ObligatoriskAdvConstruction\\GameLibrary\\FrameworkDisplay\\config.xml");
            Random = new Random(DateTime.Now.Millisecond);
            //TraceSourceSingleton.Ts().Listeners.Add(new ConsoleTraceListener());

        }

        public World WorldObject { get; set; }
        public Random Random { get; set; }

        public Human Player { get; set; }


        public WorldObject[][] GetPlayerSurroundings(int range)
        {
            if (Player is null)
            {
                return null; 
            }

            int adjustedRange = (range * 2) + 1;

            WorldObject[][] Surroundings = new WorldObject[adjustedRange][];
            for (int i = 0; i < Surroundings.Length; i++)
            {
                Surroundings[i] = new WorldObject[adjustedRange];
            }

            foreach (var array in Surroundings)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = null;
                }
            }

            Surroundings[range][range] = Player;

            WorldObjectResponse playerNeighbors = Player.GetNeighbors(range, WorldObject);

            List<WorldObject> worldObjects = playerNeighbors.SuccessValue ? playerNeighbors.WorldObjects.ToList() : null;
            if (worldObjects is null)
            {
                return Surroundings;
            }

            foreach (var worldObject in worldObjects)
            {
                int differenceInX = (worldObject.Position.X - Player.Position.X) + range;
                int differenceInY = (worldObject.Position.Y - Player.Position.Y) + range;
                Surroundings[differenceInX][differenceInY] = worldObject;
            }



            return Surroundings;
        }

        public IResponse AddObject(WorldObject obj)
        {
            return WorldObject.AddWorldObjectToWorld(obj);
        }
    }
}
