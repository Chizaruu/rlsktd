using UnityEngine;
using RLSKTD.Character.NPC.State;
using RLSKTD.AI.Pathfinding;

/// <summary> NPC Stuff Live Here </summary>
namespace RLSKTD.Character.NPC
{
    /// <summary> NPC State Manager controls the NPC's state </summary>
    public class NPCStateManager : MonoBehaviour
    {
        /// <summary> Current NPC State </summary>
        private IState currentState;

        /// <summary> NPCs target </summary>
        [SerializeField]private Transform target;

        /// <summary> NPCs targets world postion </summary>
        [SerializeField]private Vector3Int targetWorldPos; 

        /// <summary> Is the NPC aggressive </summary>
        [SerializeField]private bool isAggressive;

        /// <summary> Is the NPC ranged </summary>
        [SerializeField]private bool isRanged; 

        /// <summary> The NPC's attack range </summary>
        [SerializeField]private float attackRange = 1.5f;

        [SerializeField]private AStar aStar;
        [SerializeField]private FOV fov;

        public Transform Target { get => target; set => target = value; }
        public Vector3Int TargetWorldPos { get => targetWorldPos; set => targetWorldPos = value; }
        public bool IsAggressive { get => isAggressive;}
        public bool IsRanged { get => isRanged;}
        public float AttackRange { get => attackRange; set => attackRange = value; }

        public AStar AStar { get => aStar; }
        public FOV FOV { get => fov;}

        /// <summary> Initialize the NPC State Manager </summary>
        private void Awake() => ChangeState(new IdleState());

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

