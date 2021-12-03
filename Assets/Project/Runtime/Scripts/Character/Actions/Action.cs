using UnityEngine;

/// <summary> Actions are the basic building blocks of the character. </summary>
namespace RLSKTD.Character
{
    /// <summary> Action is the base class for all actions. </summary>
    public class Action : MonoBehaviour {
        /// <summary> The action's name. </summary>
        public string Name;
        /// <summary> The action's description. </summary>
        public string Description;
        /// <summary> The action's icon. </summary>
        public Sprite Icon;
    }  
}