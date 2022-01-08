using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Head class </summary>
    [System.Serializable]
    public class Head : Armor
    {
        public enum SubType
        {
            Cap, Helmet, Circlet, Hat, Hood, Mask
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }
        
        public Head(){
            _ArmorType = ArmorType.Head;
        }

        public Head(SubType subType, Material material){
            _SubType = subType;
            _Material = material;
            _ArmorType = ArmorType.Head;
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
                case SubType.Helmet:
                    Weight = 0.5f + (float)Math.Round(_Material.Weight/2.5, 1);
                    _WeightClass = WeightClass.Heavy;
                    break;
                case SubType.Cap:
                    Weight = 0.3f + (float)Math.Round(_Material.Weight/3.5, 1);
                    _WeightClass = WeightClass.Medium;
                    break;
                default:
                    Weight = 0.1f + (float)Math.Round(_Material.Weight/4.5, 1);
                    _WeightClass = WeightClass.Light;
                    break;
            }
        }

        [Button("Generate New Head")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(SubType)).Length);
            _Material = RandomItemGenerator.GenerateMaterial(true, false);
            _ArmorType = ArmorType.Head;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            SetWeightAndArmorClass();
            GenerateName(_SubType.ToString());
        }
    }
}