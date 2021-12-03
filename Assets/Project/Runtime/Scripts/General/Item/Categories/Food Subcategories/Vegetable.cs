using RLSKTD.General.Item.Helpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.FoodSubcategories{
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
                switch (subType)
                {
                    case SubType.Artichoke:
                        Name = "Artichoke";
                        Description = "A vegetable low in fat while rich in fiber, vitamins, minerals, and antioxidants.";
                        break;
                    case SubType.Asparagus:
                        Name = "Asparagus";
                        Description = "Low in calories and a great source of nutrients, including fiber, folate and vitamins.";
                        break;
                    case SubType.Beetroot:
                        Name = "Beetroot";
                        Description = "A great source of fiber, folate (vitamin B9), manganese, potassium, iron, and vitamin C.";
                        break;
                    case SubType.BellPepper:
                        Name = "Bell Pepper";
                        Description = "Contains antioxidants called carotenoids that may reduce inflammation, decrease cancer risk and protect cholesterol and fats from oxidative damage";
                        break;
                    case SubType.Broccoli:
                        Name = "Broccoli";
                        Description = "Contains fibers, fatty acids and vitamins that help regulating blood pressure in the body.";
                        break;
                    case SubType.BrusselSprout:
                        Name = "Brussel Sprout";
                        Description = "Its high in fiber, vitamins, minerals and antioxidants, making them a nutritious addition to your diet.";
                        break;
                    case SubType.Cabbage:
                        Name = "Cabbage";
                        Description = "A vegetable that is high in beta-carotene, vitamin C and fiber.";
                        break;
                    case SubType.Carrot:
                        Name = "Carrot";
                        Description = "Loaded with vitamin A and beta-carotene.";
                        break;
                    case SubType.Cauliflower:
                        Name = "Cauliflower";
                        Description = "Provides antioxidants and phytonutrients that can protect against cancer.";
                        break;
                    case SubType.Celery:
                        Name = "Celery";
                        Description = "Its rich in fiber and nutrients and helps lower cholesterol, treats constipation, reduces stress hormone levels, fights inflammation and provides many other benefits.";
                        break;
                    case SubType.Cucumber:
                        Name = "Cucumber";
                        Description = "Its low in calories but contain many important vitamins and minerals, as well as a high water content.";
                        break;
                    case SubType.Eggplant:
                        Name = "Eggplant";
                        Description = "It has antioxidants like vitamins A and C, which help protect your cells against damage.";
                        break;
                    case SubType.Garlic:
                        Name = "Garlic";
                        Description = "Loaded with good-for-you vitamins and minerals like manganese, selenium, vitamin C, vitamin B6, and other antioxidants, including allicin.";
                        break;
                    case SubType.GreenBean:
                        Name = "Green Bean";
                        Description = "It contains nutrients that are important for maintaining strong, healthy bones and reduces your risk of fractures.";
                        break;
                    case SubType.Leek:
                        Name = "Leek";
                        Description = "Its rich in Vitamin K, which may reduce the risk of osteoporosis.";
                        break;
                    case SubType.Lettuce:
                        Name = "Lettuce";
                        Description = "Provides fibre, vitamins, minerals and phytochemicals for very, very few calories.";
                        break;
                    case SubType.Mushroom:
                        Name = "Mushroom";
                        Description = "Its a rich, low calorie source of fiber, protein, and antioxidants.";
                        break;
                    case SubType.Onion:
                        Name = "Onion";
                        Description = "It contains antioxidants and compounds that fight inflammation, decrease triglycerides and reduce cholesterol levels";
                        break;
                    case SubType.Parsnip:
                        Name = "Parsnip";
                        Description = "Along with vitamin C, parsnips are rich in potassium, a mineral that helps your heart function, balances your blood pressure, and lowers your risk for kidney stones.";
                        break;
                    case SubType.Pumpkin:
                        Name = "Pumpkin";
                        Description = "Its nutrients and antioxidants may boost your immune system, protect your eyesight, lower your risk of certain cancers and promote heart and skin health.";
                        break;
                    case SubType.Potato:
                        Name = "Potato";
                        Description = "A great source of fiber, which can help you lose weight by keeping you full longer.";
                        break;
                    case SubType.Radish:
                        Name = "Radish";
                        Description = "Its rich in antioxidants and minerals like calcium and potassium.";
                        break;
                    case SubType.Spinach:
                        Name = "Spinach";
                        Description = "It contains vitamins and minerals like vitamin E and magnesium that support your immune system.";
                        break;
                    case SubType.Squash:
                        Name = "Squash";
                        Description = "Its high in vitamins A, B6, and C, folate, magnesium, fiber, riboflavin, phosphorus, and potassium.";
                        break;
                    case SubType.Turnip:
                        Name = "Turnip";
                        Description = "Its loaded with fiber and vitamins K, A, C, E, B1, B3, B5, B6, B2 and folate (one of the B vitamins), as well as minerals like manganese, potassium, magnesium, iron, calcium and copper.";
                        break;
                    case SubType.Yam:
                        Name = "Yam";
                        Description = "A great source of fiber, potassium, manganese, copper, and antioxidants.";
                        break;
                    case SubType.Zucchini:
                        Name = "Zucchini";
                        Description = "A versatile squash rich in vitamins, minerals, and plant compounds.";
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

    }
}