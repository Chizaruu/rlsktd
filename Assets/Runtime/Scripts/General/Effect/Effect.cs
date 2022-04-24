using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General
{   
    /// <summary> Effect contains all the information about an effect. </summary>
    [System.Serializable]
    public class Effect
    {
        public enum Type{
            None, Buff, Debuff, Damage, Utility
        }

        [OdinSerialize, UnityEngine.HideInInspector]private Type type; // Type of the effect.

        [OdinSerialize, UnityEngine.HideInInspector]private string name, description; // Name and description of the effect.

        [OdinSerialize, UnityEngine.HideInInspector]private bool isAnimated; // Is the effect animated?

        [OdinSerialize, UnityEngine.HideInInspector]private int duration; // Duration of the effect.

        [ShowInInspector, ReadOnly]public Type _Type { get => type; set => type = value; }
        [ShowInInspector, ReadOnly]public string Name { get => name; set => name = value; }
        [ShowInInspector, ReadOnly]public string Description { get => description; set => description = value; }
        [ShowInInspector, ReadOnly]public bool IsAnimated { get => isAnimated; set => isAnimated = value; }
        [ShowInInspector, ReadOnly]public int Duration { get => duration; set => duration = value; }
    }
}