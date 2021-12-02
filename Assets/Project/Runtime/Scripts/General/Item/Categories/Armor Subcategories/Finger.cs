using System;
using RLSKTD.General.Item.Helpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.ArmorSubcategories{
    /// <summary> This is the Finger class </summary>
    [System.Serializable]
    public class Finger : Armor
    {
        public enum SubType
        {
            Ring, Band
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                Weight = 0.03f;
                _WeightClass = WeightClass.Light;
            }
        }
    }
}