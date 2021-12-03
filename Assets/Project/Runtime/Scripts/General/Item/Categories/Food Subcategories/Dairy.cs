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
                switch (subType)
                {
                    case SubType.Butter:
                        Name = "Butter";
                        Description = "A buttery substance";
                        break;
                    case SubType.Cheese:
                        Name = "Cheese";
                        Description = "A cheesey substance";
                        break;
                    case SubType.Cream: 
                        Name = "Cream";
                        Description = "A creamy substance";
                        break;
                    case SubType.IceCream:
                        Name = "Ice Cream";
                        Description = "A creamy substance";
                        break;
                        case SubType.Milk:
                        Name = "Milk";
                        Description = "A milky substance";
                        break;
                    case SubType.Yogurt:
                        Name = "Yogurt";
                        Description = "A milky substance";
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

    }
}