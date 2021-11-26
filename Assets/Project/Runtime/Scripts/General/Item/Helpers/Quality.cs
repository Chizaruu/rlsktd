namespace RLSKTD.General.Item.Helpers {
    /// <summary> The quality of an item. </summary>
    /// <remarks> 
    /// Quality will affect the performance of the item.
    /// Example: 
    ///     Food = increased satiety, mood, etc 
    ///     Weapon = increased damage, durability, etc
    ///     Armor = increased defense, duarability, etc
    ///</remarks>
    public class Quality {
        /// <summary> Enums of all item qualities. </summary>
        public enum QualityEnum {
            /// <summary> The item is of inferior quality. </summary>
            Inferior,
            /// <summary> The item is of normal quality. </summary>
            Normal,
            /// <summary> The item is of superior quality. </summary>
            Superior,
            /// <summary> The item is of exceptional quality. </summary>
            Exceptional,
            /// <summary> The item is of unique quality. </summary>
            Unique,
            /// <summary> The item is of legendary quality. </summary>
            Legendary,
        }

        /// <summary> The item quality. </summary>
        public QualityEnum qualityEnum;

        /// <summary> Constructor for the item quality. </summary>
        /// <param name="qualityEnum"> The item quality. </param>
        public Quality(QualityEnum qualityEnum) => this.qualityEnum = qualityEnum;
    }
}