using UnityEngine;
using Sirenix.OdinInspector;

namespace RLSKTD.General
{
    /// <summary> ItemWorld provides a way to store items in the world. </summary>
    //SerializedMonoBehaviour to check dictionaries, can be changed back to MonoBehaviour
    public class ItemWorld : SerializedMonoBehaviour
    {
        [SerializeField]private Item item; //The item that is stored in the world

        public Item Item { get => item; set => item = value; }
    }
}

