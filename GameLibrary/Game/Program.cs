using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Game.Creatures;
using Game.Creatures.Boar;
using Microsoft.Win32.SafeHandles;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.BaseItems.Armor;
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
                ((Creature) obj).ItemManager.AddItems(new ItemsResponse("Adding item", "GOD",new []{ new Sword(new[] { new PhysicalDamageType() }, 5) }));
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
                ItemsResponse itemsLoot = ((Creature) obj).Loot();
                string collectedLoot = "";
                itemsLoot.Value.ToList().ForEach(a => collectedLoot += a.Name + " ");
                Console.WriteLine("WAUW you've looted : " + collectedLoot);
                Console.ReadLine();
                Console.WriteLine("now new dude with armor, and bigg sword vs small dude");

                Creature bigGuyCreature = (new HumanoidConcreteFactory(5,"BIGG GUY")).MakeCreature();
                Creature smoll = (new HumanoidConcreteFactory(1)).MakeCreature();

                bigGuyCreature.ItemManager.Inventory.AddItems(new ItemsResponse("Adding startup items", "GOD",
                    new IItem[]
                    {
                        new BreastArmor(10, new[] {new PhysicalDamageType(),}),
                        new HeadArmor(5, new[] {new PhysicalDamageType(),}),
                        new Sword(new IDamageType[] {new PhysicalDamageType(),new FireDamageType(2) },10)
                    }));
                bigGuyCreature.ItemManager.Inventory.GetItems().Value.Where(a => TypeComparer.IsSameOrVariant(typeof(IWearable),a.GetType()).SuccessValue).ToList().ForEach(a =>
                    {
                        bigGuyCreature.ItemManager.GearLoadOut.EquipItem((IWearable)a);
                    });

                smoll.ItemManager.AddItems(new ItemsResponse("Adding startup items", "GOD",
                    new IItem[]
                    {
                        new BreastArmor(13, new IDamageType[] {new PhysicalDamageType(), new FireDamageType(),}),
                        new HeadArmor(15, new IDamageType[] {new PhysicalDamageType(), new FireDamageType()}),
                        new Sword(new IDamageType[] {new PhysicalDamageType()}, 5),
                    }));


                smoll.ItemManager.Inventory.GetItems().Value.Where(a => TypeComparer.IsSameOrVariant(typeof(IWearable), a.GetType()).SuccessValue).ToList().ForEach(a =>
                {
                    smoll.ItemManager.GearLoadOut.EquipItem((IWearable)a);
                });

                Console.WriteLine("AIT FIGHT BOIS");
                bool oneAlive = true;
                while (oneAlive)
                {
                    oneAlive = smoll.ReceiveHit(bigGuyCreature.Hit()).SuccessValue && oneAlive;
                    if (oneAlive)
                    {
                        oneAlive = bigGuyCreature.ReceiveHit(smoll.Hit()).SuccessValue && oneAlive; 
                    }
                }

                if (smoll.Hitpoints > 0)
                {
                    smoll.ItemManager.AddItems(bigGuyCreature.Loot());
                }
                else
                {
                    bigGuyCreature.ItemManager.AddItems(smoll.Loot());
                }
            }
        }
    }
}
