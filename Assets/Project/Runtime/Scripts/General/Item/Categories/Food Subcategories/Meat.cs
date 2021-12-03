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
                switch (subType)
                {
                    case SubType.Beef:
                        Name = "Beef";
                        Description = "A Whole Beef";
                        break;
                    case SubType.Chicken:
                        Name = "Chicken";
                        Description = "A Whole Chicken";
                        break;
                    case SubType.Duck:
                        Name = "Duck";
                        Description = "A Whole Duck";
                        break;
                    case SubType.Goat:
                        Name = "Goat";
                        Description = "A Whole Goat";
                        break;
                    case SubType.Lamb:
                        Name = "Lamb";
                        Description = "A Whole Lamb";
                        break;
                    case SubType.Mutton:
                        Name = "Mutton";
                        Description = "A Whole Mutton";
                        break;
                    case SubType.Ox:    
                        Name = "Ox";
                        Description = "A Whole Ox";
                        break;
                    case SubType.Rabbit:
                        Name = "Rabbit";
                        Description = "A Whole Rabbit";
                        break; 
                    case SubType.Turkey:
                        Name = "Turkey";
                        Description = "A Whole Turkey";
                        break;  
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

    }
}