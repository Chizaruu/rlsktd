using UnityEngine;

namespace RLSKTD.General
{
    /// <summary> Spawns an item at a given position. </summary>
    public class SpawnItem : MonoBehaviour
    {
        /// <summary> Spawns the item at the given position. </summary>
        /// <param name="position"> The position to spawn the item at. </param>
        /// <param name="item"> The item to spawn. </param>
        /// <returns> The spawned item. </returns>
        public void SpawnItemWorld(Item item, Vector3 position)
        {
            GameObject spawnedItem = Instantiate(Resources.Load<GameObject>("Prefabs/pfItem"), position, Quaternion.identity); //Instantiate the item

            spawnedItem.name = item.Name; //Set the name of the item
            
            //spawnedItem.GetComponent<SpriteRenderer>().sprite = item.Sprite; //Set the sprite of the item
            spawnedItem.GetComponent<SpriteRenderer>().color = item.Color; //Set the color of the item
            spawnedItem.GetComponent<ItemWorld>().Item = item; //Set the item of the item

            spawnedItem.transform.SetParent(GameObject.Find("Interactables").transform); //Set the parent of the item to the interactables
        }
    }
}