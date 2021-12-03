using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.FoodSubcategories{
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
                _Material = Helpers.Material.MaterialEnum.Organic;
                IsIdentified = true;
                switch (subType)
                {
                    case SubType.Butter:
                        Name = "Butter";
                        Description = "A buttery substance";
                        Satiety = 5;
                        break;
                    case SubType.Cheese:
                        Name = "Cheese";
                        Description = "A cheesey substance";
                        Satiety = 5;
                        break;
                    case SubType.Cream: 
                        Name = "Cream";
                        Description = "A creamy substance";
                        Satiety = 5;
                        break;
                    case SubType.IceCream:
                        Name = "Ice Cream";
                        Description = "A creamy substance";
                        Satiety = 5;
                        break;
                    case SubType.Milk:
                        Name = "Milk";
                        Description = "A milky substance";
                        Satiety = 5;
                        break;
                    case SubType.Yogurt:
                        Name = "Yogurt";
                        Description = "A milky substance";
                        Satiety = 5;
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

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