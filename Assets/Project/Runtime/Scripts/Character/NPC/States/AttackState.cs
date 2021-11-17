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
            
            //If the target is visible, then attack.
            if(manager.FOV.VisibleTiles.Contains(GameManager.instance.Characters[manager.Target.gameObject]))
            {
                AttackAction.Attack(manager.IsRanged, manager.Target.gameObject); // Attack the target.
            }
        }

        /// <summary> Called when the state is exited. </summary>
        public void Exit()
        {
    
        }

        /// <summary> Called when the state is updated. </summary>
        public void Update()
        {
            //If the target is visible, then attack.
            if(manager.FOV.VisibleTiles.Contains(GameManager.instance.Characters[manager.Target.gameObject]))
            {
                AttackAction.Attack(manager.IsRanged, manager.Target.gameObject);
            }

            //If the target isn't null
            if(manager.Target != null)
            {
                float distance = Vector2.Distance(manager.Target.position, manager.transform.position); // Get the distance between the target and the NPC.

                //If the distance is greater than equal the attack range, then change to the chase state.
                if(distance >= manager.AttackRange && manager.IsRanged || !manager.FOV.VisibleTiles.Contains(GameManager.instance.Characters[manager.Target.gameObject]) || distance >= 1.5f && !manager.IsRanged)
                {
                    manager.ChangeState(new PathState()); // Change to the path state.
                }
            }
            //else the target is null
            else
            {
                manager.ChangeState(new IdleState()); // Change to the idle state.
            }
        }
    }
}