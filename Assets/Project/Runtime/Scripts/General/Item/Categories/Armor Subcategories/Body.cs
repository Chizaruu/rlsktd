using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Body class </summary>
    [System.Serializable]
    public class Body : Armor
    {
        public enum SubType
        {
            Breastplate, Platemail, Scalemail, 
            Chainmail, Robe, Kimono, Leatherarmor
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                switch (subType)
                {
                    case SubType.Robe:
                        _Weight = 0.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                        _WeightClass = WeightClass.Light;
                        break;
                    case SubType.Kimono:
                        _Weight = 0.6f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                        _WeightClass = WeightClass.Light;
                        break;
                    case SubType.Leatherarmor:
                        _Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3.5, 1);
                        _WeightClass = WeightClass.Medium;
                        break;
                    case SubType.Scalemail:
                        _Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3.5, 1);
                        _WeightClass = WeightClass.Medium;
                        break;
                    default:
                        _Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                        _WeightClass = WeightClass.Heavy;
                        break;
                }
            }
        }
    }
}