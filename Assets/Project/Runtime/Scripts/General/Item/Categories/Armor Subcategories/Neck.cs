using System;
using RLSKTD.General.Item.Helpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.ArmorSubcategories{
    /// <summary> This is the Neck class </summary>
    [System.Serializable]
    public class Neck : Armor
    {
        public enum SubType
        {
            Necklace, Amulet, Choker, Pendant, Locket
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                Weight = 0.05f;
                _WeightClass = WeightClass.Light;
            }
        }
    }
}