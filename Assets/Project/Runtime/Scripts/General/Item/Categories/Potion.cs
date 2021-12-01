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

        public Potion(string name, string description, Material.MaterialEnum material, Quality.QualityEnum quality, float weight, bool isIdentified, int worth, UnityEngine.Color color, int stackAmount) 
        : base(name, description, material, quality, weight, isIdentified, worth, color)
        {
            Name = name;
            Description = description;
            _Material = material;
            _Quality = quality;
            Weight = weight;
            IsIdentified = isIdentified;
            Value = worth;
            Color = color;
            StackAmount = stackAmount;
        }
    }
}