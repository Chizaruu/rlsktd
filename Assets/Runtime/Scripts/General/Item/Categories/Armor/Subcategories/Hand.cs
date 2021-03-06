using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ArmorSubcategories{
    /// <summary> This is the Hand class </summary>
    [System.Serializable]
    public class Hand : Armor
    {
        public enum SubType
        {
            Gloves, Mittens, Gauntlets, Vambraces, Bracelet
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Hand(){
            _ArmorType = ArmorType.Hand;
        }

        public Hand(SubType subType, Material material){
            _SubType = subType;
            _Material = material;
            _ArmorType = ArmorType.Hand;
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
                case SubType.Gauntlets:
                    Weight = 0.7f + (float)Math.Round(_Material.Weight/2.5, 1);
                    _WeightClass = WeightClass.Heavy;
                    break;
                case SubType.Vambraces:
                    Weight = 0.35f + (float)Math.Round(_Material.Weight/3.5, 1);
                    _WeightClass = WeightClass.Medium;
                    break;
                case SubType.Gloves:
                    Weight = 0.5f + (float)Math.Round(_Material.Weight/3.5, 1);
                    _WeightClass = WeightClass.Medium;
                    break;
                default:
                    Weight = 0.15f + (float)Math.Round(_Material.Weight/4.5, 1);
                    _WeightClass = WeightClass.Light;
                    break;
            }
        }

        [Button("Generate New Hand")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(SubType)).Length);
            _Material = MaterialGenerator.Generate(true, false);
            _ArmorType = ArmorType.Hand;
            GenerateQuality();
            GenerateProtectionValue();
            GenerateDefensiveValue();
            SetWeightAndArmorClass();
            GenerateName(_SubType.ToString());
        }
    }
}