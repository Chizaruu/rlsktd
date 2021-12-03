using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.FoodSubcategories{
    [System.Serializable]
    public class Seed : Food{
        public enum SubType
        {
            Almond, Barley, Cashew, Chestnut, Chickpea, CocoaBean, Coconut, CoffeeBean,
            Corn, Lentil, LimaBean, Legume, Peanut, PintoBean, Pistachio, Rice,
            Walnut, Wheat
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                switch (subType)
                {
                    case SubType.Almond:
                        Name = "Almond";
                        Description = "A seed of the Almond tree.";
                        break;
                    case SubType.Barley:
                        Name = "Barley";
                        Description = "A seed of the Barley tree.";
                        break;
                    case SubType.Cashew:
                        Name = "Cashew";
                        Description = "A seed of the Cashew tree.";
                        break;
                    case SubType.Chestnut:
                        Name = "Chestnut";
                        Description = "A seed of the Chestnut tree.";
                        break;
                    case SubType.Chickpea:
                        Name = "Chickpea";
                        Description = "A seed of the Chickpea tree.";
                        break;
                    case SubType.CocoaBean:
                        Name = "Cocoa Bean";
                        Description = "A seed of the Cocoa Bean tree.";
                        break;
                    case SubType.Coconut:
                        Name = "Coconut";
                        Description = "A seed of the Coconut tree.";
                        break;
                    case SubType.CoffeeBean:    
                        Name = "Coffee Bean";
                        Description = "A seed of the Coffee Bean tree.";
                        break;
                    case SubType.Corn:
                        Name = "Corn";
                        Description = "A seed of the Corn tree.";
                        break;
                    case SubType.Lentil:
                        Name = "Lentil";
                        Description = "A seed of the Lentil tree.";
                        break;
                    case SubType.LimaBean:
                        Name = "Lima Bean";
                        Description = "A seed of the Lima Bean tree.";
                        break;
                    case SubType.Legume:
                        Name = "Legume";
                        Description = "A good source of vitamins C and E, zinc, and other antioxidants that strengthen your immune system.";
                        break;
                    case SubType.Peanut:
                        Name = "Peanut";
                        Description = "A seed of the Peanut tree.";
                        break;
                    case SubType.PintoBean:
                        Name = "Pinto Bean";
                        Description = "A seed of the Pinto Bean tree.";
                        break;
                    case SubType.Pistachio:
                        Name = "Pistachio";
                        Description = "A seed of the Pistachio tree.";
                        break;
                    case SubType.Rice:
                        Name = "Rice";
                        Description = "A seed of the Rice tree.";
                        break;
                    case SubType.Walnut:
                        Name = "Walnut";
                        Description = "A seed of the Walnut tree.";
                        break;
                    case SubType.Wheat:
                        Name = "Wheat";
                        Description = "A seed of the Wheat tree.";
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

    }
}