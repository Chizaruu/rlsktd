using System.Collections.Generic;
using UnityEngine;
using RLSKTD.Map;

/// <summary> NPC States Live Here </summary>
namespace RLSKTD.Character.NPC.State
{
    /// <summary> NPC Path State is the state that the NPC will be in when it is following a path </summary>
    public class PathState : IState
    {
        private NPCStateManager manager; // The NPC State Manager

        private Stack<Vector3Int> path; // The path the NPC will follow

        private Vector3 destination; // The destination the NPC will move to

        private bool canMove; // If the NPC can move

        /// <summary> Called when the Path state is entered </summary>
        public void Enter(NPCStateManager manager)
        {
            this.manager = manager; // Set the NPC State Manager

            path = manager.AStar.Algorithm(manager.transform.position, manager.Target.position);// Get the path the NPC will follow

            destination = path.Pop() + new Vector3(0.5f, 0.5f, 0); // Get the destination the NPC will move to

            canMove = true; // Set the canMove bool to true

            for(int i = 0; i < GameManager.instance.Characters.Count; i++) 
            {
                // If the NPC is colliding with another NPC
                if(GameManager.instance.Characters[i].transform.position.Equals(destination))
                {
                    canMove = false; // Set canMove to false
                }
            }
            // If the NPC can move
            if(canMove)
            {
                manager.transform.position = destination; // Move the NPC to the destination
            }
        }

        /// <summary> Called when the Path state is exited </summary>
        public void Exit()
        {
            
        }

        /// <summary> Called when the Path state is updated </summary>
        public void Update()
        {
            // If the path isn't empty
            if(path != null) 
            {
                float distance = Vector2.Distance(manager.Target.position, manager.transform.position); // Get the distance between the NPC and the target
                manager.TargetWorldPos = MapManager.instance.floorMap.WorldToCell(manager.Target.position); // Get the target's world position
                
                // If the NPC is ranged and the distance is less than equal the NPC's range and the target is visible
                if(distance <= manager.AttackRange && manager.IsRanged && manager.FOV.VisibleTiles.Contains(manager.TargetWorldPos))
                {
                    manager.ChangeState(new AttackState()); // Change the state to attack
                }
                // If the NPC is melee and the distance is less than equal the NPC's range and the target is visible
                else if(distance <= manager.AttackRange && !manager.IsRanged && manager.FOV.VisibleTiles.Contains(manager.TargetWorldPos))
                {
                    manager.ChangeState(new AttackState()); // Change the state to attack
                }
                else
                {
                    path = manager.AStar.Algorithm(manager.transform.position, manager.Target.position); // Get the path the NPC will follow

                    destination = path.Pop() + new Vector3(0.5f, 0.5f, 0); // Get the destination the NPC will move to

                    canMove = true; // Set the canMove bool to true

                    // If the NPC is colliding with another NPC
                    for(int i = 0; i < GameManager.instance.Characters.Count; i++)
                    {
                        // If the NPC is colliding with another NPC
                        if(GameManager.instance.Characters[i].transform.position.Equals(destination))
                        {
                            canMove = false; // Set canMove to false
                        }
                    }
                    // If the NPC can move and the destination isn't the same as the Target
                    if(destination != manager.Target.position && canMove)
                    {
                        manager.transform.position = destination; // Move the NPC to the destination
                    }
                }
            }
            // If the path is empty
            else
            {
                manager.ChangeState(new IdleState()); // Change the state to idle
            }
        }
    }
}