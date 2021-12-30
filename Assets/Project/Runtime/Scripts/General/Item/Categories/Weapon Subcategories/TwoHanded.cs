using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.WeaponSubcategories{
    /// <summary> This is the TwoHanded class </summary>
    [System.Serializable]
    public class TwoHanded : Weapon
    {
        public enum SubType
        {
            Halberd, Greatsword, Claymore, Greatclub, Quarterstaff,
            Longspear, Battleaxe, Lance, Trident, Warhammer,
            Maul,
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector, ReadOnly]public SubType _SubType { get => subType; set => subType = value; }

        public TwoHanded(){
            _Type = Type.Weapon;
            _WeaponType = WeaponType.TwoHanded;
        }

        public TwoHanded(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _Type = Type.Weapon;
            _WeaponType = WeaponType.TwoHanded;
            SetDamageType();
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
                case SubType.Halberd:
                    Weight = 2.3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Greatsword:
                    Weight = 2.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Claymore:
                    Weight = 2.35f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Greatclub:
                case SubType.Warhammer:
                case SubType.Longspear:
                case SubType.Battleaxe:
                    Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Quarterstaff:
                    Weight = 2.25f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Lance:
                    Weight = 3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Trident:
                    Weight = 2.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                case SubType.Maul:
                    Weight = 2.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
                default: 
                    Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                    break;
            }
        }

        private void SetDamageType(){
            switch (subType)
            {
                case SubType.Halberd:
                case SubType.Greatsword:
                case SubType.Claymore:
                case SubType.Battleaxe:
                    _DamageType = DamageType.Slashing;
                    break;
                case SubType.Longspear:
                case SubType.Lance:
                case SubType.Trident:
                    _DamageType = DamageType.Piercing;
                    break;
                default: 
                    _DamageType = DamageType.Bludgeoning;
                    break;
            }                 
        }

        [Button("Generate New TwoHanded")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, Enum.GetNames(typeof(SubType)).Length);
            _Material = (Material.MaterialEnum)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(Material.MaterialEnum)).Length);
            _Type = Type.Weapon;
            _WeaponType = WeaponType.TwoHanded;
            SetDamageType();
            GenerateQuality();
            GenerateDice();
            GenerateDamage();
            SetWeight();
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }
    }
}