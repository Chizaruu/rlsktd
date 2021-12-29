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
                SetWeight();
            }
        }

        public Meat(SubType subType, bool isCooked){
            _SubType = subType;
            IsCooked = isCooked;
            _FoodType = FoodType.Meat;
            _Material = ItemHelpers.Material.MaterialEnum.Organic;
            IsIdentified = true;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

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

        private void SetWeight(){
            switch (subType)
            {
                case SubType.Beef:
                    Weight = 200f;
                    break;
                case SubType.Chicken:
                    Weight = 3f;
                    break;
                case SubType.Duck:
                    Weight = 7f;
                    break;
                case SubType.Goat:
                    Weight = 70f;
                    break;
                case SubType.Lamb:
                    Weight = 80f;
                    break;
                case SubType.Mutton:
                    Weight = 80f;
                    break;
                case SubType.Ox:
                    Weight = 200f;
                    break;
                case SubType.Rabbit:
                    Weight = 3f;
                    break;
                case SubType.Turkey:
                    Weight = 5f;
                    break;
                default: Weight = 10f; break;
            }
        }
    }
}