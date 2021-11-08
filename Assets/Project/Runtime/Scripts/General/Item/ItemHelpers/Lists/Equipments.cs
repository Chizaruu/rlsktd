using System.Collections.Generic;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> Equipment Types. </summary>
    sealed class Equipments
    {   
        /// <summary> A list of one-handed weapons. </summary>
        private List<string> oneHandedWeapon = new List<string>()
        {
            "Shortsword", "Longsword", "Dagger", "Scimitar", "Cutlass",
            "Rapier", "Kris", "Saber", "Club", "Mace", "Shortspear",
            "Sickle" , "Morningstar" , "Whip", "Flail", "Handaxe"
        };

        /// <summary> A list of two-handed weapons. </summary>
        private List<string> twoHandedWeapon = new List<string>()
        {
            "Halberd", "Greatsword", "Claymore", "Greatclub", "Quarterstaff",
            "Longspear", "Battleaxe", "Lance", "Trident" , "Warhammer",
            "Maul" , "Spear"
        };

        /// <summary> A list of shields. </summary>
        private List<string> shield = new List<string>()
        {
            "Buckler" , "Shield" , "Towershield"
        };
        
        /// <summary> A list of ranged weapons. </summary>
        private List<string> rangedWeapon = new List<string>()
        {
            "Crossbow", "Bow" , "Pistol" , "Rifle", "Shotgun",
            "Lasergun", "Dart" , "Sling" , "Blowgun"
        };

        /// <summary> A list of ammunition. </summary>
        private List<string> ammo = new List<string>()
        {
            "Arrow", "Bullet" , "Bolt" , "Energycell", "Stone",
            "Needle"
        };
        /// <summary> A list of head gear. </summary>
        private List<string> head = new List<string>()
        {
            "Cap", "Helmet", "Circlet", "Hat", "Hood", "Mask"
        };
        /// <summary> A list of neck gear. </summary>
        private List<string> neck = new List<string>()
        {
            "Necklace", "Amulet", "Choker", "Pendant", "Locket"
        };
        /// <summary> A list of back gear. </summary>
        private List<string> back = new List<string>()
        {
            "Cloak", "Cape", "Mantle"
        };
        /// <summary> A list of body gear. </summary>
        private List<string> body = new List<string>()
        {
            "Breastplate", "Chainshirt", "Platemail", "Scalemail", 
            "Chainmail", "Robe", "Kimono"
        };
        /// <summary> A list of finger gear. </summary>
        private List<string> ring = new List<string>()
        {
            "Ring", "Band"
        };
        /// <summary> A list of hand gear. </summary>
        private List<string> gloves = new List<string>()
        {
            "Gloves", "Mittens", "Gauntlets", "Vambraces"
        };
        /// <summary> A list of waist gear. </summary>
        private List<string> waist = new List<string>()
        {
            "Girdle", "Belt", "Sash"
        };
        /// <summary> A list of leg gear. </summary>
        private List<string> boots = new List<string>()
        {
            "Boots", "Sandals", "Heels", "Greaves"
        };

        public List<string> OneHandedWeapon { get => oneHandedWeapon; } // A list of one-handed weapons.
        public List<string> TwoHandedWeapon { get => twoHandedWeapon; } // A list of two-handed weapons.
        public List<string> Shield { get => shield; } // A list of shields.
        public List<string> RangedWeapon { get => rangedWeapon; } // A list of ranged weapons.
        public List<string> Ammo { get => ammo; } // A list of ammunition.
        public List<string> Head { get => head; } // A list of head gear.
        public List<string> Neck { get => neck; } // A list of neck gear.
        public List<string> Back { get => back; } // A list of back gear.
        public List<string> Body { get => body; } // A list of body gear.
        public List<string> Ring { get => ring; } // A list of finger gear.
        public List<string> Gloves { get => gloves; } // A list of hand gear.
        public List<string> Waist { get => waist; } // A list of waist gear.
        public List<string> Boots { get => boots; } // A list of leg gear.
    }
}