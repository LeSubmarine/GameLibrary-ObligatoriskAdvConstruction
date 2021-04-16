using System;
using Game.Creatures;
using Game.Creatures.Boar;
using Obligatorisk_Game_Framework.Creature;
using Obligatorisk_Game_Framework.World;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Creature boar = new BoarCreature(10,"Boar",true,new Position( 1, 1, 1,1));
            Console.WriteLine("Hello World!");
        }
    }
}
