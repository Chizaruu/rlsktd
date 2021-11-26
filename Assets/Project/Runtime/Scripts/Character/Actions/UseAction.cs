using UnityEngine;
using RLSKTD.General.Item;

/// <summary> Actions are the basic building blocks of the character. </summary>
namespace RLSKTD.Character.Actions
{
    /// <summary> UseAction is an action that can be used to use an item. </summary>
    public class UseAction : Action
    {
        public UseAction(Item item, GameObject character)
        {
            /*
            //for each string in the item's Bools
            foreach(string key in item.Purposes.Keys)
            {
                //if the key is in the character's Bools
                switch (key)
                {
                    //if the key is "isDrinkable"
                    case "isDrinkable" : 
                        //if the item stats contains a key called "Healing"
                        if(item.Stats.ContainsKey("Healing"))
                        {
                            character.GetComponent<Foundation>().Hp += item.Stats["Healing"]; //add the healing value to the character's hp
                        }
                        return;
                    //if the key is "isEdible"
                    case "isEdible" :
                        character.GetComponent<Foundation>().Hunger -= item.Stats["Food"]; //subtract the food value from the character's hunger
                        return;
                    //if the key is "isReadable"
                    case "isReadable" :
                        Debug.Log("Reading Book/Scroll");
                        return;
                    //if the key is "isPlantable"
                    case "isPlantable" :
                        Debug.Log("Planting " + item.ItemName);
                        return;
                    //if there is no key
                    default:
                        return;
                }
            }
            */
        }
    }
}


