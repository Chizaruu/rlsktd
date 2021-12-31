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

        [ShowInInspector, ReadOnly]public SubType _SubType { get => subType; set => subType = value; }

        public Ammo(){
            _WeaponType = WeaponType.Ammo;
        }

        public Ammo(SubType subType, Material.MaterialEnum material){
            _SubType = subType;
            _Material = material;
            _WeaponType = WeaponType.Ammo;
            GenerateQuality();
            SetDamageType();
            GenerateDice();
            GenerateDamage();
            Weight = 0.1f;
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }

        private void SetDamageType(){
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

        [Button("Generate New Ammo")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _Material = (Material.MaterialEnum)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(Material.MaterialEnum)).Length);
            _WeaponType = WeaponType.Ammo;
            SetDamageType();
            GenerateQuality();
            GenerateDice();
            GenerateDamage();
            Weight = 0.1f;
            GenerateName(subType.ToString());
            //GenerateDescription(isArtifact);
        }
    }
}