using System.Collections.Generic;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> Item Types </summary>
    sealed class Types
    {
        /// <summary> List of Equipment Types </summary>
        private List<string> equipment = new List<string>()
        {
            "One-Handed", "Two-Handed", "Shield", "Ranged",
            "Ammo", "Head", "Neck", "Back", "Body", "Ring", "Gloves", 
            "Waist", "Boots"
        };

        /// <summary> List of Usable Types </summary>
        private List<string> usable = new List<string>()
        {
            "Scroll", "Potion", "Book", "Rod"
        };

        /// <summary> List of Decorative Types </summary>
        private List<string> decorative = new List<string>()
        {
            "Sink", "Chair", "Table", "Cushion", "Lamp",
            "Bookshelf", "Bed", "Stove"
        };

        public List<string> Equipment { get => equipment; }  // Getter for Equipment Types
        public List<string> Usable { get => usable; } // Getter for Usable Types
        public List<string> Decorative { get => decorative; } // Getter for Decorative Types
    }
}