using RLSKTD.General.ItemHelpers;
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
                _Material = ItemHelpers.Material.MaterialEnum.Organic;
                _IsIdentified = true;
                switch (subType)
                {
                    case SubType.Artichoke:
                        _Name = "Artichoke";
                        _Description = "A vegetable low in fat while rich in fiber, vitamins, minerals, and antioxidants.";
                        Satiety = 10;
                        break;
                    case SubType.Asparagus:
                        _Name = "Asparagus";
                        _Description = "Low in calories and a great source of nutrients, including fiber, folate and vitamins.";
                        Satiety = 10;
                        break;
                    case SubType.Beetroot:
                        _Name = "Beetroot";
                        _Description = "A great source of fiber, folate (vitamin B9), manganese, potassium, iron, and vitamin C.";
                        Satiety = 10;
                        break;
                    case SubType.BellPepper:
                        _Name = "Bell Pepper";
                        _Description = "Contains antioxidants called carotenoids that may reduce inflammation, decrease cancer risk and protect cholesterol and fats from oxidative damage";
                        Satiety = 10;
                        break;
                    case SubType.Broccoli:
                        _Name = "Broccoli";
                        _Description = "Contains fibers, fatty acids and vitamins that help regulating blood pressure in the body.";
                        Satiety = 15;
                        break;
                    case SubType.BrusselSprout:
                        _Name = "Brussel Sprout";
                        _Description = "Its high in fiber, vitamins, minerals and antioxidants, making them a nutritious addition to your diet.";
                        Satiety = 10;
                        break;
                    case SubType.Cabbage:
                        _Name = "Cabbage";
                        _Description = "A vegetable that is high in beta-carotene, vitamin C and fiber.";
                        Satiety = 15;
                        break;
                    case SubType.Carrot:
                        _Name = "Carrot";
                        _Description = "Loaded with vitamin A and beta-carotene.";
                        Satiety = 10;
                        break;
                    case SubType.Cauliflower:
                        _Name = "Cauliflower";
                        _Description = "Provides antioxidants and phytonutrients that can protect against cancer.";
                        Satiety = 15;
                        break;
                    case SubType.Celery:
                        _Name = "Celery";
                        _Description = "Its rich in fiber and nutrients and helps lower cholesterol, treats constipation, reduces stress hormone levels, fights inflammation and provides many other benefits.";
                        Satiety = 10;
                        break;
                    case SubType.Cucumber:
                        _Name = "Cucumber";
                        _Description = "Its low in calories but contain many important vitamins and minerals, as well as a high water content.";
                        Satiety = 10;
                        break;
                    case SubType.Eggplant:
                        _Name = "Eggplant";
                        _Description = "It has antioxidants like vitamins A and C, which help protect your cells against damage.";
                        Satiety = 10;
                        break;
                    case SubType.Garlic:
                        _Name = "Garlic";
                        _Description = "Loaded with good-for-you vitamins and minerals like manganese, selenium, vitamin C, vitamin B6, and other antioxidants, including allicin.";
                        Satiety = 10;
                        break;
                    case SubType.GreenBean:
                        _Name = "Green Bean";
                        _Description = "It contains nutrients that are important for maintaining strong, healthy bones and reduces your risk of fractures.";
                        Satiety = 10;
                        break;
                    case SubType.Leek:
                        _Name = "Leek";
                        _Description = "Its rich in Vitamin K, which may reduce the risk of osteoporosis.";
                        Satiety = 10;
                        break;
                    case SubType.Lettuce:
                        _Name = "Lettuce";
                        _Description = "Provides fibre, vitamins, minerals and phytochemicals for very, very few calories.";
                        Satiety = 15;
                        break;
                    case SubType.Mushroom:
                        _Name = "Mushroom";
                        _Description = "Its a rich, low calorie source of fiber, protein, and antioxidants.";
                        Satiety = 10;
                        break;
                    case SubType.Onion:
                        _Name = "Onion";
                        _Description = "It contains antioxidants and compounds that fight inflammation, decrease triglycerides and reduce cholesterol levels";
                        Satiety = 10;
                        break;
                    case SubType.Parsnip:
                        _Name = "Parsnip";
                        _Description = "Along with vitamin C, parsnips are rich in potassium, a mineral that helps your heart function, balances your blood pressure, and lowers your risk for kidney stones.";
                        Satiety = 10;
                        break;
                    case SubType.Pumpkin:
                        _Name = "Pumpkin";
                        _Description = "Its nutrients and antioxidants may boost your immune system, protect your eyesight, lower your risk of certain cancers and promote heart and skin health.";
                        Satiety = 15;
                        break;
                    case SubType.Potato:
                        _Name = "Potato";
                        _Description = "A great source of fiber, which can help you lose weight by keeping you full longer.";
                        Satiety = 10;
                        break;
                    case SubType.Radish:
                        _Name = "Radish";
                        _Description = "Its rich in antioxidants and minerals like calcium and potassium.";
                        Satiety = 10;
                        break;
                    case SubType.Spinach:
                        _Name = "Spinach";
                        _Description = "It contains vitamins and minerals like vitamin E and magnesium that support your immune system.";
                        Satiety = 10;
                        break;
                    case SubType.Squash:
                        _Name = "Squash";
                        _Description = "Its high in vitamins A, B6, and C, folate, magnesium, fiber, riboflavin, phosphorus, and potassium.";
                        Satiety = 10;
                        break;
                    case SubType.Turnip:
                        _Name = "Turnip";
                        _Description = "Its loaded with fiber and vitamins K, A, C, E, B1, B3, B5, B6, B2 and folate (one of the B vitamins), as well as minerals like manganese, potassium, magnesium, iron, calcium and copper.";
                        Satiety = 10;
                        break;
                    case SubType.Yam:
                        _Name = "Yam";
                        _Description = "A great source of fiber, potassium, manganese, copper, and antioxidants.";
                        Satiety = 10;
                        break;
                    case SubType.Zucchini:
                        _Name = "Zucchini";
                        _Description = "A versatile squash rich in vitamins, minerals, and plant compounds.";
                        Satiety = 10;
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.Artichoke: return 0.2f;
                case SubType.Asparagus: return 0.02f;
                case SubType.Beetroot: return 0.2f;
                case SubType.BellPepper: return 0.05f;
                case SubType.Broccoli: return 0.3f;
                case SubType.BrusselSprout: return 0.03f;
                case SubType.Cabbage: return 1f;
                case SubType.Carrot: return 0.1f;
                case SubType.Cauliflower: return 0.8f;
                case SubType.Celery: return 0.4f;
                case SubType.Cucumber: return 0.5f;
                case SubType.Eggplant: return 0.2f;
                case SubType.Garlic: return 0.02f;
                case SubType.GreenBean: return 0.02f;
                case SubType.Leek: return 0.4f;
                case SubType.Lettuce: return 1f;
                case SubType.Mushroom: return 0.01f;
                case SubType.Onion: return 0.3f;
                case SubType.Parsnip: return 0.2f;
                case SubType.Pumpkin: return 1f;
                case SubType.Potato: return 0.2f;
                case SubType.Radish: return 0.05f;
                case SubType.Spinach: return 0.3f;
                case SubType.Squash: return 0.1f;
                case SubType.Turnip: return 0.2f;
                case SubType.Yam: return 0.5f;
                case SubType.Zucchini: return 0.3f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}