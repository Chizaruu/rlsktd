using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Ear class </summary>
    [System.Serializable]
    public class Ear : Armor
    {
        public enum SubType
        {
            Earring
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                _Weight = 0.03f;
                _WeightClass = WeightClass.Light;
            }
        }
    }
}