using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories{
    public class Armor : Item{
        public enum ArmorType{
            Head, Back, Body, Hand, Waist, Foot, Neck, Finger, Ear
        }

        public enum WeightClass{
            Light, Medium, Heavy
        }

        [OdinSerialize, UnityEngine.HideInInspector]private int protectionValue;
        [OdinSerialize, UnityEngine.HideInInspector]private int defensiveValue;
        [OdinSerialize, UnityEngine.HideInInspector]private ArmorType armorType;
        [OdinSerialize, UnityEngine.HideInInspector]private WeightClass weightClass;

        [ShowInInspector, ReadOnly]public int ProtectionValue { get => protectionValue; set => protectionValue = value; }
        [ShowInInspector, ReadOnly]public int DefensiveValue { get => defensiveValue; set => defensiveValue = value; }
        [ShowInInspector, ReadOnly]public ArmorType _ArmorType
        {
            get => armorType; set
            {
                armorType = value;

                _Type = Type.Armor;
            }
        }
        [ShowInInspector, ReadOnly]public WeightClass _WeightClass { get => weightClass; set => weightClass = value; }

        public void GenerateProtectionValue(){
            ProtectionValue = UnityEngine.Random.Range(1, 6); //TODO: Add protection value generation from material and subtype
        }

        public void GenerateDefensiveValue(){
            DefensiveValue = UnityEngine.Random.Range(1, 6); //TODO: Add defensive value generation from material and subtype
        }
    }
}