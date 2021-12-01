using RLSKTD.General.Item.Helpers;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.WeaponSubcategories{
    /// <summary> This is the TwoHanded class </summary>
    [System.Serializable]
    public class TwoHanded : Weapon
    {
        public enum SubType
        {
            Halberd, Greatsword, Claymore, Greatclub, Quarterstaff,
            Longspear, Battleaxe, Lance, Trident, Warhammer,
            Maul, Spear,
        }

        [OdinSerialize]private SubType subType;

        public SubType _SubType { get => subType; set => subType = value; } 

        public TwoHanded(string name, string description, Material.MaterialEnum material, Quality.QualityEnum quality,
         float weight, bool isIdentified, int worth, UnityEngine.Color color, int dice, int damage, DamageType damageType, WeaponType weaponType, SubType subType) : 
         base(name, description, material, quality, weight, isIdentified, worth, color, dice, damage, weaponType, damageType)
        {
            Name = name;
            Description = description;
            _Material = material;
            _Quality = quality;
            Weight = weight;
            IsIdentified = isIdentified;
            Value = worth;
            Color = color;
            Dice = dice;
            Damage = damage;
            _DamageType = damageType;
            _WeaponType = weaponType;
            _SubType = subType;
        }
    }
}