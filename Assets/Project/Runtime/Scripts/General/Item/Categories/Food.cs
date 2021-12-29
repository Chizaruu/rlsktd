using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

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
        [OdinSerialize, UnityEngine.HideInInspector]private int stackamount = 1;
        
        [ShowInInspector]public FoodType _FoodType { get => foodType; set => foodType = value; } 
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
                            if(Name.Contains("Raw")){
                                Name = Name.Replace("Raw", "Cooked");
                            } else{
                                Name = "Cooked " + Name;
                            }
                            break;
                        default:
                            break;
                    }
                    
                } else {
                    switch(foodType){
                        case FoodType.Meat:
                        case FoodType.Seafood:
                        case FoodType.Vegetable:
                            Name = "Raw " + Name;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        [ShowInInspector]public float Satiety { get => satiety; set => satiety = value; }
        [ShowInInspector]public int StackAmount { get => stackamount; set => stackamount = value; }

        public Food()
        {
            _Material = ItemHelpers.Material.MaterialEnum.Organic;
            IsIdentified = true;
        }
    }
}
