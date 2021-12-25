using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Dairy : Food{
        public enum SubType
        {
            Butter, Cheese, Cream, IceCream, Milk, Yogurt
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
                    case SubType.Butter:
                        _Name = "Butter";
                        _Description = "A buttery substance";
                        Satiety = 5;
                        break;
                    case SubType.Cheese:
                        _Name = "Cheese";
                        _Description = "A cheesey substance";
                        Satiety = 5;
                        break;
                    case SubType.Cream: 
                        _Name = "Cream";
                        _Description = "A creamy substance";
                        Satiety = 5;
                        break;
                    case SubType.IceCream:
                        _Name = "Ice Cream";
                        _Description = "A creamy substance";
                        Satiety = 5;
                        break;
                    case SubType.Milk:
                        _Name = "Milk";
                        _Description = "A milky substance";
                        Satiety = 5;
                        break;
                    case SubType.Yogurt:
                        _Name = "Yogurt";
                        _Description = "A milky substance";
                        Satiety = 5;
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public Dairy(){}

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.Butter: return 0.2f;
                case SubType.Cheese: return 0.3f;
                case SubType.Cream: return 0.2f;
                case SubType.IceCream: return 0.2f;
                case SubType.Milk: return 0.5f;
                case SubType.Yogurt: return 0.4f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}