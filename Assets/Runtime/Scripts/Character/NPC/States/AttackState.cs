using UnityEngine;
using RLSKTD.Map;
using RLSKTD.Character.Actions;

/// <summary> NPC States Live Here </summary>
namespace RLSKTD.Character.NPC.State
{
    /// <summary> NPC Attack State is the state where the NPC is attacking the player. </summary>
    public class AttackState : IState
    {
        private NPCStateManager manager; // The NPC State Manager.

        /// <summary> Called when the state is entered. </summary>
        public void Enter(NPCStateManager manager)
        {
            this.manager = manager; // Set the NPC State Manager.
            
            AttackAction.Attack(manager.IsRanged, manager.Target.gameObject); // Attack the target.
        }

        /// <summary> Called when the state is exited. </summary>
        public void Exit()
        {
    
        }

        /// <summary> Called when the state is updated. </summary>
        public void Update()
        {
            switch (manager.Target)
            {
                case null:
                    manager.ChangeState(new IdleState()); // If the target is null, then change the state to idle.
                    break;
                case Transform target:
                    switch (manager.Target.GetComponent<Foundation>().IsDead)
                    {
                        case true:
                            manager.Target = null; // If the target is dead, then set the target to null.
                            manager.ChangeState(new IdleState()); // Change to the idle state.
                            break;
                        case false:
                            float distance = Vector2.Distance(manager.Target.position, manager.transform.position); // Get the distance between the target and the NPC.

                            //If the target is visible and in manager.AttackRange, then attack.
                            if (manager.FOV.VisibleTiles.Contains(GameManager.instance.Characters[manager.Target.gameObject]) && distance <= manager.AttackRange)
                            {
                                AttackAction.Attack(manager.IsRanged, manager.Target.gameObject); // Attack the target.
                            }
                            else
                            {
                                manager.ChangeState(new PathState()); // If the target is not in range and is not visible, then change to the path state.
                            }
                            break;
                    }              
                    break;
            }
        }
    }
}