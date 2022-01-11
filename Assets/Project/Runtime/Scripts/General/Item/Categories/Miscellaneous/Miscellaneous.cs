using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories{
    /// <summary> This is the Miscellaneous class </summary>
    [System.Serializable]
    public class Miscellaneous : Item
    {
        public enum MiscellaneousType
        {
            Key, Coin
        }

        [OdinSerialize, UnityEngine.HideInInspector]private MiscellaneousType miscellaneousType;

        [ShowInInspector, ReadOnly]public MiscellaneousType _MiscellaneousType
        {
            get => miscellaneousType; set
            {
                miscellaneousType = value;

                _Type = Type.Miscellaneous;
            }
        }

        public Miscellaneous(){}

        public Miscellaneous(MiscellaneousType miscellaneousType, Material material)
        {
            _MiscellaneousType = miscellaneousType;
            _Material = material;
        }
    }
}