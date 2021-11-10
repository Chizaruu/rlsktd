using UnityEngine;
using RLSKTD.General.ItemHelper;

namespace RLSKTD.General
{
    /// <summary> Base class for all items. </summary>
    /// <remarks> This class is used to define the base properties of all items. </remarks>
    [System.Serializable]
    public class Item
    {
        /// <summary> The name of the item. </summary>
        [SerializeField]private string name;
        /// <summary> The description of the item. </summary>
        [SerializeField]private string description;

        [SerializeField]private Type type;
        [SerializeField]private Quality quality;
        [SerializeField]private ItemHelper.Material material;
        [SerializeField]private Weight weight;

        [SerializeField]private bool isIdentified; // Whether the item is identified or not.
        
        [SerializeField]private Color color; // Color of the item.

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Type Type { get => type; set => type = value; }
        public Quality Quality { get => quality; set => quality = value; }
        public ItemHelper.Material Material { get => material; set => material = value; }
        public Weight Weight { get => weight; set => weight = value; }

        public Color Color { get => color; set => color = value; }

        public bool IsIdentified { get => isIdentified; set => isIdentified = value; }

        public Item()
        {
            this.weight = Weight;
        }
    }
}

