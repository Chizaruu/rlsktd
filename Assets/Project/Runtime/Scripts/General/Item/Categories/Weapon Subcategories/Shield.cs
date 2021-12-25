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

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                switch (subType)
                {
                    case SubType.Buckler:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 0.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                        break;
                    case SubType.Shield:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 1.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                        break;
                    case SubType.Towershield:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 1.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/2.5, 1);
                        break;
                    default: 
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 1000f;
                        break;
                }
            }
        }

    }
}