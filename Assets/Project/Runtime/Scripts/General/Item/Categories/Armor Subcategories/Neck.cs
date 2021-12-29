using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
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