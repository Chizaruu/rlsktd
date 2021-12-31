using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Fruit : Food{
        public enum SubType
        {
            Apple, Apricot, Avocado, Banana, Blackberry, Cantaloupe, Cherry,
            Fig, Grape, Olive, Grapefruit, Kiwi, Lemon, Lime, Mango,
            Mangosteen, Orange, Papaya, Peach, Pear, Pineapple, Plum,
            Strawberry, Tomato, Watermelon
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

        public Fruit(){
            _FoodType = FoodType.Fruit;
        }

        public Fruit(SubType subType)
        {
            _SubType = subType;
            _FoodType = FoodType.Fruit;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            switch (subType)
            { 
                case SubType.Apple:
                    Description = "A red fruit";
                    break;
                case SubType.Banana:
                    Description = "A yellow fruit";
                    break;
                case SubType.Blackberry:
                    Description = "A red fruit";
                    break;
                case SubType.Cantaloupe:
                    Description = "A yellow fruit";
                    break;
                case SubType.Cherry:
                    Description = "A red fruit";
                    break;
                case SubType.Fig:
                    Description = "A green fruit";
                    break;
                case SubType.Grape:
                    Description = "A green fruit";
                    break;
                case SubType.Olive:
                    Description = "A green fruit";
                    break;
                case SubType.Grapefruit:
                    Description = "A orange fruit";
                    break;
                case SubType.Kiwi:
                    Description = "A brown fruit";
                    break;
                case SubType.Lemon:
                    Description = "A yellow fruit";
                    break;
                case SubType.Lime:
                    Description = "A green fruit";
                    break;
                case SubType.Mango:
                    Description = "A yellow fruit";
                    break;
                case SubType.Mangosteen:
                    Description = "A purple fruit";
                    break;
                case SubType.Orange:
                    Description = "A orange fruit";
                    break;
                case SubType.Papaya:
                    Description = "A yellow fruit";
                    break;
                case SubType.Peach:
                    Description = "A orange fruit";
                    break;
                case SubType.Pear:
                    Description = "A green fruit";
                    break;
                case SubType.Pineapple:
                    Description = "A yellow fruit";
                    break;
                case SubType.Plum:
                    Description = "A purple fruit";
                    break;
                case SubType.Strawberry:
                    Description = "A red fruit";
                    break;
                case SubType.Tomato:
                    Description = "A red fruit";
                    break;
                case SubType.Watermelon:
                    Description = "A green fruit";
                    break;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
            }
        }

        private void SetSatiety(){
            switch (subType)
            {
                case SubType.Blackberry:
                case SubType.Cherry:
                case SubType.Grape:
                case SubType.Olive:
                    Satiety = 1;
                    break;
                case SubType.Fig:
                    Satiety = 5;
                    break;
                case SubType.Cantaloupe:
                case SubType.Grapefruit:
                case SubType.Papaya:
                case SubType.Pineapple:
                case SubType.Watermelon:
                    Satiety = 15;
                    break;
                default: Satiety = 10; break;
            }
        }

        private void SetBaseWeight()
        {
            switch (subType)
            {
                case SubType.Apple: BaseWeight = 0.2f; break;
                case SubType.Banana: BaseWeight = 0.2f; break;
                case SubType.Blackberry: BaseWeight = 0.01f; break;
                case SubType.Cantaloupe: BaseWeight = 1f; break;
                case SubType.Cherry: BaseWeight = 0.01f; break;
                case SubType.Grape: BaseWeight = 0.01f; break;
                case SubType.Olive: BaseWeight = 0.01f; break;
                case SubType.Grapefruit: BaseWeight = 0.5f; break;
                case SubType.Orange: BaseWeight = 0.2f; break;
                case SubType.Papaya: BaseWeight = 0.4f; break;
                case SubType.Peach: BaseWeight = 0.2f; break;
                case SubType.Pear: BaseWeight = 0.2f; break;
                case SubType.Pineapple: BaseWeight = 1f; break;
                case SubType.Strawberry: BaseWeight = 0.03f; break;
                case SubType.Watermelon: BaseWeight = 1f; break;
                default: BaseWeight = 0.1f; break;
            }
        }

        [Button("Generate New Fruit")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _FoodType = FoodType.Fruit;
        }  
    }
}