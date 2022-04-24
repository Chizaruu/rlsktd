using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories{
    /// <summary> This is the Furniture class </summary>
    [System.Serializable]
    public class Furniture : Item
    {
        public enum FurnitureType
        {
            Bed, Chair, Storage, Clock, Table, Light, 
            Entertainment, Art, FauxWall
        }

        [OdinSerialize, UnityEngine.HideInInspector]private FurnitureType furnitureType;

        [ShowInInspector, ReadOnly]public FurnitureType _FurnitureType
        {
            get => furnitureType; set
            {
                furnitureType = value;

                _Type = Type.Furniture;
            }
        }

        public Furniture(){}

        public Furniture(FurnitureType FurnitureType, Material material)
        {
            _FurnitureType = FurnitureType;
            _Material = material;
        }
    }
}