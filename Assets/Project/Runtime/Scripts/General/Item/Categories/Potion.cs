using System.Collections;
using System.Collections.Generic;
using RLSKTD.General.ItemHelper;
using Sirenix.Serialization;
using UnityEngine;
using Sirenix.OdinInspector;

namespace RLSKTD.General.ItemType
{
    /// <summary> The Potion class. </summary>
    /// <remarks> This class is used to define the Potion item. </remarks>
    
    public class Potion : Item
    {
        /// <summary> The amount of potions in the stack. </summary>
        [OdinSerialize]private int stackAmount = 1;
        
        public Potion(string name, string description, Type.TypeEnum type, Quality.ItemQuality quality, ItemHelper.Material.MaterialEnum material, Weight.WeightEnum weightClass, float itemWeight, bool isIdentified) : base(name, description, type, quality, material, weightClass, isIdentified)
        {
            this.Name = name;
            this.Description = description;
            this.ItemType = Type.TypeEnum.Potion;
            this.ItemQuality = quality;
            this.ItemMaterial = ItemHelper.Material.MaterialEnum.Glass;
            this.WeightClass = Weight.WeightEnum.VeryLight;
            this.IsIdentified = isIdentified;
            this.ItemWeight = itemWeight;
        }
        
        [Button("Make Minor Health Potion")]
        public void MakePotion()
        {
            this.Name = "Potion of minor cure wounds";
            this.Description = "A potion that restores some health.";
            this.ItemType = Type.TypeEnum.Potion;
            this.ItemQuality = Quality.ItemQuality.Inferior;
            this.ItemMaterial = ItemHelper.Material.MaterialEnum.Glass;
            this.WeightClass = Weight.WeightEnum.VeryLight;
            this.IsIdentified = false;
            this.ItemWeight = 0.1f;
            this.Color = Color.red;
        }
    }
}