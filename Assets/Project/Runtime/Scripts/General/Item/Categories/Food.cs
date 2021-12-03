using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories{
    /// <summary> This is the Food class </summary>
    [System.Serializable]
    public class Food : Item
    {
        public enum FoodType
        {
            Vegetable, Fruit, Seed, Meat, Dairy, Processed,
            Grass, Flower
        }

        [OdinSerialize, UnityEngine.HideInInspector]private FoodType foodType;
        [OdinSerialize, UnityEngine.HideInInspector]private bool isCooked;
        [OdinSerialize, UnityEngine.HideInInspector]private bool isStackable = true;
        [OdinSerialize, UnityEngine.HideInInspector]private float wellness = 15;
        [OdinSerialize, UnityEngine.HideInInspector]private int shelfLife = 30;
        [OdinSerialize, UnityEngine.HideInInspector]private int stackamount = 1;
        

        [ShowInInspector]public FoodType _FoodType { get => foodType; set => foodType = value; } 
        [ShowInInspector]public bool IsCooked { get => isCooked; set => isCooked = value; }
        [ShowInInspector]public bool IsStackable { get => isStackable; set => isStackable = value; }
        [ShowInInspector]public float Wellness { get => wellness; set => wellness = value; }
        [ShowInInspector]public int ShelfLife { get => shelfLife; set => shelfLife = value; }
        [ShowInInspector]public int StackAmount { get => stackamount; set => stackamount = value; }
        
    }
}
