namespace Obligatorisk_Game_Framework.Creature.ItemManagement
{
    /// <summary>
    /// Defines what gear slots a creatures has.
    /// </summary>
    public class GearSlots
    {
        /// <summary>
        /// Defense item slots available.
        /// </summary>
        public string[] DefenseSlots { get; set; }

        /// <summary>
        /// Attack item slots available.
        /// </summary>
        public string[] AttackSlots { get; set; }

        /// <summary>
        /// Miscellaneous item slots available.
        /// </summary>
        public string[] MiscSlots { get; set; }
    }
}
