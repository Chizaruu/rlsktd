using RLSKTD.General.Item.Helpers;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.WeaponSubcategories{
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
        
        [OdinSerialize]public SubType _SubType
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
                        break;
                    case SubType.Longsword:
                        _DamageType = DamageType.Slashing;
                        break;
                    case SubType.Dagger:
                        _DamageType = DamageType.Piercing;
                        break;
                    case SubType.Scimitar:
                        _DamageType = DamageType.Slashing;
                        break;
                    case SubType.Cutlass:
                        _DamageType = DamageType.Slashing;
                        break;
                    case SubType.Rapier:
                        _DamageType = DamageType.Piercing;
                        break;
                    case SubType.Kris:
                        _DamageType = DamageType.Piercing;
                        break;
                    case SubType.Saber:
                        _DamageType = DamageType.Slashing;
                        break;
                    case SubType.Club:
                        _DamageType = DamageType.Bludgeoning;
                        break;
                    case SubType.Mace:
                        _DamageType = DamageType.Bludgeoning;
                        break;
                    case SubType.Shortspear:
                        _DamageType = DamageType.Piercing;
                        break;
                    case SubType.Sickle:
                        _DamageType = DamageType.Slashing;
                        break;
                    case SubType.Morningstar:
                        _DamageType = DamageType.Bludgeoning;
                        break;
                    case SubType.Whip:
                        _DamageType = DamageType.Slashing;
                        break;
                    case SubType.Flail:
                        _DamageType = DamageType.Bludgeoning;
                        break;
                    case SubType.Handaxe:
                        _DamageType = DamageType.Slashing;
                        break;
                }
            }
        }

        public OneHanded(string name, string description, Material.MaterialEnum material, Quality.QualityEnum quality,
         float weight, bool isIdentified, int value, UnityEngine.Color color, int dice, int damage, DamageType damageType, WeaponType weaponType, SubType subType) : 
         base(name, description, material, quality, weight, isIdentified, value, color, dice, damage, weaponType, damageType)
        {
            _WeaponType = WeaponType.OneHanded;
            _Material = material;
            Color = color;
            _SubType = subType;
            Weight = weight;
            _Quality = quality;
            Dice = dice;
            Damage = damage;  
            Value = value;    
            Description = description;
            Name = name;
            IsIdentified = isIdentified;
        }
    }
}