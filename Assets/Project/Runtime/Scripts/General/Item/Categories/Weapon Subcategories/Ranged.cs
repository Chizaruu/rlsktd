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
            _Type = Type.Weapon;
            _WeaponType = WeaponType.Ranged;
        }

        public Ranged(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _Type = Type.Weapon;
            _WeaponType = WeaponType.Ranged;
            _DamageType = DamageType.Bludgeoning;
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
                    Weight = 1.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Bow:
                    Weight = 1.15f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Pistol:
                    Weight = 0.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Rifle:
                    Weight = 1.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Shotgun:
                    Weight = 2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Lasergun:
                    Weight = 0.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Sling:
                    Weight = 0.3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Blowgun:
                    Weight = 0.15f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                default:
                    Weight = 1f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
            }
        }


    }
}