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
                
                SetNameAndDescription();
                SetSatiety();
                SetWeight();
            }
        }

        public Dairy(SubType subType){
            _SubType = subType;
            _FoodType = FoodType.Dairy;
            _Material = ItemHelpers.Material.MaterialEnum.Organic;
            IsIdentified = true;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            switch (subType)
            {
                case SubType.Butter:
                    Description = "A buttery substance";
                    break;
                case SubType.Cheese:
                    Description = "A cheesy substance";
                    break;
                case SubType.Cream: 
                    Description = "A creamy substance";
                    break;
                case SubType.IceCream:
                    Description = "A creamy substance";
                    break;
                case SubType.Milk:
                    Description = "A milky substance";
                    break;
                case SubType.Yogurt:
                    Description = "A creamy substance";
                    break;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
            }
        }

        private void SetSatiety(){
            switch (subType)
            {
                default: Satiety = 5; break;
            }
        }

        private void SetWeight(){
            switch (subType)
            {
                case SubType.Butter:
                    Weight = 0.2f;
                    break;
                case SubType.Cheese:
                    Weight = 0.3f;
                    break;
                case SubType.Cream:
                    Weight = 0.2f;
                    break;
                case SubType.IceCream:
                    Weight = 0.2f;
                    break;
                case SubType.Milk:
                    Weight = 0.5f;
                    break;
                case SubType.Yogurt:
                    Weight = 0.4f;
                    break;
                default: Weight = 0.1f; break;
            }
        }       
    }
}