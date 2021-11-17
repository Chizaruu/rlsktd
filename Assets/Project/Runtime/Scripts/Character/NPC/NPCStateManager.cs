using UnityEngine;
using RLSKTD.Character.NPC.State;
using RLSKTD.AI.Pathfinding;
using Sirenix.Serialization;
using Sirenix.OdinInspector;

/// <summary> NPC Stuff Live Here </summary>
namespace RLSKTD.Character.NPC
{
    [RequireComponent(typeof(AStar), typeof(FOV))]
    /// <summary> NPC State Manager controls the NPC's state </summary>
    public class NPCStateManager : SerializedMonoBehaviour
    {
        /// <summary> Current NPC State </summary>
        [OdinSerialize]private IState currentState;

        /// <summary> NPCs target </summary>
        [OdinSerialize]private Transform target;

        /// <summary> Is the NPC aggressive </summary>
        [OdinSerialize]private bool isAggressive;

        /// <summary> Is the NPC ranged </summary>
        [OdinSerialize]private bool isRanged; 

        /// <summary> The NPC's attack range </summary>
        [OdinSerialize]private float attackRange = 1.5f;

        [OdinSerialize]private AStar aStar;
        [OdinSerialize]private FOV fov;

        public Transform Target { get => target; set => target = value; }
        public bool IsAggressive { get => isAggressive; set => isAggressive = value; }
        public bool IsRanged { get => isRanged; set => isRanged = value; }
        public float AttackRange { get => attackRange; set => attackRange = value; }

        public AStar AStar { get => aStar; }
        public FOV FOV { get => fov;}

        /// <summary> Initialize the NPC State Manager </summary>
        private void Start() {
            aStar = GetComponent<AStar>();
            fov = GetComponent<FOV>();
            ChangeState(new IdleState());
        }

        /// <summary> Update the Current State </summary>
        public void UpdateCurrentState()
        {
            fov.RefreshFieldOfView();
            currentState.Update();
        }

        /// <summary> Change the Current State </summary>
        public void ChangeState(IState newState)
        {
            // If the new state is not null
            if(currentState != null)
            {
                currentState.Exit(); // Exit the current state
            }
            
            currentState = newState; // Set the new state
            
            currentState.Enter(this); // Enter the new state
        }
    }
}

