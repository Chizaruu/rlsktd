using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;

namespace RLSKTD.General.ItemCategories.WeaponSubcategories{
    /// <summary> This is the OneHanded class </summary>
    [System.Serializable]
    public class OneHanded : Weapon
    {
        public enum SubType
        {
            Shortsword, Longsword, Dagger, Scimitar, Cutlass,
            Rapier, Kris, Saber, Club, Mace, Shortspear,
            Sickle , Morningstar , Whip, Flail, Handaxe,
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;
        
        [ShowInInspector]public SubType _SubType
        {
            get
            {
                return subType;
            }

            set
            {
                subType = value;

                switch (subType)
                {
                    case SubType.Shortsword:
                        _DamageType = DamageType.Slashing;
                        _Weight = 1.1f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Longsword:
                        _DamageType = DamageType.Slashing;
                        _Weight = 1.3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Dagger:
                        _DamageType = DamageType.Piercing;
                        _Weight = 0.3f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Scimitar:
                        _DamageType = DamageType.Slashing;
                        _Weight = 1.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Cutlass:
                        _DamageType = DamageType.Slashing;
                        _Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Rapier:
                        _DamageType = DamageType.Piercing;
                        _Weight = 1.0f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Kris:
                        _DamageType = DamageType.Piercing;
                        _Weight = 0.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Saber:
                        _DamageType = DamageType.Slashing;
                        _Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Club:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 1f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Mace:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 1.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Shortspear:
                        _DamageType = DamageType.Piercing;
                        _Weight = 1.1f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Sickle:
                        _DamageType = DamageType.Slashing;
                        _Weight = 0.4f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Morningstar:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 1.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Whip:
                        _DamageType = DamageType.Slashing;
                        _Weight = 0.5f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Flail:
                        _DamageType = DamageType.Bludgeoning;
                        _Weight = 1.7f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                    case SubType.Handaxe:
                        _DamageType = DamageType.Slashing;
                        _Weight = 1.2f + (float)Math.Round(Material.GetMaterialWeight(_Material)/3, 1);
                        break;
                }
            }
        }
    }
}