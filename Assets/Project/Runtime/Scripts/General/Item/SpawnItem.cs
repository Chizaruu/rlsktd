using UnityEngine;
using Sirenix.OdinInspector;

namespace RLSKTD.General
{
    /// <summary> Spawns an item at a given position. </summary>
    //SerializedMonoBehaviour to check dictionaries, can be changed back to MonoBehaviour
    public class SpawnItem : SerializedMonoBehaviour
    {
        public Item item; //The item to spawn
        public Vector3 position; //position to spawn the item at

        /// <summary> Spawns the item at the given position. </summary>
        public void SpawnItemWorld()
        {
            GameObject spawnedItem = Instantiate(Resources.Load<GameObject>("Prefabs/pfItem"), position, Quaternion.identity); //Instantiate the item

            spawnedItem.name = item.ItemName; //Set the name of the item
            
            spawnedItem.GetComponent<SpriteRenderer>().sprite = item.Sprite; //Set the sprite of the item
            spawnedItem.GetComponent<SpriteRenderer>().color = item.Color; //Set the color of the item
            spawnedItem.GetComponent<ItemWorld>().Item = item; //Set the item of the item

            spawnedItem.transform.SetParent(GameObject.Find("Interactables").transform); //Set the parent of the item to the interactables
        }
    }
}