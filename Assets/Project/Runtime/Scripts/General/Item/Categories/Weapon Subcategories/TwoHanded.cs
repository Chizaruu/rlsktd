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

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                switch (subType)
                {
                    case SubType.Halberd:
                        _DamageType = DamageType.Slashing;
                        Weight = 2.3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Greatsword:
                        _DamageType = DamageType.Slashing;
                        Weight = 2.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Claymore:
                        _DamageType = DamageType.Slashing;
                        Weight = 2.35f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Greatclub:
                        _DamageType = DamageType.Bludgeoning;
                        Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Quarterstaff:
                        _DamageType = DamageType.Bludgeoning;
                        Weight = 2.25f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Longspear:
                        _DamageType = DamageType.Piercing;
                        Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Battleaxe:
                        _DamageType = DamageType.Slashing;
                        Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Lance:
                        _DamageType = DamageType.Piercing;
                        Weight = 3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Trident:
                        _DamageType = DamageType.Piercing;
                        Weight = 2.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Warhammer:
                        _DamageType = DamageType.Bludgeoning;
                        Weight = 2.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Maul:
                        _DamageType = DamageType.Bludgeoning;
                        Weight = 2.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    default: 
                        _DamageType = DamageType.Bludgeoning;
                        Weight = 1000f;
                        break;
                }                 
            }
        }

    }
}