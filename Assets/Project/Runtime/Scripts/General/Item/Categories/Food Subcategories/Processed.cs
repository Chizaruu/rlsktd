using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    /*
        Currently unsupported for the following reasons:
        - This will take quite a while to implement, as it requires a lot of work.
        - Cooking system is not implemented yet.
    */
    [System.Serializable]
    public class Processed : Food{
        public enum SubType
        {
            Dough, Flour
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

        public Processed(){
            _FoodType = FoodType.Processed;
        }

        public Processed(SubType subType){
            _SubType = subType;
            _FoodType = FoodType.Processed;
        }

        private void SetNameAndDescription(){
            Name = _SubType.ToString();

            switch (_SubType)
            {
                case SubType.Dough:
                    Description = "A dough is a flat, dry, round, or spherical mass of flour or doughy substance, used in cooking.";
                    break;
                case SubType.Flour:
                    Description = "A flour is a type of food made by grinding or mixing whole grains, such as wheat, oats, barley, rye, or rice, into a paste or dough.";
                    break;
            
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
            }
        }

        private void SetSatiety(){
            switch (subType)
            {
                case SubType.Dough:
                    Satiety = 5;
                    break;
                case SubType.Flour:
                    Satiety = 3;
                    break;
                default: Satiety = 1; break;
            }
        }

        private void SetBaseWeight(){
            switch (subType)
            {
                case SubType.Dough:
                    BaseWeight = 0.3f;
                    break;
                default: BaseWeight = 0.2f; break;
            }
        }

        [Button("Generate New Processed")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _FoodType = FoodType.Processed;
        }  
    }
}