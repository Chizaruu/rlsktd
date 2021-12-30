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

        [ShowInInspector]public SubType _SubType { get => subType; set => subType = value; }

        public Shield(){}

        public Shield(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _Type = Type.Weapon;
            _WeaponType = WeaponType.Shield;
            _DamageType = DamageType.Bludgeoning;
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
                    Weight = 0.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                    break;
                case SubType.Shield:
                    Weight = 1.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                    break;
                case SubType.Towershield:
                    Weight = 1.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                    break;
                default: 
                    Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                    break;
            }
        }
    }
}