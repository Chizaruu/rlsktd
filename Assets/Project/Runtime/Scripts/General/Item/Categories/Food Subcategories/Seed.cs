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

                SetNameAndDescription();
                SetSatiety();
                SetBaseWeight();
            }
        }

        public Seed(){
            _FoodType = FoodType.Seed;
        }

        public Seed(SubType subType){
            _SubType = subType;
            _FoodType = FoodType.Seed;
        }

        private void SetNameAndDescription(){
            Name = _SubType.ToString();

            switch (_SubType)
            {
                case SubType.Almond:
                    Description = "A seed of the Almond tree.";
                    break;
                case SubType.Barley:
                    Description = "A seed of the Barley tree.";
                    break;
                case SubType.Cashew:
                    Description = "A seed of the Cashew tree.";
                    break;
                case SubType.Chestnut:
                    Description = "A seed of the Chestnut tree.";
                    break;
                case SubType.Chickpea:
                    Description = "A seed of the Chickpea tree.";
                    break;
                case SubType.CocoaBean:
                    Description = "A seed of the Cocoa Bean tree.";
                    break;
                case SubType.Coconut:
                    Description = "A seed of the Coconut tree.";
                    break;
                case SubType.CoffeeBean:
                    Description = "A seed of the Coffee Bean tree.";
                    break;
                case SubType.Corn:
                    Description = "A seed of the Corn tree.";
                    break;
                case SubType.Lentil:
                    Description = "A seed of the Lentil tree.";
                    break;
                case SubType.LimaBean:
                    Description = "A seed of the Lima Bean tree.";
                    break;
                case SubType.Legume:
                    Description = "It contains nutrients that are important for maintaining strong, healthy bones and reduces your risk of fractures.";
                    break;
                case SubType.Peanut:
                    Description = "A seed of the Peanut tree.";
                    break;
                case SubType.PintoBean:
                    Description = "A seed of the Pinto Bean tree.";
                    break;
                case SubType.Pistachio:
                    Description = "A seed of the Pistachio tree.";
                    break;
                case SubType.Rice:
                    Description = "A seed of the Rice tree.";
                    break;
                case SubType.Walnut:
                    Description = "A seed of the Walnut tree.";
                    break;
                case SubType.Wheat:
                    Description = "A seed of the Wheat tree.";
                    break;
                default: Description = "Maybe came from a tree."; break;
            }
        }

        private void SetSatiety(){
            switch (_SubType)
            {
                case SubType.Coconut:
                case SubType.Corn:
                    Satiety = 5;
                    break;
                default: Satiety = 3; break;
            }
        }
        
        private void SetBaseWeight(){
            switch(subType){
                case SubType.Coconut:
                    BaseWeight = 0.5f;
                    break;
                case SubType.Corn:
                    BaseWeight = 0.2f;
                    break;
                default:
                    BaseWeight = 0.02f;
                    break;
            }
        }
    }
}