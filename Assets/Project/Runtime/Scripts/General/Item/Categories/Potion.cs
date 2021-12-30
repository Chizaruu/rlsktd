using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories
{
    /// <summary> The Potion class. </summary>
    /// <remarks> This class is used to define the Potion item. </remarks>

    [System.Serializable]
    public class Potion : Item
    {
        public enum PotionType{
            Beverage, Positive, Negative, Dye
        }

        [OdinSerialize, UnityEngine.HideInInspector]private PotionType potionType;

        [OdinSerialize, UnityEngine.HideInInspector]private float baseWeight;

        [OdinSerialize, UnityEngine.HideInInspector]private int stackAmount = 1;

        [OdinSerialize, UnityEngine.HideInInspector]private int thirst;
        
        /// <summary> Used to get and set potionType, also sets _Type and _Material </summary>
        [ShowInInspector, ReadOnly]public PotionType _PotionType
        {
            get => potionType; set
            {
                potionType = value;

                _Type = Type.Potion;
                _Material = ItemHelpers.Material.MaterialEnum.Glass;
            }
        }
        [ShowInInspector, ReadOnly]public float BaseWeight
        {
            get => baseWeight; set
            {
                baseWeight = value;

                Weight = baseWeight;
            }
        }
        [ShowInInspector, ReadOnly]public int StackAmount
        {
            get => stackAmount; set
            {
                if(value > 0){
                    stackAmount = value;
                } else {
                    stackAmount = 1;
                }

                Weight = baseWeight * stackAmount;
            }
        }
        [ShowInInspector, ReadOnly]public int Thirst { get => thirst; set => thirst = value; }
    }
}