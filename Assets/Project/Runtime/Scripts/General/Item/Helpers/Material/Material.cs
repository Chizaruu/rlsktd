using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers{
    /*
        The plan is at some point to have materials referenceable through scriptable objects. This will allow for more flexibility in the future and stop the need for hard coding materials.
    */

    [System.Serializable]
    public class Material {
        public enum Type {
            Soft, Hard  // Ambiguous type will be included when more materials are added that require it.
        }

        public enum Rarity{
            Common, Uncommon, Rare, Epic
        }

        // Variables
        [OdinSerialize, UnityEngine.HideInInspector]private Type type;

        [OdinSerialize, UnityEngine.HideInInspector]private Rarity rarity;
        
        [OdinSerialize, UnityEngine.HideInInspector]private string name;

        [OdinSerialize, UnityEngine.HideInInspector]private string description;

        [OdinSerialize, UnityEngine.HideInInspector]private float weight;

        [OdinSerialize, UnityEngine.HideInInspector]private UnityEngine.Color color;

        // Getters and Setters
        [ShowInInspector, ReadOnly]public Type _Type { get => type; set => type = value; }

        [ShowInInspector, ReadOnly]public Rarity _Rarity { get => rarity; set => rarity = value; }

        [ShowInInspector, ReadOnly]public string Name { get => name; set => name = value; }

        [ShowInInspector, ReadOnly]public string Description { get => description; set => description = value; }

        [ShowInInspector, ReadOnly]public float Weight { get => weight; set => weight = value; }
        
        [ShowInInspector, ReadOnly]public UnityEngine.Color Color { get => color; set => color = value; }
    }
}