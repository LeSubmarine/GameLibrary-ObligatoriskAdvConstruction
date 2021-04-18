using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Obligatorisk_Game_Framework.Combat.DamageTypes;
using Obligatorisk_Game_Framework.Combat.DamageTypes.BaseDamageTypes;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.Creature.BaseCreatures.Humanoid;
using Obligatorisk_Game_Framework.Creature.ItemManagement;
using Obligatorisk_Game_Framework.Items;
using Obligatorisk_Game_Framework.Items.BaseItems.HumanoidItems;
using Obligatorisk_Game_Framework.Items.BaseItems.Weapons;
using Obligatorisk_Game_Framework.Items.LootTables;
using Obligatorisk_Game_Framework.Responses;
using Obligatorisk_Game_Framework.Responses.CombatResponses;
using Obligatorisk_Game_Framework.UtilityTools;
using Obligatorisk_Game_Framework.World;
using Obligatorisk_Game_Framework.World.WorldObjects;

namespace FrameworkDisplay
{
    class Program
    {
        static int vision = 10;
        static void Main(string[] args)
        {
            GameEngineWorker engine = new GameEngineWorker();
            engine.AddObject(new Boulder("Rock",new Position(47,47,1,1)));
            engine.AddObject(new HumanoidConcreteFactory(1,"nobody",new Position(45,45,1,1)).MakeCreature());
            Creature derp = new HumanoidCreature(20, 3000, new ItemManager(new Inventory(), new HumanoidLoadOut(new HumanoidSlots(),new HumanoidSkin("skin",new IDamageType[]{new PhysicalDamageType(), }))),
                "DERP", false,
                new Position(45, 50, 1, 1),
                new BoarLootTableDecorator(new HumanoidLootTableDecorator(new LootTable())));
            engine.AddObject(derp);
            derp.ItemManager.GearLoadOut.AttackItems["fist"] = new Sword(new IDamageType[]{new RangeDamageType(), },20 );
            engine.AddObject(new Boulder("Rock",new Position(51,51,2,1)));
            engine.AddObject(new Boulder("Rock",new Position(55,55,2,2)));
            Human gert = new Human("Henrik", new Position(50, 50, 1, 1));
            engine.AddObject(gert);
            engine.Player = gert;
            engine.Player.ItemManager.AddItems(new ItemsResponse("", "",
                new[] {new Sword(new IDamageType[] {new FireDamageType()}, 200),}));
            engine.Player.ItemManager.EquipGear((IWearable)engine.Player.ItemManager.Inventory.GetItems().Value
                .First(a => TypeComparer.IsSameOrVariant(typeof(IAttackItem), a.GetType()).SuccessValue));
            var map = engine.GetPlayerSurroundings(vision);
            PrintMap(map);
            while (true)
            {
                var KeyPress = Console.ReadKey(true);
                if (KeyPressed(KeyPress, engine.Player, map))
                {
                    if (engine.Player.Hitpoints > 0)
                    {
                        Console.Clear();
                        map = engine.GetPlayerSurroundings(vision);
                        PrintMap(map);
                        Thread.Sleep(100); 
                    }
                }
            }
        }

        static bool KeyPressed(ConsoleKeyInfo keyPress,Creature player, WorldObject[][] map)
        {
            WorldObject objInfront;
            switch (keyPress.Key)
            {
                case ConsoleKey.LeftArrow:
                    objInfront = map[vision - 1][vision];
                    if (objInfront is null)
                    {
                        player.Move(-1, 0);
                    }
                    else
                    {
                        if (TypeComparer.IsSameOrVariant(typeof(CreatureCombatBehavior), objInfront.GetType()).SuccessValue)
                        {
                            Creature creature = (Creature) objInfront;
                            DamageResponse attack = player.Hit();
                            IResponse response = creature.ReceiveHit(attack);
                            if (!response.SuccessValue)
                            {
                                player.ItemManager.AddItems(creature.Loot());
                            }

                            else
                            {
                                response = player.ReceiveHit(creature.Hit());
                                if (!response.SuccessValue)
                                {
                                    Console.Clear();
                                    Console.WriteLine("YOU DIED");
                                }
                            }
                        }
                    }
                    break;
                case ConsoleKey.RightArrow:
                    objInfront = map[vision + 1][vision];
                    if (objInfront is null)
                    {
                        player.Move(1, 0);
                    }
                    else
                    {
                        if (TypeComparer.IsSameOrVariant(typeof(CreatureCombatBehavior), objInfront.GetType()).SuccessValue)
                        {
                            Creature creature = (Creature)objInfront;
                            DamageResponse attack = player.Hit();
                            IResponse response = creature.ReceiveHit(attack);
                            if (!response.SuccessValue)
                            {
                                player.ItemManager.AddItems(creature.Loot());
                            }

                            else
                            {
                                response = player.ReceiveHit(creature.Hit());
                                if (!response.SuccessValue)
                                {
                                    Console.Clear();
                                    Console.WriteLine("YOU DIED");
                                }
                            }
                        }
                    }
                    break;
                case ConsoleKey.UpArrow:
                    objInfront = map[vision][vision + 1];
                    if (objInfront is null)
                    {
                        player.Move(0, 0+1 );
                    }
                    else
                    {
                        if (TypeComparer.IsSameOrVariant(typeof(CreatureCombatBehavior), objInfront.GetType()).SuccessValue)
                        {
                            Creature creature = (Creature)objInfront;
                            DamageResponse attack = player.Hit();
                            IResponse response = creature.ReceiveHit(attack);
                            if (!response.SuccessValue)
                            {
                                player.ItemManager.AddItems(creature.Loot());
                            }

                            else
                            {
                                response = player.ReceiveHit(creature.Hit());
                                if (!response.SuccessValue)
                                {
                                    Console.Clear();
                                    Console.WriteLine("YOU DIED");
                                }
                            }
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    objInfront = map[vision][vision - 1];
                    if (objInfront is null)
                    {
                        player.Move(0, -1);
                    }
                    else
                    {
                        if (TypeComparer.IsSameOrVariant(typeof(CreatureCombatBehavior), objInfront.GetType()).SuccessValue)
                        {
                            Creature creature = (Creature)objInfront;
                            DamageResponse attack = player.Hit();
                            IResponse response = creature.ReceiveHit(attack);
                            if (!response.SuccessValue)
                            {
                                player.ItemManager.AddItems(creature.Loot());
                            }

                            else
                            {
                                response = player.ReceiveHit(creature.Hit());
                                if (!response.SuccessValue)
                                {
                                    Console.Clear();
                                    Console.WriteLine("YOU DIED");
                                }
                            }
                        }
                    }
                    break;
                default:
                    return false;
            }

            return true;
        }

        static void PrintMap(WorldObject[][] map)
        {
            List<string> stringLinesMap = new List<string>();
            for (int i = 0; i < map.First().Length; i++)
            {
                StringBuilder newLine = new StringBuilder();
                foreach (var width in map)
                {
                    WorldObject coordinate = width[i];
                    
                    if (coordinate is null)
                    {
                        newLine.Append(" ");
                    }
                    else if (TypeComparer.IsSameOrVariant(typeof(Human), coordinate.GetType(),true).SuccessValue)
                    {
                        newLine.Append("O");
                    }
                    else if (TypeComparer.IsSameOrVariant(typeof(Creature), coordinate.GetType(),true).SuccessValue)
                    {
                        newLine.Append("X");
                    }
                    else
                    {
                        newLine.Append("@");
                    }
                    
                }
                stringLinesMap.Add(newLine.ToString());
            }

            stringLinesMap.Reverse();
            foreach (var line in stringLinesMap)
            {
                Console.WriteLine(line);
            }
        }
    }
}
