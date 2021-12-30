using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Plant : Food{
        public enum SubType
        {
            SugarCane, Rose
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

        public Plant(SubType subType){
            _SubType = subType;
            _Type = Type.Food;
            _FoodType = FoodType.Plant;
            _Material = ItemHelpers.Material.MaterialEnum.Organic;
            IsIdentified = true;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            switch (subType)
            {
                case SubType.SugarCane:
                    Description = "A sweet, sweet sugar cane.";
                    break;
                case SubType.Rose:
                    Description = "A beautiful flower";
                    break;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
            }
        }

        private void SetSatiety(){
            switch (subType)
            {
                case SubType.SugarCane:
                    Satiety = 5;
                    break;
                default: Satiety = 1; break;
            }
        }

        private void SetWeight(){
            switch (subType)
            {
                case SubType.SugarCane:
                    Weight = 2f;
                    break;
                default: Weight = 0.1f; break;
            }
        }
    }
}