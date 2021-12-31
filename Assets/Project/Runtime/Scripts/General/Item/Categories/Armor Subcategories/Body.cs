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

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Body(){
            _ArmorType = ArmorType.Body;
        }

        public Body(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _ArmorType = ArmorType.Body;
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
                case SubType.Robe:
                    Weight = 0.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                    _WeightClass = WeightClass.Light;
                    break;
                case SubType.Kimono:
                    Weight = 0.6f + (float)Math.Round(Material.GetMaterialWeight(_Material)/4.5, 1);
                    _WeightClass = WeightClass.Light;
                    break;
                case SubType.Leatherarmor:
                case SubType.Scalemail:
                    Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3.5, 1);
                    _WeightClass = WeightClass.Medium;
                    break;
                default:
                    Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                    _WeightClass = WeightClass.Heavy;
                    break;
            }
        }

        [Button("Generate New Body")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(SubType)).Length);
            _Material = (Material.MaterialEnum)UnityEngine.Random.Range(0, Enum.GetNames(typeof(Material.MaterialEnum)).Length);
            _ArmorType = ArmorType.Body;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            SetWeightAndArmorClass();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }
    }
}