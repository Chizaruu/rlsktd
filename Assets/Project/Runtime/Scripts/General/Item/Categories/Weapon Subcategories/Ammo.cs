using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.WeaponSubcategories{
    /// <summary> This is the Ammo class </summary>
    [System.Serializable]
    public class Ammo : Weapon
    {
        public enum SubType
        {
            Arrow, Bullet , Bolt , Energycell, Stone,
            Needle, Dart
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                Weight = 0.1f;
                switch (subType)
                {
                    case SubType.Stone:
                        _DamageType = Weapon.DamageType.Bludgeoning;
                        break;
                    default:
                        _DamageType = Weapon.DamageType.Piercing;
                        break;
                }
            }
        }

    }
}