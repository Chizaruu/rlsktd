using RLSKTD.General.Item.Helpers;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories{
    /// <summary> This is the weapon class </summary>
    [System.Serializable]
    public class Weapon : Item
    {
        public enum WeaponType
        {
            One_Handed, Two_Handed, Shield, Ranged, Ammo,
        }

        public enum DamageType
        {
            Bludgeoning, Piercing, Slashing,
        }

        [OdinSerialize]private int damage;
        [OdinSerialize]private WeaponType weaponType;
        [OdinSerialize]private DamageType damageType;

        public Weapon(string name, string description, Material.MaterialType materialType, Quality.QualityEnum quality, Weight.WeightEnum weightClass,
         float weight, bool isIdentified, int worth, UnityEngine.Color color, int damage, WeaponType weaponType, DamageType damageType) : base(name, description, materialType, quality, weightClass, weight, isIdentified, worth, color)
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
            _WeaponType = weaponType;
            _DamageType = damageType;
        }

        public int Damage { get => damage; set => damage = value; }
        public WeaponType _WeaponType { get => weaponType; set => weaponType = value; } 
        public DamageType _DamageType { get => damageType; set => damageType = value; }
    }
}