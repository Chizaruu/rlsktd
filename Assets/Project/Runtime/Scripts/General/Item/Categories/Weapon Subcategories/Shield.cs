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

        public Shield(string name, string description, Material.MaterialType materialType, Quality.QualityEnum quality, Weight.WeightEnum weightClass,
         float weight, bool isIdentified, int worth, UnityEngine.Color color, int damage, DamageType damageType, WeaponType weaponType, SubType subType) : 
         base(name, description, materialType, quality, weightClass, weight, isIdentified, worth, color, damage, weaponType, damageType)
        {
            Name = name;
            Description = description;
            _MaterialType = materialType;
            _Quality = quality;
            _WeightClass = weightClass;
            Weight = weight;
            IsIdentified = isIdentified;
            Worth = worth;
            Color = color;
            Damage = damage;
            _DamageType = damageType;
            _WeaponType = weaponType;
            _SubType = subType;
        }
    }
}