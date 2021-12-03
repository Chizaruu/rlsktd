using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Fruit : Food{
        public enum SubType
        {
            Apple, Apricot, Avocado, Banana, Blackberry, Cantaloupe, Cherry,
            Fig, Grape, Olive, Grapefruit, Kiwi, Lemon, Lime, Mango,
            Mangosteen, Orange, Papaya, Peach, Pear, Pineapple, Plum,
            Strawberry, Tomato, Watermelon
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                _Material = ItemHelpers.Material.MaterialEnum.Organic;
                IsIdentified = true;
                switch (subType)
                {
                    case SubType.Apple:
                        Name = "Apple";
                        Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Banana:
                        Name = "Banana";
                        Description = "A yellow fruit";
                        Satiety = 10;
                        break;
                    case SubType.Blackberry:
                        Name = "Blackberry";
                        Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Cantaloupe:
                        Name = "Cantaloupe";
                        Description = "A yellow fruit";
                        Satiety = 15;
                        break;
                    case SubType.Cherry:
                        Name = "Cherry";
                        Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Fig:
                        Name = "Fig";
                        Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Grape:
                        Name = "Grape";
                        Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Olive:
                        Name = "Olive";
                        Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Grapefruit:
                        Name = "Grapefruit";
                        Description = "A orange fruit";
                        Satiety = 10;
                        break;
                    case SubType.Kiwi:
                        Name = "Kiwi";
                        Description = "A brown fruit";
                        Satiety = 10;
                        break;
                    case SubType.Lemon:
                        Name = "Lemon";
                        Description = "A yellow fruit";
                        Satiety = 10;
                        break;
                    case SubType.Lime:
                        Name = "Lime";
                        Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Mango:
                        Name = "Mango";
                        Description = "A yellow fruit";
                        Satiety = 10;
                        break;
                    case SubType.Mangosteen:
                        Name = "Mangosteen";
                        Description = "A purple fruit";
                        Satiety = 10;
                        break;
                    case SubType.Orange:
                        Name = "Orange";
                        Description = "A orange fruit";
                        Satiety = 10;
                        break;
                    case SubType.Papaya:
                        Name = "Papaya";
                        Description = "A yellow fruit";
                        Satiety = 15;
                        break;
                    case SubType.Peach:
                        Name = "Peach";
                        Description = "A orange fruit";
                        Satiety = 10;
                        break;
                    case SubType.Pear:
                        Name = "Pear";
                        Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Pineapple:
                        Name = "Pineapple";
                        Description = "A yellow fruit";
                        Satiety = 15;
                        break;
                    case SubType.Plum:
                        Name = "Plum";
                        Description = "A purple fruit";
                        Satiety = 10;
                        break;
                    case SubType.Strawberry:
                        Name = "Strawberry";
                        Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Tomato:
                        Name = "Tomato";
                        Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Watermelon:
                        Name = "Watermelon";
                        Description = "A green fruit";
                        Satiety = 15;
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.Apple: return 0.2f;
                case SubType.Banana: return 0.2f;
                case SubType.Blackberry: return 0.01f;
                case SubType.Cantaloupe: return 1f;
                case SubType.Cherry: return 0.01f;
                case SubType.Fig: return 0.1f;
                case SubType.Grape: return 0.01f;
                case SubType.Olive: return 0.01f;
                case SubType.Grapefruit: return 0.5f;
                case SubType.Kiwi: return 0.1f;
                case SubType.Lemon: return 0.1f;
                case SubType.Lime: return 0.1f;
                case SubType.Mango: return 0.15f;
                case SubType.Mangosteen: return 0.1f;
                case SubType.Orange: return 0.2f;
                case SubType.Papaya: return 0.4f;
                case SubType.Peach: return 0.2f;
                case SubType.Pear: return 0.2f;
                case SubType.Pineapple: return 1f;
                case SubType.Plum: return 0.1f;
                case SubType.Strawberry: return 0.03f;
                case SubType.Tomato: return 0.1f;
                case SubType.Watermelon: return 1f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}