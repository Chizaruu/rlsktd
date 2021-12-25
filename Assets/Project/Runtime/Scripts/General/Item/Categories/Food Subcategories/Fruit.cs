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
                _IsIdentified = true;
                switch (subType)
                {
                    case SubType.Apple:
                        _Name = "Apple";
                        _Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Banana:
                        _Name = "Banana";
                        _Description = "A yellow fruit";
                        Satiety = 10;
                        break;
                    case SubType.Blackberry:
                        _Name = "Blackberry";
                        _Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Cantaloupe:
                        _Name = "Cantaloupe";
                        _Description = "A yellow fruit";
                        Satiety = 15;
                        break;
                    case SubType.Cherry:
                        _Name = "Cherry";
                        _Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Fig:
                        _Name = "Fig";
                        _Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Grape:
                        _Name = "Grape";
                        _Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Olive:
                        _Name = "Olive";
                        _Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Grapefruit:
                        _Name = "Grapefruit";
                        _Description = "A orange fruit";
                        Satiety = 10;
                        break;
                    case SubType.Kiwi:
                        _Name = "Kiwi";
                        _Description = "A brown fruit";
                        Satiety = 10;
                        break;
                    case SubType.Lemon:
                        _Name = "Lemon";
                        _Description = "A yellow fruit";
                        Satiety = 10;
                        break;
                    case SubType.Lime:
                        _Name = "Lime";
                        _Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Mango:
                        _Name = "Mango";
                        _Description = "A yellow fruit";
                        Satiety = 10;
                        break;
                    case SubType.Mangosteen:
                        _Name = "Mangosteen";
                        _Description = "A purple fruit";
                        Satiety = 10;
                        break;
                    case SubType.Orange:
                        _Name = "Orange";
                        _Description = "A orange fruit";
                        Satiety = 10;
                        break;
                    case SubType.Papaya:
                        _Name = "Papaya";
                        _Description = "A yellow fruit";
                        Satiety = 15;
                        break;
                    case SubType.Peach:
                        _Name = "Peach";
                        _Description = "A orange fruit";
                        Satiety = 10;
                        break;
                    case SubType.Pear:
                        _Name = "Pear";
                        _Description = "A green fruit";
                        Satiety = 10;
                        break;
                    case SubType.Pineapple:
                        _Name = "Pineapple";
                        _Description = "A yellow fruit";
                        Satiety = 15;
                        break;
                    case SubType.Plum:
                        _Name = "Plum";
                        _Description = "A purple fruit";
                        Satiety = 10;
                        break;
                    case SubType.Strawberry:
                        _Name = "Strawberry";
                        _Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Tomato:
                        _Name = "Tomato";
                        _Description = "A red fruit";
                        Satiety = 10;
                        break;
                    case SubType.Watermelon:
                        _Name = "Watermelon";
                        _Description = "A green fruit";
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