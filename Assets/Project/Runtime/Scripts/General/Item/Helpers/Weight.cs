namespace RLSKTD.General.Item.Helpers {
    /// <summary> The weight of an item. </summary>
    public class Weight {
        /// <summary> Enumeration of all item weight classes. </summary>
        public enum WeightEnum {
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
        private WeightEnum weightClass;

        public WeightEnum _WeightClass { get => weightClass; set => weightClass = value; }

        /// <summary> Constructor for the weight class. </summary>
        /// <param name="weightClass"> The weight class of the item. </param>
        /// <returns> The weight class of the item. </returns>
        public Weight(WeightEnum weightClass, float itemWeight) => this.weightClass = weightClass;

        /// <summary> Gets the base weight of an item. </summary>
        /// <param name="item"> The item. </param>
        /// <returns> The base weight of the item. </returns>
        public static float GetBaseWeight(WeightEnum weightEnum) {
            switch (weightEnum)
            {
                case WeightEnum.VeryLight:
                    return 0.1f;
                case WeightEnum.Light:
                    return 0.5f;
                case WeightEnum.Medium:
                    return 2.3f;
                case WeightEnum.Heavy:
                    return 5.7f;
                case WeightEnum.VeryHeavy:
                    return 8.9f;
                default:
                    return 0;
            }
        }

        /// <summary> Gets the type weight of the item </summary>
        /// <param name="item"> The item. </param>
        /// <returns> The type weight of the item. </returns>
        public static float GetTypeWeight(Type.TypeEnum typeEnum, float itemWeight) {
            switch (typeEnum)
            {
                case Type.TypeEnum.Weapon:
                    return itemWeight * 1.5f;
                case Type.TypeEnum.Armor:
                    return itemWeight * 1.9f;
                case Type.TypeEnum.Jewelry:
                    return itemWeight * 1.2f;
                default:
                    return itemWeight;
            }
        }
    }
}