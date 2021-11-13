using System.Collections;
using System.Collections.Generic;
using RLSKTD.General.ItemHelper;
using UnityEngine;

namespace RLSKTD.General.ItemType
{
    /// <summary> The Potion class. </summary>
    public class Potion : Item
    {
        /// <summary> The amount of potions in the stack. </summary>
        [SerializeField]private int stackAmount = 1;

        public Potion(string name, string description, Type.TypeEnum type, Quality.ItemQuality quality, ItemHelper.Material.MaterialEnum material, Weight.WeightEnum weightClass, bool isIdentified) : base(name, description, type, quality, material, weightClass, isIdentified)
        {
        }
    }
}