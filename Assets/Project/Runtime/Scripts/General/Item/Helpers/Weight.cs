
namespace RLSKTD.General.ItemHelper
{
    /// <summary> The weight of an item. </summary>
    [System.Serializable]
    public class Weight
    {
        public float value;

        public Weight(Item item) => this.value = GetWeight(item);

        /// <summary> Gets the weight of an item. </summary>
        /// <param name="item"> The item. </param>
        /// <returns> The weight of the item. </returns>
        private float GetWeight(Item item)
        {
            switch (item.Material.ToString())
            {
                case "Mithril":
                    return 0.05f;
                case "Paper":
                    return 0.01f;
                case "Glass":
                    return 0.02f;
                default :
                    return 1f;
            }
        }
    }
}