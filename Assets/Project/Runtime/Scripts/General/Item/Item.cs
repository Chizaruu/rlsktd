using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General{
    /// <summary> Base class for all items. </summary>
    /// <remarks> This class is used to define the base properties of all items. </remarks>
    [System.Serializable]
    public class Item {
        /// <summary> The name of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private string name;
        /// <summary> The description of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private string description;
        /// <summary> The material of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private Material.MaterialEnum material;
        /// <summary> The quality of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private Quality.QualityEnum quality;
        /// <summary> The weight of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private float weight;
        /// <summary> The identify clarification of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private bool isIdentified;
        /// <summary> The item's value. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private int value;
        /// <summary> The item's color. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private UnityEngine.Color color;

        [ShowInInspector]public string Name { get => name; set => name = value; }
        [ShowInInspector]public string Description { get => description; set => description = value; }
        [ShowInInspector]public bool IsIdentified { get => isIdentified; set => isIdentified = value; }
        [ShowInInspector, ReadOnly]public Material.MaterialEnum _Material
        {
            get => material; set
            {
                material = value;
                Color = Material.GetMaterialColor(material);
            }
        }
        [ShowInInspector]public Quality.QualityEnum _Quality { get => quality; set => quality = value; }
        [ShowInInspector, ReadOnly]public float Weight { get => weight; set => weight = value; }
        [ShowInInspector, ReadOnly]public int Value { get => value; set => this.value = value; }
        [ShowInInspector, ReadOnly]public UnityEngine.Color Color { get => color; set => color = value; }
    }
}