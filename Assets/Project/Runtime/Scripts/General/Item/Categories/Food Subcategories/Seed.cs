using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
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
                _Material = ItemHelpers.Material.MaterialEnum.Organic;
                _IsIdentified = true;
                switch (subType)
                {
                    case SubType.Almond:
                        _Name = "Almond";
                        _Description = "A seed of the Almond tree.";
                        Satiety = 3;
                        break;
                    case SubType.Barley:
                        _Name = "Barley";
                        _Description = "A seed of the Barley tree.";
                        Satiety = 3;
                        break;
                    case SubType.Cashew:
                        _Name = "Cashew";
                        _Description = "A seed of the Cashew tree.";
                        Satiety = 3;
                        break;
                    case SubType.Chestnut:
                        _Name = "Chestnut";
                        _Description = "A seed of the Chestnut tree.";
                        Satiety = 3;
                        break;
                    case SubType.Chickpea:
                        _Name = "Chickpea";
                        _Description = "A seed of the Chickpea tree.";
                        Satiety = 3;
                        break;
                    case SubType.CocoaBean:
                        _Name = "Cocoa Bean";
                        _Description = "A seed of the Cocoa Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Coconut:
                        _Name = "Coconut";
                        _Description = "A seed of the Coconut tree.";
                        Satiety = 3;
                        break;
                    case SubType.CoffeeBean:    
                        _Name = "Coffee Bean";
                        _Description = "A seed of the Coffee Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Corn:
                        _Name = "Corn";
                        _Description = "A seed of the Corn tree.";
                        Satiety = 3;
                        break;
                    case SubType.Lentil:
                        _Name = "Lentil";
                        _Description = "A seed of the Lentil tree.";
                        Satiety = 3;
                        break;
                    case SubType.LimaBean:
                        _Name = "Lima Bean";
                        _Description = "A seed of the Lima Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Legume:
                        _Name = "Legume";
                        _Description = "A good source of vitamins C and E, zinc, and other antioxidants that strengthen your immune system.";
                        Satiety = 3;
                        break;
                    case SubType.Peanut:
                        _Name = "Peanut";
                        _Description = "A seed of the Peanut tree.";
                        Satiety = 3;
                        break;
                    case SubType.PintoBean:
                        _Name = "Pinto Bean";
                        _Description = "A seed of the Pinto Bean tree.";
                        Satiety = 3;
                        break;
                    case SubType.Pistachio:
                        _Name = "Pistachio";
                        _Description = "A seed of the Pistachio tree.";
                        Satiety = 3;
                        break;
                    case SubType.Rice:
                        _Name = "Rice";
                        _Description = "A seed of the Rice tree.";
                        Satiety = 3;
                        break;
                    case SubType.Walnut:
                        _Name = "Walnut";
                        _Description = "A seed of the Walnut tree.";
                        Satiety = 3;
                        break;
                    case SubType.Wheat:
                        _Name = "Wheat";
                        _Description = "A seed of the Wheat tree.";
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