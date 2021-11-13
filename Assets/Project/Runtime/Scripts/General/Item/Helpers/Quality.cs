namespace RLSKTD.General.ItemHelper
{
    /// <summary> The quality of an item. </summary>
    public class Quality
    {
        /// <summary> Enumeration of all item qualities. </summary>
        public enum ItemQuality
        {
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
        public ItemQuality itemQuality;

        /// <summary> Constructor for the item quality. </summary>
        /// <param name="itemQuality"> The item quality. </param>
        public Quality(ItemQuality itemQuality)
        {
            this.itemQuality = itemQuality;
        }

        /// <summary> Returns the item quality as a string. </summary>
        /// <returns> The item quality as a string. </returns>
        public override string ToString()
        {
            switch (itemQuality)
            {
                case ItemQuality.Inferior:
                    return "Inferior";
                case ItemQuality.Normal:
                    return "Normal";
                case ItemQuality.Superior:
                    return "Superior";
                case ItemQuality.Exceptional:
                    return "Exceptional";
                case ItemQuality.Unique:
                    return "Unique";
                case ItemQuality.Legendary:
                    return "Legendary";
                default:
                    return "???";
            }
        }

        /// <summary> Returns the item quality as an int. </summary>
        /// <returns> The item quality as an int. </returns>
        public int ToInt()
        {
            switch (itemQuality)
            {
                case ItemQuality.Inferior:
                    return 0;
                case ItemQuality.Normal:
                    return 1;
                case ItemQuality.Superior:
                    return 2;
                case ItemQuality.Exceptional:
                    return 3;
                case ItemQuality.Unique:
                    return 4;
                case ItemQuality.Legendary:
                    return 5;
                default:
                    return -1;
            }
        }
    }
}

