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
    }
}