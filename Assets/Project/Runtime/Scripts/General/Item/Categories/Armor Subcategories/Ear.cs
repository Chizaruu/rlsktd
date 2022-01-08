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

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Ear(){
            _ArmorType = ArmorType.Ear;
        }

        public Ear(SubType subType, Material material){
            _SubType = subType;
            _Material = material;
            _ArmorType = ArmorType.Ear;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            Weight = 0.03f;
            _WeightClass = WeightClass.Light;
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        [Button("Generate New Ear")]
        private void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(SubType)).Length);
            _Material = RandomItemGenerator.GenerateMaterial(false, true);
            _ArmorType = ArmorType.Ear;
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