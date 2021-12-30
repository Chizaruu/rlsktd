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

        [OdinSerialize, UnityEngine.HideInInspector]private WeaponType weaponType;
        [OdinSerialize, UnityEngine.HideInInspector]private DamageType damageType;
        [OdinSerialize, UnityEngine.HideInInspector]private int dice;
        [OdinSerialize, UnityEngine.HideInInspector]private int damage;

        [ShowInInspector, ReadOnly]public WeaponType _WeaponType { get => weaponType; set => weaponType = value; } 
        [ShowInInspector, ReadOnly]public DamageType _DamageType { get => damageType; set => damageType = value; }
        [ShowInInspector, ReadOnly]public int Dice { get => dice; set => dice = value; }
        [ShowInInspector, ReadOnly]public int Damage { get => damage; set => damage = value; }

        
        public void GenerateDice(){
            //Generate dice based on the quality, and type of weapon using switch case
            switch (weaponType){
                case WeaponType.Ammo:
                case WeaponType.Shield:
                    Dice = 1;
                    break;
                default: 
                    switch (_Quality)
                    {
                        case Quality.Normal:
                        case Quality.Superior:
                        case Quality.Exceptional:
                            Dice = 2;
                            break;
                        case Quality.Unique:
                        case Quality.Legendary:
                            Dice = 3;
                            break;
                        default:
                            Dice = 1;
                            break;
                    }
                    break;
            }
        }

        public void GenerateDamage(){
            Damage = 1; //TODO: Change this to be based on the weapontype, subtype, material and quality
        }
    }
}