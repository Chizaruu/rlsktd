using System.Linq;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> Item name generation. </summary>
    sealed class ItemNameGeneration
    {
        /// <summary> Generate item name. </summary>
        public void ItemNameGeneraton (Item item)
        {        
            //if item purposes contains isEquipable
            if(item.Purposes.Keys.Contains("isEquipable"))
            {
                //if item purposes contains isArtifact
                if(item.Purposes.Keys.Contains("isArtifact"))
                {
                    item.ItemName = "The " + item.Material.Material + " " + item.ItemType.SubType;
                }
                //else item is not artifact
                else
                {
                    item.ItemName = "A " + item.Material.Material + " " + item.ItemType.SubType;
                }
            }
            //else item is not equipable
            else
            {
                item.ItemName = item.Quality + " " + item.Material.Material + " " + item.ItemType.SubType;
            }
        }
    }
}

