using Obligatorisk_Game_Framework.Items;

namespace Game.Items.Item_Models.Humanoid_Items
{
    class Cloth : IItem
    {
        public Cloth(string name = "cloth")
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
