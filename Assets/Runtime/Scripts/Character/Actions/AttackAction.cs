using UnityEngine;

/// <summary> Actions are the basic building blocks of the character. </summary>
namespace RLSKTD.Character.Actions {

    /// <summary> AttackAction actions are actions that can be used to attack.</summary>
    public class AttackAction : Action {

        /// <summary> Start the action by checking if the attack is ranged or melee. </summary>
        public static void Attack(bool isRanged, GameObject target)
        {
            // If the attack is ranged, use the ranged attack action.
            if(isRanged)
            {
                Shoot(target);
            }
            // If the attack is melee, use the melee attack action.
            else
            {
                Melee(target);
            }
        }
        /// <summary> Ranged attack action.</summary>
        private static void Shoot(GameObject target)
        {
            target.GetComponent<Foundation>().Hp -= 1;
            Debug.Log("Shooting!");
        }

        /// <summary> Melee attack action. </summary>
        private static void Melee(GameObject target)
        {
            target.GetComponent<Foundation>().Hp -= 2;
            Debug.Log("Meleeing!");
        }
    }
}

