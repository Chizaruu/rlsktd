using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories{
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

        [OdinSerialize, UnityEngine.HideInInspector]private int dice;
        [OdinSerialize, UnityEngine.HideInInspector]private int damage;
        [OdinSerialize, UnityEngine.HideInInspector]private WeaponType weaponType;
        [OdinSerialize, UnityEngine.HideInInspector]private DamageType damageType;

        [ShowInInspector, ReadOnly]public int Dice { get => dice; set => dice = value; }
        [ShowInInspector, ReadOnly]public int Damage { get => damage; set => damage = value; }
        [ShowInInspector, ReadOnly]public WeaponType _WeaponType { get => weaponType; set => weaponType = value; } 
        [ShowInInspector, ReadOnly]public DamageType _DamageType { get => damageType; set => damageType = value; }

        /// <summary> Constructor for the Weapon class. </summary>
        public Weapon(){}

        /// <summary> Constructor for the Weapon class. </summary>

        public Weapon(string name, string description, int weight, int value, int dice, int damage, WeaponType weaponType, DamageType damageType)
        {
            _Name = name;
            _Description = description;
            _Weight = weight;
            _Value = value;
            this.dice = dice;
            this.damage = damage;
            this._WeaponType = weaponType;
            this._DamageType = damageType;
        }
    }
}