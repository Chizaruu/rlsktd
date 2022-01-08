using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Finger class </summary>
    [System.Serializable]
    public class Finger : Armor
    {
        public enum SubType
        {
            Ring, Band
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Finger(){
            _ArmorType = ArmorType.Finger;
        }

        public Finger(SubType subType, Material material){
            _SubType = subType;
            _Material = material;
            _ArmorType = ArmorType.Finger;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            Weight = 0.03f;
            _WeightClass = WeightClass.Light;
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        [Button("Generate New Finger")]
        private void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(SubType)).Length);
            _Material = RandomItemGenerator.GenerateMaterial(false, true);
            _ArmorType = ArmorType.Finger;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            Weight = 0.03f;
            _WeightClass = WeightClass.Light;
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }
    }
}