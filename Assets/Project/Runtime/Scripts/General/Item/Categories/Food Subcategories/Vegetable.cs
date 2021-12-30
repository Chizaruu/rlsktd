using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    /// <summary> This is the Vegetable class </summary>
    [System.Serializable]
    public class Vegetable : Food{
        /// <summary> This is the Vegetable class </summary>
        public enum SubType
        {
            Artichoke, Asparagus, Beetroot, BellPepper, Broccoli, BrusselSprout, Cabbage, 
            Carrot, Cauliflower, Celery, Cucumber, Eggplant, Garlic, GreenBean, Leek, Lettuce,
            Mushroom, Onion, Parsnip, Pumpkin, Potato, Radish, Spinach, Squash, Turnip, Yam, Zucchini
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

        public Vegetable(SubType subType, bool isCooked){
            _SubType = subType;
            IsCooked = isCooked;
            _Type = Type.Food;
            _FoodType = FoodType.Vegetable;
            _Material = ItemHelpers.Material.MaterialEnum.Organic;
            IsIdentified = true;
        }

        public void SetNameAndDescription(){
            Name = _SubType.ToString();

            switch (subType){
                case SubType.Asparagus:
                    Description = "A vegetable that is high in fiber, vitamins, minerals and antioxidants, making it a nutritious addition to your diet.";
                    break;
                case SubType.BellPepper:
                    Description = "Contains antioxidants called carotenoids that may reduce inflammation, decrease cancer risk and protect cholesterol and fats from oxidative damage";
                    break;
                case SubType.Broccoli:
                    Description = "Contains fibers, fatty acids and vitamins that help regulating blood pressure in the body.";
                    break;
                case SubType.BrusselSprout:
                    Description = "Its high in fiber, vitamins, minerals and antioxidants, making it a nutritious addition to your diet.";
                    break;
                case SubType.Cabbage:
                    Description = "A vegetable that is high in beta-carotene, vitamin C and fiber.";
                    break;
                case SubType.Carrot:
                    Description = "Loaded with vitamin A and beta-carotene.";
                    break;
                case SubType.Cauliflower:
                    Description = "Provides antioxidants and phytonutrients that can protect against cancer.";
                    break;
                case SubType.Celery:
                    Description = "Its rich in fiber and nutrients and helps lower cholesterol, treats constipation, reduces stress hormone levels, fights inflammation and provides many other benefits.";
                    break;
                case SubType.Cucumber:
                    Description = "Its low in calories but contain many important vitamins and minerals, as well as a high water content.";
                    break;
                case SubType.Eggplant:
                    Description = "It has antioxidants like vitamins A and C, which help protect your cells against damage.";
                    break;
                case SubType.Garlic:
                    Description = "Loaded with good-for-you vitamins and minerals like manganese, selenium, vitamin C, vitamin B6, and other antioxidants, including allicin.";
                    break;
                case SubType.Leek:
                    Description = "Its rich in Vitamin K, which may reduce the risk of osteoporosis.";
                    break;
                case SubType.Lettuce:
                    Description = "Provides fibre, vitamins, minerals and phytochemicals for very, very few calories.";
                    break;
                case SubType.Mushroom:
                    Description = "Its a rich, low calorie source of fiber, protein, and antioxidants.";
                    break;
                case SubType.Onion: 
                    Description = "It contains antioxidants and compounds that fight inflammation, decrease triglycerides and reduce cholesterol levels";
                    break;
                case SubType.Parsnip:
                    Description = "Along with vitamin C, parsnips are rich in potassium, a mineral that helps your heart function, balances your blood pressure, and lowers your risk for kidney stones.";
                    break;
                case SubType.Pumpkin:
                    Description = "Its nutrients and antioxidants may boost your immune system, protect your eyesight, lower your risk of certain cancers and promote heart and skin health.";
                    break;
                case SubType.Potato:
                    Description = "A great source of fiber, which can help you lose weight by keeping you full longer.";
                    break;
                case SubType.Radish:
                    Description = "Its rich in antioxidants and minerals like calcium and potassium.";
                    break;
                case SubType.Spinach:
                    Description = "It contains vitamins and minerals like vitamin E and magnesium that support your immune system.";
                    break;
                case SubType.Squash:
                    Description = "Its high in vitamins A, B6, and C, folate, magnesium, fiber, riboflavin, phosphorus, and potassium.";
                    break;
                case SubType.Turnip:
                    Description = "Its loaded with fiber and vitamins K, A, C, E, B1, B3, B5, B6, B2 and folate (one of the B vitamins), as well as minerals like manganese, potassium, magnesium, iron, calcium and copper.";
                    break;
                case SubType.Yam:
                    Description = "A great source of fiber, potassium, manganese, copper, and antioxidants.";
                    break;
                case SubType.Zucchini:
                    Description = "A versatile squash rich in vitamins, minerals, and plant compounds.";
                    break;
                default: Description = "A Cheeky Vegetable."; break;
            }
        }

        private void SetSatiety(){
            switch (subType){
                case SubType.Broccoli:
                case SubType.Cabbage:
                case SubType.Cauliflower:
                case SubType.Lettuce:
                case SubType.Pumpkin:
                    Satiety = 15;
                    break;
                case SubType.BrusselSprout:
                case SubType.Garlic:
                case SubType.Mushroom:
                case SubType.Radish:
                case SubType.Squash:
                case SubType.Turnip:
                    Satiety = 5;
                    break;
                default: Satiety = 10; break;
            }
        }

        private void SetWeight(){
            switch (subType){
                case SubType.Broccoli:
                case SubType.Cabbage:
                case SubType.Cauliflower:
                case SubType.Lettuce:
                case SubType.Pumpkin:
                    Weight = 3f;
                    break;
                case SubType.BrusselSprout:
                case SubType.Garlic:
                case SubType.Mushroom:
                case SubType.Radish:
                case SubType.Squash:
                case SubType.Turnip:
                    Weight = 0.05f;
                    break;
                default: Weight = 0.1f; break;
            }
        }
    }
}