using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.WeaponSubcategories{
    /// <summary> This is the Shield class </summary>
    [System.Serializable]
    public class Shield : Weapon
    {
        public enum SubType
        {
            Buckler, Shield, Towershield,
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector, ReadOnly]public SubType _SubType { get => subType; set => subType = value; }

        public Shield(){
            _WeaponType = WeaponType.Shield;
        }

        public Shield(SubType subType, Material material){
            _SubType = subType;
            _Material = material;
            _WeaponType = WeaponType.Shield;
            GenerateQuality();
            GenerateDice();
            GenerateDamage();
            SetWeight();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        private void SetWeight(){
            switch (subType)
            {
                case SubType.Buckler:
                    Weight = 0.7f + (float)Math.Round(_Material.Weight/2.5, 1);
                    break;
                case SubType.Shield:
                    Weight = 1.2f + (float)Math.Round(_Material.Weight/2.5, 1);
                    break;
                case SubType.Towershield:
                    Weight = 1.7f + (float)Math.Round(_Material.Weight/2.5, 1);
                    break;
                default: 
                    Weight = 1.5f + (float)Math.Round(_Material.Weight/2.5, 1);
                    break;
            }
        }

        [Button("Generate New Shield")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(SubType)).Length);
            _Material = RandomItemGenerator.GenerateMaterial(false, true);
            _WeaponType = WeaponType.OneHanded;
            GenerateQuality();
            GenerateDice();
            GenerateDamage();
            SetWeight();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }
    }
}