using UnityEngine;
using RLSKTD.General.ItemHelper;
using Sirenix.Serialization;

namespace RLSKTD.General
{
    /// <summary> Base class for all items. </summary>
    /// <remarks> This class is used to define the base properties of all items. </remarks>
    public class Item
    {
        /// <summary> The name of the item. </summary>
        [OdinSerialize, HideInInspector]
        private string name;
        /// <summary> The description of the item. </summary>
        [OdinSerialize, HideInInspector]
        private string description;
        /// <summary> The material of the item. </summary>
        [OdinSerialize, HideInInspector]
        private ItemHelper.Material.MaterialEnum itemMaterial;
        /// <summary> The type of the item. </summary>
        [OdinSerialize, HideInInspector]
        private Type.TypeEnum itemType;
        /// <summary> The quality of the item. </summary>
        [OdinSerialize, HideInInspector]
        private Quality.ItemQuality itemQuality;
        /// <summary> The weight class of the item. </summary>
        [OdinSerialize, HideInInspector]
        private Weight.WeightEnum weightClass;
        /// <summary> The weight of the item. </summary>
        [OdinSerialize, HideInInspector]
        private float itemWeight;
        /// <summary> The identify clarification of the item. </summary>
        [OdinSerialize, HideInInspector]
        private bool isIdentified;
        /// <summary> The color of the item. </summary>
        [OdinSerialize, HideInInspector]
        private Color color; // Color of the item.

        [OdinSerialize]public string Name { get => name; set => name = value; }
        [OdinSerialize]public string Description { get => description; set => description = value; }
        [OdinSerialize]public Type.TypeEnum ItemType { get => itemType; set => itemType = value; }
        [OdinSerialize]public Quality.ItemQuality ItemQuality { get => itemQuality; set => itemQuality = value; }
        [OdinSerialize]public ItemHelper.Material.MaterialEnum ItemMaterial { get => itemMaterial; set => itemMaterial = value; }
        [OdinSerialize]public Weight.WeightEnum WeightClass { get => weightClass; set => weightClass = value; }
        [OdinSerialize]public float ItemWeight
        {
            get => itemWeight; set
            {
                itemWeight = Weight.GetBaseWeight(WeightClass);
            }
        }

        [OdinSerialize]public Color Color { get => color; set => color = value; }

        [OdinSerialize]public bool IsIdentified { get => isIdentified; set => isIdentified = value; }

        /// <summary> Constructor for the item. </summary>
        /// <param name="name"> The name of the item. </param>
        /// <param name="description"> The description of the item. </param>
        /// <param name="type"> The type of the item. </param>
        /// <param name="quality"> The quality of the item. </param>
        /// <param name="material"> The material of the item. </param>
        /// <param name="weight"> The weight of the item. </param>
        /// <param name="isIdentified"> The identify clarification of the item. </param>
        /// <param name="color"> The color of the item. </param>
        public Item(string name, string description, Type.TypeEnum type, Quality.ItemQuality quality, ItemHelper.Material.MaterialEnum material, Weight.WeightEnum weightClass, bool isIdentified)
        {
            Name = name;
            Description = description;
            ItemType = type;
            ItemQuality = quality;
            ItemMaterial = material;
            WeightClass = weightClass;
            IsIdentified = isIdentified;
        }
    }
}

