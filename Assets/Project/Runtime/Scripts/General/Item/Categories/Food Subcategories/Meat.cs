using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Meat : Food{

        public enum SubType{
            Beef, Chicken, Duck, Goat, Lamb, Mutton, Ox,
            Rabbit, Turkey, 
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

        public Meat(){
            _FoodType = FoodType.Meat;
        }

        public Meat(SubType subType, bool isCooked){
            _SubType = subType;
            IsCooked = isCooked;
            _FoodType = FoodType.Meat;
        }

        private void SetNameAndDescription()
        {
            Name = "Raw " + subType.ToString();

            switch (subType)
            {
                case SubType.Beef:
                    Description = "A Whole Beef";
                    break;
                case SubType.Chicken:
                    Description = "A Whole Chicken";
                    break;
                case SubType.Duck:
                    Description = "A Whole Duck";
                    break;
                case SubType.Goat:
                    Description = "A Whole Goat";
                    break;
                case SubType.Lamb:
                    Description = "A Whole Lamb";
                    break;
                case SubType.Mutton:
                    Description = "A Whole Mutton";
                    break;
                case SubType.Ox:
                    Description = "A Whole Ox";
                    break;
                case SubType.Rabbit:
                    Description = "A Whole Rabbit";
                    break;
                case SubType.Turkey:
                    Description = "A Whole Turkey";
                    break;
                default: Description = "A meat. (?)"; break;
            }
        }

        private void SetSatiety(){
            switch (subType)
            {
                case SubType.Beef:
                case SubType.Ox:
                    Satiety = 100;
                    break;
                case SubType.Chicken:
                    Satiety = 20;
                    break;
                case SubType.Duck:
                    Satiety = 25;
                    break;
                case SubType.Goat:
                    Satiety = 60;
                    break;
                case SubType.Lamb:
                case SubType.Mutton:
                    Satiety = 80;
                    break;
                case SubType.Rabbit:
                    Satiety = 15;
                    break;
                case SubType.Turkey:
                    Satiety = 30;
                    break;
                default: Satiety = 10; break;
            }
        }

        private void SetBaseWeight(){
            switch (subType)
            {
                case SubType.Beef:
                    BaseWeight = 200f;
                    break;
                case SubType.Chicken:
                    BaseWeight = 3f;
                    break;
                case SubType.Duck:
                    BaseWeight = 7f;
                    break;
                case SubType.Goat:
                    BaseWeight = 70f;
                    break;
                case SubType.Lamb:
                    BaseWeight = 80f;
                    break;
                case SubType.Mutton:
                    BaseWeight = 80f;
                    break;
                case SubType.Ox:
                    BaseWeight = 200f;
                    break;
                case SubType.Rabbit:
                    BaseWeight = 3f;
                    break;
                case SubType.Turkey:
                    BaseWeight = 5f;
                    break;
                default: BaseWeight = 10f; break;
            }
        }
    }
}