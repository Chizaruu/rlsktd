using RLSKTD.General.Item;
using System.Collections.Generic;

/// <summary> Actions are the basic building blocks of the character. </summary>
namespace RLSKTD.Character.Actions {

    /// <summary> TakeAction is an action that allows the character to take an item from a container or the ground. </summary>
    public class TakeAction : Action {

        /// <summary> The item to take and put in the inventory. </summary>
        public TakeAction(Item item, List<Item> inventory) {
            inventory.Add(item); // Add the item to the inventory.
        }
    }
}