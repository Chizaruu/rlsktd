using Sirenix.OdinInspector;
using Sirenix.Serialization;
using RLSKTD.General.ItemHelpers.SoftMaterials;

namespace RLSKTD.General.ItemCategories{
    /// <summary> This is the Food class </summary>
    [System.Serializable]
    public class Food : Item
    {
        public enum FoodType
        {
            Dairy, Fruit, Meat, Plant, Processed, Seafood,
            Seed, Vegetable
        }

        [OdinSerialize, UnityEngine.HideInInspector]private FoodType foodType;
        [OdinSerialize, UnityEngine.HideInInspector]private bool isCooked;
        [OdinSerialize, UnityEngine.HideInInspector]private float satiety;
        [OdinSerialize, UnityEngine.HideInInspector]private float baseWeight;
        [OdinSerialize, UnityEngine.HideInInspector]private int stackamount = 1;
        
        /// <summary> Used to get and set foodType, also sets _Type, _Material and IsIdentified </summary>
        [ShowInInspector, ReadOnly]public FoodType _FoodType
        {
            get => foodType; set
            {
                foodType = value;

                _Type = Type.Food;
                _Material = new Common(Common.Material.Organic);
                IsIdentified = true;
            }
        }
        [ShowInInspector]public bool IsCooked
        {
            get => isCooked; set
            {
                isCooked = value;

                if(isCooked){
                    switch(foodType){
                        case FoodType.Meat:
                        case FoodType.Seafood:
                        case FoodType.Vegetable:
                            Name = Name.Replace("Raw", "Cooked");
                            break;
                        default:
                            break;
                    }
                    
                } else {
                    switch(foodType){
                        case FoodType.Meat:
                        case FoodType.Seafood:
                        case FoodType.Vegetable:
                            Name = Name.Replace("Cooked", "Raw");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        [ShowInInspector]public float Satiety { get => satiety; set => satiety = value; }
        [ShowInInspector, ReadOnly]public float BaseWeight
        {
            get => baseWeight; set
            {
                baseWeight = value;

                Weight = baseWeight;
            }
        }
        [ShowInInspector]public int StackAmount
        {
            get => stackamount; set
            {
                if(value > 0){
                    stackamount = value;
                } else {
                    stackamount = 1;
                }

                Weight = baseWeight * stackamount;
            }
        }
    }
}
