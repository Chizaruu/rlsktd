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

        /// <summary> Called when the Path state is entered </summary>
        public void Enter(NPCStateManager manager)
        {
            this.manager = manager; // Set the NPC State Manager

            path = manager.AStar.Algorithm(manager.transform.position, manager.Target.position);// Get the path the NPC will follow

            destination = path.Pop() + new Vector3(0.5f, 0.5f, 0); // Get the destination the NPC will move to
            //Debug.Log("Enter - Destination: " + MapManager.instance.floorMap.WorldToCell(destination));
            // If the NPC is colliding with another character
            if(!GameManager.instance.Characters.ContainsValue(MapManager.instance.floorMap.WorldToCell(destination)))
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

            //Check if the path is empty
            switch (path)
            {
                case null: // If the path is null
                    manager.ChangeState(new IdleState()); // Change the state to Idle
                    break;
                case Stack<Vector3Int> _: // If the path is not null
                    float distance = Vector2.Distance(manager.Target.position, manager.transform.position); // Get the distance between the NPC and the target

                    switch (manager.FOV.VisibleTiles.Contains(GameManager.instance.Characters[manager.Target.gameObject]) && distance <= manager.AttackRange)
                    {
                        case true: // If the target is visible
                            manager.ChangeState(new AttackState()); // Change the state to Attack
                            break;
                        case false: // If the target is not visible
                            path = manager.AStar.Algorithm(manager.transform.position, manager.Target.position); // Get the path the NPC will follow

                            destination = path.Pop() + new Vector3(0.5f, 0.5f, 0); // Get the destination the NPC will move to
                            //Debug.Log("Update - Destination: " + MapManager.instance.floorMap.WorldToCell(destination));
                            // If the NPC is colliding with another character
                            if(!GameManager.instance.Characters.ContainsValue(MapManager.instance.floorMap.WorldToCell(destination)))
                            {
                                manager.transform.position = destination; // Move the NPC to the destination
                            }
                            break;
                    }
                    break;
            }
        }
    }
}