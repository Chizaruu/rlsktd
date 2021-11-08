using UnityEngine;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> Item material. </summary>
    public class ItemMaterial 
    {
        [SerializeField]private string material; // Material name.
        [SerializeField]private string materialType; // Material type.

        public string Material { get => material; set => material = value; } //
        public string MaterialType { get => materialType; set => materialType = value; }
    }
}