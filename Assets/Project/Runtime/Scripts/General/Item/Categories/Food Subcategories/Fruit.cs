using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.FoodSubcategories{
    [System.Serializable]
    public class Fruit : Food{
        public enum SubType
        {
            Apple, Apricot, Avocado, Banana, Blackberry, Cantaloupe, Cherry,
            Fig, Grape, Olive, Grapefruit, Kiwi, Lemon, Lime, Mango,
            Mangosteen, Orange, Papaya, Peach, Pear, Pineapple, Plum, Raisin,
            Strawberry, Tomato, Watermelon
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                switch (subType)
                {
                    case SubType.Apple:
                        Name = "Apple";
                        Description = "A red fruit";
                        break;
                    case SubType.Banana:
                        Name = "Banana";
                        Description = "A yellow fruit";
                        break;
                    case SubType.Blackberry:
                        Name = "Blackberry";
                        Description = "A red fruit";
                        break;
                    case SubType.Cantaloupe:
                        Name = "Cantaloupe";
                        Description = "A yellow fruit";
                        break;
                    case SubType.Cherry:
                        Name = "Cherry";
                        Description = "A red fruit";
                        break;
                    case SubType.Fig:
                        Name = "Fig";
                        Description = "A green fruit";
                        break;
                    case SubType.Grape:
                        Name = "Grape";
                        Description = "A green fruit";
                        break;
                    case SubType.Olive:
                        Name = "Olive";
                        Description = "A green fruit";
                        break;
                    case SubType.Grapefruit:
                        Name = "Grapefruit";
                        Description = "A orange fruit";
                        break;
                    case SubType.Kiwi:
                        Name = "Kiwi";
                        Description = "A brown fruit";
                        break;
                    case SubType.Lemon:
                        Name = "Lemon";
                        Description = "A yellow fruit";
                        break;
                    case SubType.Lime:
                        Name = "Lime";
                        Description = "A green fruit";
                        break;
                    case SubType.Mango:
                        Name = "Mango";
                        Description = "A yellow fruit";
                        break;
                    case SubType.Mangosteen:
                        Name = "Mangosteen";
                        Description = "A purple fruit";
                        break;
                    case SubType.Orange:
                        Name = "Orange";
                        Description = "A orange fruit";
                        break;
                    case SubType.Papaya:
                        Name = "Papaya";
                        Description = "A yellow fruit";
                        break;
                    case SubType.Peach:
                        Name = "Peach";
                        Description = "A orange fruit";
                        break;
                    case SubType.Pear:
                        Name = "Pear";
                        Description = "A green fruit";
                        break;
                    case SubType.Pineapple:
                        Name = "Pineapple";
                        Description = "A yellow fruit";
                        break;
                    case SubType.Plum:
                        Name = "Plum";
                        Description = "A purple fruit";
                        break;
                    case SubType.Raisin:
                        Name = "Raisin";
                        Description = "A purple fruit";
                        break;
                    case SubType.Strawberry:
                        Name = "Strawberry";
                        Description = "A red fruit";
                        break;
                    case SubType.Tomato:
                        Name = "Tomato";
                        Description = "A red fruit";
                        break;
                    case SubType.Watermelon:
                        Name = "Watermelon";
                        Description = "A green fruit";
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

    }
}