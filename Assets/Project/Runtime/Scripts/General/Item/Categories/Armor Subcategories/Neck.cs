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

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Neck(){
            _ArmorType = ArmorType.Neck;
        }

        public Neck(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _ArmorType = ArmorType.Neck;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            Weight = 0.05f;
            _WeightClass = WeightClass.Light;
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        [Button("Generate New Neck")]
        private void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(SubType)).Length);
            _Material = (Material.MaterialEnum)UnityEngine.Random.Range(0, Enum.GetValues(typeof(Material.MaterialEnum)).Length);
            _ArmorType = ArmorType.Neck;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            Weight = 0.05f;
            _WeightClass = WeightClass.Light;
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }
    }
}