using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Foot class </summary>
    [System.Serializable]
    public class Foot : Armor
    {
        public enum SubType
        {
            Boots, Sandals, Heels, Greaves
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Foot(){
            _ArmorType = ArmorType.Foot;
        }

        public Foot(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _ArmorType = ArmorType.Foot;
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
                case SubType.Greaves:
                    Weight = 0.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                    _WeightClass = WeightClass.Heavy;
                    break;
                case SubType.Boots:
                    Weight = 0.25f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3.5, 1);
                    _WeightClass = WeightClass.Medium;
                    break;
                default:
                    Weight = 0.1f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                    _WeightClass = WeightClass.Light;
                    break;
            }
        }

        [Button("Generate New Foot")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(SubType)).Length);
            _Material = (Material.MaterialEnum)UnityEngine.Random.Range(0, Enum.GetNames(typeof(Material.MaterialEnum)).Length);
            _ArmorType = ArmorType.Foot;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            SetWeightAndArmorClass();
            GenerateName(_SubType.ToString());
        }
    }
}