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
            switch(manager.FOV.VisibleTiles.Contains(GameManager.instance.Characters[GameManager.instance.Player]))
            {
                case true:
                    switch(manager.IsAggressive)
                    {
                        case true:
                            if(GameManager.instance.Player.GetComponent<Foundation>().IsDead) return; // If the player is dead, return.
                            manager.Target = GameManager.instance.Player.transform; // Set the target
                            manager.ChangeState(new PathState()); // Change to the path state
                            break;
                        case false:
                            //Do nothing?
                            //Maybe wave? 
                            break;
                    }
                    break;
                case false:
                    //Do nothing?
                    break;
            }
        }
    }
}