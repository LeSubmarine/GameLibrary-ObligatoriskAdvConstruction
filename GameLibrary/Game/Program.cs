using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Game.Creatures;
using Game.Creatures.Boar;
using Microsoft.Win32.SafeHandles;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.BaseItems.Weapons;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Tracing;
using Obligatorisk_Game_Framework.UtilityTools;
using Obligatorisk_Game_Framework.World;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceSourceSingleton.Ts().Listeners.Add(new ConsoleTraceListener());
            TraceSourceSingleton.Ts().Listeners.Add(new TextWriterTraceListener(new StreamWriter("Tracing.txt")));
            TraceSourceSingleton.Ts().Listeners.Add(new DefaultTraceListener());
            TraceSourceSingleton.Ts().Listeners.Add(new XmlWriterTraceListener("XMLTracing.xml"));
            World newWorld = new World(new WorldObjectManager());
            Creature human = (new HumanoidConcreteFactory(1,"Man")).MakeCreature();
            newWorld.AddWorldObjectToWorld(human);
            WorldObject obj = newWorld.WorldObjectsManager.GetWorldObjects().WorldObjects.First();
            if (TypeComparer.IsSameOrVariant(typeof(Creature), obj.GetType()).SuccessValue)
            {
                ((Creature) obj).ItemManager.AddItem(new Sword(new[] {new PhysicalDamageType()}, 5));
                ((Creature) obj).ItemManager.EquipGear((IAttackItem)((Creature) obj).ItemManager.GetItems().Value.First());
                while (true)
                {
                    IResponse response = ((Creature)obj).ReceiveHit(((Creature)obj).Hit());
                    if (response.SuccessValue == false && TypeComparer
                        .IsSameOrVariant(typeof(WorldObjectResponse), response.GetType()).SuccessValue)
                    {
                        Console.WriteLine("woops");
                        break;
                    }
                    if (response.SuccessValue)
                    {
                        Console.WriteLine("BONK");
                    }
                    Console.ReadLine();
                }
                Thread.Sleep(3000);
                Console.ReadLine();
            }
        }
    }
}
