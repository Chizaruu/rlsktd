using RLSKTD.General.Item.Helpers;

namespace RLSKTD.General.Item.Categories.WeaponSubcategories{
    /// <summary> This is the Ranged class </summary>
    [System.Serializable]
    public class Ranged : Weapon
    {
        public enum SubType
        {
            Crossbow, Bow , Pistol , Rifle, Shotgun,
            Lasergun, Dart , Sling , Blowgun
        }

        private SubType subType;

        public SubType _SubType { get => subType; set => subType = value; } 

        public Ranged(string name, string description, Material.MaterialType materialType, Quality.QualityEnum quality, Weight.WeightEnum weightClass,
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