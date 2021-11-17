/// <summary> NPC States Live Here </summary>
namespace RLSKTD.Character.NPC.State
{
    /// <summary> NPC Idle State is the default state for the NPC. </summary>
    class IdleState : IState
    {
        private NPCStateManager manager; // NPC State Manager

        /// <summary> Called when the Idle state is entered </summary>
        public void Enter(NPCStateManager manager) 
        {
            this.manager = manager; // Set the manager
        }

        /// <summary> Called when the Idle state is exited </summary>
        public void Exit()
        {

        }

        /// <summary> Called when the Idle state is updated </summary>
        public void Update()
        {
            //If the player is within the NPC's visibletiles and the NPC is Aggressive
            if(manager.FOV.VisibleTiles.Contains(GameManager.instance.Characters[GameManager.instance.Player]) && manager.IsAggressive)
            {
                manager.Target = GameManager.instance.Player.transform; // Set the target
                manager.ChangeState(new PathState()); // Change to the path state
            }
        }
    }
}