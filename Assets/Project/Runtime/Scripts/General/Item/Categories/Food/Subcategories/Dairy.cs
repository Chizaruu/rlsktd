using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Dairy : Food{
        public enum SubType
        {
            Butter, Cheese, Cream, IceCream, Yogurt
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

        public Dairy(){
            _FoodType = FoodType.Dairy;
        }

        public Dairy(SubType subType){
            _SubType = subType;
            _FoodType = FoodType.Dairy;
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

        private void SetBaseWeight(){
            switch (subType)
            {
                case SubType.Butter:
                    BaseWeight = 0.2f;
                    break;
                case SubType.Cheese:
                    BaseWeight = 0.3f;
                    break;
                case SubType.Cream:
                    BaseWeight = 0.2f;
                    break;
                case SubType.IceCream:
                    BaseWeight = 0.2f;
                    break;
                case SubType.Yogurt:
                    BaseWeight = 0.4f;
                    break;
                default: BaseWeight = 0.1f; break;
            }
        }     

        [Button("Generate New Dairy")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _FoodType = FoodType.Dairy;
        }  
    }
}