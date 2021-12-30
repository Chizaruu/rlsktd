using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Back class </summary>
    [System.Serializable]
    public class Back : Armor
    {
        public enum SubType
        {
            Cloak, Cape, Mantle
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        /// <summary> Constructor for the Back class. </summary>
        public Back(){}

        public Back(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _Type = Type.Armor;
            _ArmorType = ArmorType.Back;
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