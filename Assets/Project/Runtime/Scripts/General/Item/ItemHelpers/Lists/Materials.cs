using System.Collections.Generic;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> Material Types </summary>
    sealed class Materials
    {
        /// <summary> Common Materials </summary>
        private List<string> common = new List<string>()
        {
            "Copper", "Tin", "Bronze", "Iron", "Gold",
            "Bone", "Cloth", "Silk", "Raw", "Paper",
            "Mica", "Leather", "Feather", "Wood"
        };

        /// <summary> Uncommon Materials </summary>
        private List<string> uncommon = new List<string>()
        {
            "Lunarite", "Silver", "Chain", "Zylon", "Steel",
            "Glass", "Obsidian", "Scale", "Magic Cloth"
        };

        /// <summary> Superior Materials </summary>
        private List<string> superior = new List<string>()
        {
            "Mithril", "Adamantium", "Crystal", "Diamond",
            "Dragonscale", "Platinum", "Spirit Cloth", "Titanium"
        };

        /// <summary> Special Materials </summary>
        private List<string> special = new List<string>()
        {
            "Coral", "Chrome", "Ether", "Emerald", "Ruby"
        };
        
        /// <summary> decorative Materials </summary>
        private List<string> decorative = new List<string>()
        {
            "Wooden", "Metal", "Crystal", "Stone"
        };

        public List<string> Common { get => common; } // Common Materials
        public List<string> Uncommon { get => uncommon; } // Uncommon Materials
        public List<string> Superior { get => superior; } // Superior Materials
        public List<string> Special { get => special; } // Special Materials
        public List<string> Decorative { get => decorative; } // Decorative Materials
    }
}