using Sirenix.OdinInspector;
using Sirenix.Serialization;
using RLSKTD.General;

namespace RLSKTD.General.ItemCategories
{
    /// <summary> The Potion class. </summary>
    /// <remarks> This class is used to define the Potion item. </remarks>
    public class Potion : Item
    {
        public enum PotionType
        {
            Drink, Buff, Debuff, Dye
        }
        /// <summary> The type of potion. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private PotionType potionType;
        /// <summary> The effect of the potion </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private Effect effect;
        /// <summary> The amount of potions in the stack. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private int stackAmount = 1;
        
        [ShowInInspector, ReadOnly]public PotionType _PotionType { get => potionType; set => potionType = value; }
        [ShowInInspector, ReadOnly]public Effect _Effect { get => effect; set => effect = value; }
        [ShowInInspector, ReadOnly]public int StackAmount { get => stackAmount; set => stackAmount = value; }
    }
}