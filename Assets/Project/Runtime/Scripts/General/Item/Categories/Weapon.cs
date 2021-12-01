using RLSKTD.General.Item.Helpers;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories{
    /// <summary> This is the weapon class </summary>
    [System.Serializable]
    public class Weapon : Item
    {
        public enum WeaponType
        {
            OneHanded, TwoHanded, Shield, Ranged, Ammo,
        }

        public enum DamageType
        {
            Bludgeoning, Piercing, Slashing,
        }

        [OdinSerialize]private int dice;
        [OdinSerialize]private int damage;
        [OdinSerialize]private WeaponType weaponType;
        [OdinSerialize]private DamageType damageType;

        public int Dice { get => dice; set => dice = value; }
        public int Damage { get => damage; set => damage = value; }
        public WeaponType _WeaponType { get => weaponType; set => weaponType = value; } 
        public DamageType _DamageType { get => damageType; set => damageType = value; }

        public Weapon(string name, string description, Material.MaterialEnum material, Quality.QualityEnum quality, float weight, bool isIdentified, int value, UnityEngine.Color color, 
        int dice, int damage, WeaponType weaponType, DamageType damageType) : base(name, description, material, quality, weight, isIdentified, value, color)
        {
            Name = name;
            Description = description;
            _Material = material;
            _Quality = quality;
            Weight = weight;
            IsIdentified = isIdentified;
            Value = value;
            Color = color;
            Dice = dice;
            Damage = damage;
            _WeaponType = weaponType;
            _DamageType = damageType;
        }
    }
}