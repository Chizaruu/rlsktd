using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.WeaponSubcategories{
    /// <summary> This is the Ranged class </summary>
    [System.Serializable]
    public class Ranged : Weapon
    {
        public enum SubType
        {
            Crossbow, Bow , Pistol , Rifle, Shotgun,
            Lasergun, Sling , Blowgun
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector, ReadOnly]public SubType _SubType { get => subType; set => subType = value; }

        public Ranged(){
            _WeaponType = WeaponType.Ranged;
        }

        public Ranged(SubType subType, Material material){
            _SubType = subType;
            _Material = material;
            _WeaponType = WeaponType.Ranged;
            GenerateQuality();
            GenerateDice();
            GenerateDamage();
            SetWeight();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        private void SetWeight()
        {
            switch (subType){
                case SubType.Crossbow:
                    Weight = 1.2f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Bow:
                    Weight = 1.15f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Pistol:
                    Weight = 0.5f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Rifle:
                    Weight = 1.7f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Shotgun:
                    Weight = 2f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Lasergun:
                    Weight = 0.4f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Sling:
                    Weight = 0.3f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Blowgun:
                    Weight = 0.15f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                default:
                    Weight = 1f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
            }
        }

        [Button("Generate New Ranged")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(SubType)).Length);
            _Material = RandomItemGenerator.GenerateMaterial(false, true);
            _WeaponType = WeaponType.Ranged;
            GenerateQuality();
            GenerateDice();
            GenerateDamage();
            SetWeight();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }
    }
}