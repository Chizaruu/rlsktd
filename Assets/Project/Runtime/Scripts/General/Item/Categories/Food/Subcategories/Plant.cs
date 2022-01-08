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
                SetBaseWeight();
            }
        }

        public Plant(){
            _FoodType = FoodType.Plant;
        }

        public Plant(SubType subType){
            _SubType = subType;
            _FoodType = FoodType.Plant;
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

        private void SetBaseWeight(){
            switch (subType)
            {
                case SubType.SugarCane:
                    BaseWeight = 2f;
                    break;
                default: BaseWeight = 0.1f; break;
            }
        }

        [Button("Generate New Plant")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _FoodType = FoodType.Plant;
        }  
    }
}