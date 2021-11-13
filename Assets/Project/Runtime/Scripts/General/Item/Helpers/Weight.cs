using UnityEngine;
using Sirenix.OdinInspector;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> The weight of an item. </summary>
    [System.Serializable]
    public class Weight
    {
        /// <summary> Enumeration of all item weight classes. </summary>
        public enum WeightEnum
        {
            /// <summary> The item is very light. </summary>
            VeryLight,
            /// <summary> The item is light. </summary>
            Light,
            /// <summary> The item is medium. </summary>
            Medium,
            /// <summary> The item is heavy. </summary>
            Heavy,
            /// <summary> The item is very heavy. </summary>
            VeryHeavy,
        }

        /// <summary> The weight class of the item. </summary>
        [SerializeField, HideInInspector]
        private WeightEnum weightClass;

        [ShowInInspector]
        public WeightEnum WeightClass { get => weightClass; set => weightClass = value; }

        /// <summary> Constructor for the weight class. </summary>
        /// <param name="weightClass"> The weight class of the item. </param>
        /// <returns> The weight class of the item. </returns>
        public Weight(WeightEnum weightClass, float itemWeight)
        {
            this.weightClass = weightClass;
        }

        /// <summary> Gets the weight of an item. </summary>
        /// <param name="item"> The item. </param>
        /// <returns> The weight of the item. </returns>
        public static float GetBaseWeight(WeightEnum weightEnum)
        {
            switch (weightEnum)
            {
                case WeightEnum.VeryLight:
                    return 0.1f;
                case WeightEnum.Light:
                    return 0.5f;
                case WeightEnum.Medium:
                    return 1f;
                case WeightEnum.Heavy:
                    return 2f;
                case WeightEnum.VeryHeavy:
                    return 5f;
                default:
                    return 0;
            }
        }
    }
}