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

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                switch (subType)
                {
                    case SubType.Crossbow:
                        _DamageType = DamageType.Piercing;
                        _Weight = 1.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Bow:
                        _DamageType = DamageType.Piercing;
                        _Weight = 1.15f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Pistol:
                        _DamageType = DamageType.Piercing;
                        _Weight = 0.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Rifle:
                        _DamageType = DamageType.Piercing;
                        _Weight = 1.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Shotgun:
                        _DamageType = DamageType.Piercing;
                        _Weight = 2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Lasergun:
                        _DamageType = DamageType.Piercing;
                        _Weight = 0.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Sling:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 0.3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Blowgun:
                        _DamageType = DamageType.Piercing;
                        _Weight = 0.15f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
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