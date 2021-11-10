using UnityEngine;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> The type of an item. </summary>
    [System.Serializable]
    public class Type 
    {
        /// <summary> Enumeration of all item types. </summary>
        public enum ItemType
        {
            /// <summary> The item is a weapon. </summary>
            Weapon,
            /// <summary> The item is a armor. </summary>
            Armor,
            /// <summary> The item is a jewelry. </summary>
            Jewelry,
            /// <summary> The item is a food. </summary>
            Food,
            /// <summary> The item is a potion. </summary>
            Potion,
            /// <summary> The item is a scroll. </summary>
            Scroll,
            /// <summary> The item is a rod. </summary>
            Rod,
        }

        /// <summary> The type of the item. </summary>
        public ItemType itemType;

        /// <summary> Constructor for the item type. </summary>
        /// <param name="type"> The type of the item. </param>
        public Type(ItemType itemType)
        {
            this.itemType = itemType;
        }

        /// <summary> Returns the item type as a string. </summary>
        /// <returns> The item type as a string. </returns>
        public override string ToString()
        {
            switch (itemType)
            {
                case ItemType.Weapon:
                    return "Weapon";
                case ItemType.Armor:
                    return "Armor";
                case ItemType.Jewelry:
                    return "Jewelry";
                case ItemType.Food:
                    return "Food";
                case ItemType.Potion:
                    return "Potion";
                case ItemType.Scroll:
                    return "Scroll";
                case ItemType.Rod:
                    return "Rod";
                default:
                    return "";
            }
        }

        /// <summary> Returns the item type as an int. </summary>
        /// <returns> The item type as an int. </returns>
        public int ToInt()
        {
            switch (itemType)
            {
                case ItemType.Weapon:
                    return 0;
                case ItemType.Armor:
                    return 1;
                case ItemType.Jewelry:
                    return 2;
                case ItemType.Food:
                    return 3;
                case ItemType.Potion:
                    return 4;
                case ItemType.Scroll:
                    return 5;
                case ItemType.Rod:
                    return 6;
                default:
                    return -1;
            }
        }

    }
}