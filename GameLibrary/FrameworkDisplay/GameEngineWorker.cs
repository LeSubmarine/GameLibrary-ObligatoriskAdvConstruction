using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Obligatorisk_Game_Framework.Tracing;
using Obligatorisk_Game_Framework.World;

namespace FrameworkDisplay
{
    public class GameEngineWorker
    {
        public GameEngineWorker()
        {
            WorldOject = new World(new WorldObjectManager());
            Random = new Random(DateTime.Now.Millisecond);
            //TraceSourceSingleton.Ts().Listeners.Add(new ConsoleTraceListener());

        }

        public World WorldOject { get; set; }
        public Random Random { get; set; }

        public void AddPlayer()
        {

        }
    }
}
