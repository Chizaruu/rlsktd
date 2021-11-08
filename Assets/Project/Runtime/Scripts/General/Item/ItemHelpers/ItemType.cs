using UnityEngine;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> Item type. </summary>
    public class ItemType 
    {
        [SerializeField]private string type; // Item type.
        [SerializeField]private string subType; // Item sub type.

        public string Type { get => type; set => type = value; }
        public string SubType { get => subType; set => subType = value; }
    }
}