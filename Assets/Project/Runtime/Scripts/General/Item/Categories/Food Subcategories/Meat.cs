using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
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
                _Material = ItemHelpers.Material.MaterialEnum.Organic;
                _IsIdentified = true;
                switch (subType)
                {
                    case SubType.Beef:
                        _Name = "Beef";
                        _Description = "A Whole Beef";
                        Satiety = 100;
                        break;
                    case SubType.Chicken:
                        _Name = "Chicken";
                        _Description = "A Whole Chicken";
                        Satiety = 20;
                        break;
                    case SubType.Duck:
                        _Name = "Duck";
                        _Description = "A Whole Duck";
                        Satiety = 25;
                        break;
                    case SubType.Goat:
                        _Name = "Goat";
                        _Description = "A Whole Goat";
                        Satiety = 60;
                        break;
                    case SubType.Lamb:
                        _Name = "Lamb";
                        _Description = "A Whole Lamb";
                        Satiety = 80;
                        break;
                    case SubType.Mutton:
                        _Name = "Mutton";
                        _Description = "A Whole Mutton";
                        Satiety = 80;
                        break;
                    case SubType.Ox:    
                        _Name = "Ox";
                        _Description = "A Whole Ox";
                        Satiety = 100;
                        break;
                    case SubType.Rabbit:
                        _Name = "Rabbit";
                        _Description = "A Whole Rabbit";
                        Satiety = 15;
                        break; 
                    case SubType.Turkey:
                        _Name = "Turkey";
                        _Description = "A Whole Turkey";
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