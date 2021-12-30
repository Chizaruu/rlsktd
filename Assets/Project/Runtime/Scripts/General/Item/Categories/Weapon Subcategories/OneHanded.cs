using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;

namespace RLSKTD.General.ItemCategories.WeaponSubcategories{
    /// <summary> This is the OneHanded class </summary>
    [System.Serializable]
    public class OneHanded : Weapon{
        public enum SubType
        {
            Shortsword, Longsword, Dagger, Scimitar, Cutlass,
            Rapier, Kris, Saber, Club, Mace, Shortspear,
            Sickle , Morningstar , Whip, Flail, Handaxe,
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;
        
        [ShowInInspector, ReadOnly]public SubType _SubType { get => subType; set => subType = value; }
    
        public OneHanded(){
            _Type = Type.Weapon;
            _WeaponType = WeaponType.OneHanded;
        }

        public OneHanded(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _Type = Type.Weapon;
            _WeaponType = WeaponType.OneHanded;
            GenerateQuality();
            SetDamageType();
            GenerateDice();
            GenerateDamage();
            SetWeight();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        private void SetWeight()
        {
            switch(subType){
                case SubType.Scimitar:
                case SubType.Flail:
                    Weight = 1.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Cutlass:
                case SubType.Saber:
                case SubType.Morningstar:
                    Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Kris:
                case SubType.Whip:
                    Weight = 0.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Mace:
                case SubType.Handaxe:
                case SubType.Longsword:
                    Weight = 1.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Sickle:
                case SubType.Dagger:
                    Weight = 0.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                default:
                    Weight = 1.1f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
            }
        }
    
        private void SetDamageType(){
            switch(subType){
                case SubType.Dagger:
                case SubType.Rapier:
                case SubType.Shortspear:
                    _DamageType = DamageType.Piercing;
                    break;
                case SubType.Club:
                case SubType.Mace:
                case SubType.Morningstar:
                    _DamageType = DamageType.Bludgeoning;
                    break;
                default:
                    _DamageType = DamageType.Slashing;
                    break;
            }
        }
    }
}