using RLSKTD.General.Item.Helpers;

namespace RLSKTD.General.Item{
    /// <summary> Base class for all items. </summary>
    /// <remarks> This class is used to define the base properties of all items. </remarks>
    [System.Serializable]
    public class Item {
        /// <summary> The name of the item. </summary>
        private string name;
        /// <summary> The description of the item. </summary>
        private string description;
        /// <summary> The material of the item. </summary>
        private Material.MaterialEnum material;
        /// <summary> The quality of the item. </summary>
        private Quality.QualityEnum quality;
        /// <summary> The weight of the item. </summary>
        private float weight;
        /// <summary> The identify clarification of the item. </summary>
        private bool isIdentified;
        /// <summary> The item's value. </summary>
        private int worth;
        /// <summary> The item's color. </summary>
        private UnityEngine.Color color;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Quality.QualityEnum _Quality { get => quality; set => quality = value; }
        public Material.MaterialEnum _Material { get => material; set => material = value; }
        public float Weight { get => weight; set => weight = value; }
        public bool IsIdentified { get => isIdentified; set => isIdentified = value; }
        public int Value { get => worth; set => worth = value; }
        public UnityEngine.Color Color { get => color; set => color = value; }

        /// <summary> Constructor for the item. </summary>
        /// <param name="name"> The name of the item. </param>
        /// <param name="description"> The description of the item. </param>
        /// <param name="type"> The type of the item. </param>
        /// <param name="quality"> The quality of the item. </param>
        /// <param name="material"> The material of the item. </param>
        /// <param name="weight"> The weight of the item. </param>
        /// <param name="isIdentified"> The identify clarification of the item. </param>
        /// <param name="color"> The color of the item. </param>
        public Item(string name, string description, Material.MaterialEnum material, Quality.QualityEnum quality, float weight, bool isIdentified, int worth, UnityEngine.Color color) {
            Name = name;
            Description = description;
            _Quality = quality;
            _Material = material;
            Weight = weight;
            IsIdentified = isIdentified;
            Value = worth;
            Color = color;
        }
    }
}