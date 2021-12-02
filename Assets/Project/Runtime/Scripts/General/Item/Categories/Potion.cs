using RLSKTD.General.Item.Helpers;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories
{
    /// <summary> The Potion class. </summary>
    /// <remarks> This class is used to define the Potion item. </remarks>
    
    public class Potion : Item
    {
        /// <summary> The amount of potions in the stack. </summary>
        [OdinSerialize]private int stackAmount = 1;
        
        public int StackAmount { get => stackAmount; set => stackAmount = value; }
    }
}