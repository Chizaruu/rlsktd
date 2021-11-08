using System.Collections.Generic;
using UnityEngine;
using RLSKTD.General.ItemHelper;
using Sirenix.Serialization;

namespace RLSKTD.General
{
    /// <summary> Item contains all the information about an item. </summary>
    public class Item
    {
        [SerializeField]private string itemName, quality; // Name and quality of the item.
        
        [SerializeField]private double weight; // Weight of the item.
        
        [SerializeField]private ItemType itemType; // Type of the item.
        [SerializeField]private ItemMaterial material; // Material of the item.
        [SerializeField]private Effect effect; // Effect of the item.

        [OdinSerialize]private Dictionary<string, int> stats; // Stats of the item.
        [OdinSerialize]private Dictionary<string, bool> purposes; // Purposes of the item.
        [SerializeField]private Sprite sprite; // Sprite of the item.
        [SerializeField]private Color color; // Color of the item.

        public string ItemName { get => itemName; set => itemName = value; }
        public string Quality { get => quality; set => quality = value; }

        public double Weight { get => weight; set => weight = value; }

        public ItemType ItemType { get => itemType; set => itemType = value; }
        public ItemMaterial Material { get => material; set => material = value; }
        public Effect Effect { get => effect; set => effect = value; }

        public Dictionary<string, int> Stats { get => stats; set => stats = value; }
        public Dictionary<string, bool> Purposes { get => purposes; set => purposes = value; }

        public Sprite Sprite { get => sprite; set => sprite = value; }
        public Color Color { get => color; set => color = value; }
    }
}

