using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.FoodSubcategories{
    [System.Serializable]
    public class Meat : Food{

        public enum SubType{
            Beef, Chicken, Duck, Goat, Lamb, Mutton, Ox,
            Rabbit, Turkey, 
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                _Material = Helpers.Material.MaterialEnum.Organic;
                IsIdentified = true;
                switch (subType)
                {
                    case SubType.Beef:
                        Name = "Beef";
                        Description = "A Whole Beef";
                        Satiety = 100;
                        break;
                    case SubType.Chicken:
                        Name = "Chicken";
                        Description = "A Whole Chicken";
                        Satiety = 20;
                        break;
                    case SubType.Duck:
                        Name = "Duck";
                        Description = "A Whole Duck";
                        Satiety = 25;
                        break;
                    case SubType.Goat:
                        Name = "Goat";
                        Description = "A Whole Goat";
                        Satiety = 60;
                        break;
                    case SubType.Lamb:
                        Name = "Lamb";
                        Description = "A Whole Lamb";
                        Satiety = 80;
                        break;
                    case SubType.Mutton:
                        Name = "Mutton";
                        Description = "A Whole Mutton";
                        Satiety = 80;
                        break;
                    case SubType.Ox:    
                        Name = "Ox";
                        Description = "A Whole Ox";
                        Satiety = 100;
                        break;
                    case SubType.Rabbit:
                        Name = "Rabbit";
                        Description = "A Whole Rabbit";
                        Satiety = 15;
                        break; 
                    case SubType.Turkey:
                        Name = "Turkey";
                        Description = "A Whole Turkey";
                        Satiety = 30;
                        break;  
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.Beef: return 200f;
                case SubType.Chicken: return 3f;
                case SubType.Duck: return 7f;
                case SubType.Goat: return 70f;
                case SubType.Lamb: return 80f;
                case SubType.Mutton: return 80f;
                case SubType.Ox: return 200f;
                case SubType.Rabbit: return 3f;
                case SubType.Turkey: return 5f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}