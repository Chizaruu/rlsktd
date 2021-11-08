/// <summary> NPC States Live Here </summary>
namespace RLSKTD.Character.NPC.State
{
    /// <summary> Interface for all NPC States </summary>
    public interface IState
    {
        /// <summary> Called when the state is entered </summary>
        void Enter(NPCStateManager manager);
        /// <summary> Called when the state is exited </summary>
        void Exit();
        /// <summary> Called when the state is updated </summary>
        void Update();
    }
}
