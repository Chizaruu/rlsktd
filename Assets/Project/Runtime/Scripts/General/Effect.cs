using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RLSKTD.General
{   
    /// <summary> Effect contains all the information about an effect. </summary>
    [System.Serializable]
    public class Effect
    {
        [SerializeField]private string name, description; // Name and description of the effect.

        [SerializeField]private int rollAmount, damage; // Amount of dice to roll and damage of the effect. 

        [SerializeField]private bool isSkill, isSpell, isAnimated;// Is the effect a skill, spell, or animated effect.
    }
}