using System;
using RLSKTD.General.Item.Helpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.ArmorSubcategories{
    /// <summary> This is the Back class </summary>
    [System.Serializable]
    public class Back : Armor
    {
        public enum SubType
        {
            Cloak, Cape, Mantle
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;

                switch (subType)
                {
                    case SubType.Cloak:
                        Weight = 0.8f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                        _WeightClass = WeightClass.Heavy;
                        break;
                    case SubType.Cape:
                        Weight = 0.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                        _WeightClass = WeightClass.Medium;
                        break;
                    default:
                        Weight = 0.6f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                        _WeightClass = WeightClass.Light;
                        break;
                }
            }
        }

    }
}