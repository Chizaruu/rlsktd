using RLSKTD.General.Item.Helpers;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.WeaponSubcategories{
    /// <summary> This is the Shield class </summary>
    [System.Serializable]
    public class Shield : Weapon
    {
        public enum SubType
        {
            Buckler, Shield, Towershield,
        }

        [OdinSerialize]private SubType subType;

        public SubType _SubType { get => subType; set => subType = value; } 

        public Shield(string name, string description, Material.MaterialEnum material, Quality.QualityEnum quality,
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