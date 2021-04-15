using System;
using Game.Creatures;
using Game.Creatures.Boar;
using Game.Injected_Classes;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.World;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Creature boar = new BoarCreature(10,"Boar",true,new Position{Height = 1, Width = 1, X = 1, Y = 1});
            Console.WriteLine("Hello World!");
        }
    }
}
