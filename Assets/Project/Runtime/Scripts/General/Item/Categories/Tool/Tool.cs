using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories{
    /*
        The idea behind this class is to provide generic tools that can be used to do different things.

        This doesn't mean that a weapon can't be used, if it was say a Hand Axe to chop wood, the functionaility should still be the same provided check is created.
    */

    /// <summary> This is the tool class </summary>
    [System.Serializable]
    public class Tool : Item
    {
        public enum ToolType
        {
            Magical, Needle, Hammer, Axe, Pickaxe, Saw,
            Knife
        }

        [OdinSerialize, UnityEngine.HideInInspector]private ToolType toolType;

        [ShowInInspector, ReadOnly]public ToolType _ToolType
        {
            get => toolType; set
            {
                toolType = value;

                _Type = Type.Tool;
            }
        }

        public Tool(){}

        public Tool(ToolType toolType, Material material)
        {
            _ToolType = toolType;
            _Material = material;
        }
    }
}