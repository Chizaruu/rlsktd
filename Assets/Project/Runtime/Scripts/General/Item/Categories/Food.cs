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
        [OdinSerialize, UnityEngine.HideInInspector]private bool isStackable = true;
        [OdinSerialize, UnityEngine.HideInInspector]private float satiety = 15;
        [OdinSerialize, UnityEngine.HideInInspector]private int shelfLife = 30;
        [OdinSerialize, UnityEngine.HideInInspector]private int stackamount = 1;
        
        [ShowInInspector]public FoodType _FoodType { get => foodType; set => foodType = value; } 
        [ShowInInspector]public bool IsCooked { get => isCooked; set => isCooked = value; }
        [ShowInInspector]public bool IsStackable { get => isStackable; set => isStackable = value; }
        [ShowInInspector]public float Satiety { get => satiety; set => satiety = value; }
        [ShowInInspector]public int ShelfLife { get => shelfLife; set => shelfLife = value; }
        [ShowInInspector]public int StackAmount { get => stackamount; set => stackamount = value; }
        
    }
}
