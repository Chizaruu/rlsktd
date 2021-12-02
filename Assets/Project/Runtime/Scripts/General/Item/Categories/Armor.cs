using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories{
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
        [ShowInInspector, ReadOnly]public ArmorType _ArmorType { get => armorType; set => armorType = value; } 
        [ShowInInspector, ReadOnly]public WeightClass _WeightClass { get => weightClass; set => weightClass = value; }
    }
}