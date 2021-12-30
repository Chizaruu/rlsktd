using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Waist class </summary>
    [System.Serializable]
    public class Waist : Armor
    {
        public enum SubType
        {
            Girdle, Belt, Sash
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Waist(){}

        public Waist(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _Type = Type.Armor;
            _ArmorType = ArmorType.Waist;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            SetWeightAndArmorClass();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        private void SetWeightAndArmorClass(){
            switch (subType)
            {
                case SubType.Girdle:
                    Weight = 0.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                    _WeightClass = WeightClass.Heavy;
                    break;
                case SubType.Belt:
                    Weight = 0.25f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3.5, 1);
                    _WeightClass = WeightClass.Medium;
                    break;
                default:
                    Weight = 0.1f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                    _WeightClass = WeightClass.Light;
                    break;
            }
        }
    }
}