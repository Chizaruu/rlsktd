using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.PotionSubcategories
{
    [System.Serializable]
    public class Beverage : Potion
    {
        public enum SubType{
            Water, Whiskey, Wine, Ale, Mead, Milk, Soda
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;
        
        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                
                SetNameAndDescription();
                SetThirst();
                SetBaseWeight();
                IsIdentified = true;
            }
        }

        public Beverage(){
            _PotionType = PotionType.Beverage;
        }

        public Beverage(SubType subType){
            _SubType = subType;
            _PotionType = PotionType.Beverage;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            switch (subType)
            {
                case SubType.Water:
                    Description = "A clear liquid";
                    break;
                case SubType.Whiskey:
                    Description = "A strong alcoholic beverage";
                    break;
                case SubType.Wine: 
                    Description = "A strong alcoholic beverage";
                    break;
                case SubType.Ale:
                    Description = "A strong alcoholic beverage";
                    break;
                case SubType.Mead:
                    Description = "A strong alcoholic beverage";
                    break;
                case SubType.Milk:
                    Description = "A strong alcoholic beverage";
                    break;
                case SubType.Soda:
                    Description = "A fizzy beverage";
                    break;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
            }
        }

        private void SetThirst(){
            switch (subType)
            {
                default: Thirst = 10; break;
            }
        }

        private void SetBaseWeight(){
            switch (subType)
            {
                default: BaseWeight = 0.25f; break;
            }
        }

        [Button("Generate New Beverage")]
        public void GenerateNewBeverage(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _PotionType = PotionType.Beverage;
        }
    }
}