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
                _Material = Helpers.Material.MaterialEnum.Organic;
                IsIdentified = true;
                switch (subType)
                {
                    case SubType.Almond:
                        Name = "Almond";
                        Description = "A seed of the Almond tree.";
                        Satiety = 3;
                        break;
                    case SubType.Barley:
                        Name = "Barley";
                        Description = "A seed of the Barley tree.";
                        Satiety = 3;
                        break;
                    case SubType.Cashew:
                        Name = "Cashew";
                        Description = "A seed of the Cashew tree.";
                        Satiety = 3;
                        break;
                    case SubType.Chestnut:
                        Name = "Chestnut";
                        Description = "A seed of the Chestnut tree.";
                        Satiety = 3;
                        break;
                    case SubType.Chickpea:
                        Name = "Chickpea";
                        Description = "A seed of the Chickpea tree.";
                        Satiety = 3;
                        break;
                    case SubType.CocoaBean:
                        Name = "Cocoa Bean";
                        Description = "A seed of the Cocoa Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Coconut:
                        Name = "Coconut";
                        Description = "A seed of the Coconut tree.";
                        Satiety = 3;
                        break;
                    case SubType.CoffeeBean:    
                        Name = "Coffee Bean";
                        Description = "A seed of the Coffee Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Corn:
                        Name = "Corn";
                        Description = "A seed of the Corn tree.";
                        Satiety = 3;
                        break;
                    case SubType.Lentil:
                        Name = "Lentil";
                        Description = "A seed of the Lentil tree.";
                        Satiety = 3;
                        break;
                    case SubType.LimaBean:
                        Name = "Lima Bean";
                        Description = "A seed of the Lima Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Legume:
                        Name = "Legume";
                        Description = "A good source of vitamins C and E, zinc, and other antioxidants that strengthen your immune system.";
                        Satiety = 3;
                        break;
                    case SubType.Peanut:
                        Name = "Peanut";
                        Description = "A seed of the Peanut tree.";
                        Satiety = 3;
                        break;
                    case SubType.PintoBean:
                        Name = "Pinto Bean";
                        Description = "A seed of the Pinto Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Pistachio:
                        Name = "Pistachio";
                        Description = "A seed of the Pistachio tree.";
                        Satiety = 3;
                        break;
                    case SubType.Rice:
                        Name = "Rice";
                        Description = "A seed of the Rice tree.";
                        Satiety = 3;
                        break;
                    case SubType.Walnut:
                        Name = "Walnut";
                        Description = "A seed of the Walnut tree.";
                        Satiety = 3;
                        break;
                    case SubType.Wheat:
                        Name = "Wheat";
                        Description = "A seed of the Wheat tree.";
                        Satiety = 3;
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.Almond: return 0.02f;
                case SubType.Barley: return 0.01f;
                case SubType.Cashew: return 0.02f;
                case SubType.Chestnut: return 0.5f;
                case SubType.Chickpea: return 0.02f;
                case SubType.CocoaBean: return 0.03f;
                case SubType.Coconut: return 0.5f;
                case SubType.CoffeeBean: return 0.03f;
                case SubType.Corn: return 0.2f;
                case SubType.Lentil: return 0.01f;
                case SubType.LimaBean: return 0.03f;
                case SubType.Legume: return 0.03f;
                case SubType.Peanut: return 0.05f;
                case SubType.PintoBean: return 0.03f;
                case SubType.Pistachio: return 0.05f;
                case SubType.Rice: return 0.01f;
                case SubType.Walnut: return 0.05f;
                case SubType.Wheat: return 0.01f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}