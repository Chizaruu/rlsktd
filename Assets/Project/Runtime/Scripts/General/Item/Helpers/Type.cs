using Sirenix.OdinInspector;
using UnityEngine;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> The type of an item. </summary>
    [System.Serializable]
    public class Type 
    {
        /// <summary> Enumeration of all item types. </summary>
        public enum TypeEnum
        {
            /// <summary> The item is a weapon type. </summary>
            Weapon,
            /// <summary> The item is a armor type. </summary>
            Armor,
            /// <summary> The item is a jewelry type. </summary>
            Jewelry,
            /// <summary> The item is a food type. </summary>
            Food,
            /// <summary> The item is a potion type. </summary>
            Potion,
            /// <summary> The item is a scroll type. </summary>
            Scroll,
            /// <summary> The item is a rod type. </summary>
            Rod,
            /// <summary> The item is a book type. </summary>
            Book,
            /// <summary> The item is a key type. </summary>
            Key,
            /// <summary> The item is a gem type. </summary>
            Gem,
            /// <summary> The item is a tool type. </summary>
            Tool,
            /// <summary> The item is a furniture type. </summary>
            Furniture,
            /// <summary> The item is misc type. </summary>
            Misc,
        }

        /// <summary> The type of the item. </summary>
        [SerializeField, HideInInspector]
        private TypeEnum itemType;

        [ShowInInspector]public TypeEnum ItemType { get => itemType; set => itemType = value; }

        /// <summary> Constructor for the item type. </summary>
        /// <param name="type"> The type of the item. </param>
        public Type(TypeEnum itemType)
        {
            this.itemType = itemType;
        }

        /// <summary> Returns the item type as a string. </summary>
        /// <returns> The item type as a string. </returns>
        public override string ToString()
        {
            switch (itemType)
            {
                case TypeEnum.Weapon:
                    return "Weapon";
                case TypeEnum.Armor:
                    return "Armor";
                case TypeEnum.Jewelry:
                    return "Jewelry";
                case TypeEnum.Food:
                    return "Food";
                case TypeEnum.Potion:
                    return "Potion";
                case TypeEnum.Scroll:
                    return "Scroll";
                case TypeEnum.Rod:
                    return "Rod";
                case TypeEnum.Book:
                    return "Book";
                case TypeEnum.Key:
                    return "Key";
                case TypeEnum.Gem:
                    return "Gem";
                case TypeEnum.Tool:
                    return "Tool";
                case TypeEnum.Furniture:
                    return "Furniture";
                case TypeEnum.Misc:
                    return "Misc";
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
                case TypeEnum.Weapon:
                    return 0;
                case TypeEnum.Armor:
                    return 1;
                case TypeEnum.Jewelry:
                    return 2;
                case TypeEnum.Food:
                    return 3;
                case TypeEnum.Potion:
                    return 4;
                case TypeEnum.Scroll:
                    return 5;
                case TypeEnum.Rod:
                    return 6;
                case TypeEnum.Book:
                    return 7;
                case TypeEnum.Key:
                    return 8;
                case TypeEnum.Gem:
                    return 9;
                case TypeEnum.Tool:
                    return 10;
                case TypeEnum.Furniture:
                    return 11;
                case TypeEnum.Misc:
                    return 12;
                default:
                    return -1;
            }
        }
    }
}