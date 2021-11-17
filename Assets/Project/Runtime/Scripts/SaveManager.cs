using System.Collections;
using System.Collections.Generic;
using RLSKTD.Character;
using UnityEngine;
using System.IO;
using RLSKTD.Map;
using RLSKTD.Character.NPC;

/// <summary> SaveManager is a class that handles saving and loading of the game. </summary>
public class SaveManager : MonoBehaviour
{
    /// <summary> Save the scene. </summary>
    public void SaveScene()
    {
        string path = Path.Combine(Application.persistentDataPath, "Saves"); //path = C:\Users\User\AppData\LocalLow\HumbleRPG\Saves

        if(!Directory.Exists(path)){
            Directory.CreateDirectory (path); // Create the directory if it doesn't exist
            Debug.Log("Created directory: " + path);
        }

        path = Path.Combine(path, GameManager.instance.Player.GetComponent<Foundation>().CharacterName); //path = C:\Users\User\AppData\LocalLow\HumbleRPG\Saves\CharacterName

        if(!Directory.Exists(path)){
            Directory.CreateDirectory (path); // Create the directory if it doesn't exist
            Debug.Log("Created directory: " + path);
        }

        //Save Map
        MapSerializer.SaveMap(path, MapManager.instance.floorMap, MapManager.instance.floorTiles); //Save floorTiles to file
        MapSerializer.SaveMap(path, MapManager.instance.obstacleMap, MapManager.instance.obstacleTiles); //Save obstacleTiles to file
        MapSerializer.SaveMap(path, MapManager.instance.fogMap, MapManager.instance.fogTiles); //Save fogTiles to file

        //Save GameObjects using Foundation method SaveState(playerName)
        foreach (GameObject unit in GameManager.instance.Characters.Keys)
        {
            unit.GetComponent<Foundation>().SaveState(path);  //Save the state of the character
        }

    }

    /// <summary> Load the scene. </summary>
    public void LoadScene(string characterName)
    {
        // if Characters are greater than 0, destroy them
        if(GameManager.instance.Characters.Count > 0)
        {
            //Destroy all Characters
            foreach (GameObject character in GameManager.instance.Characters.Keys)
            {
                Destroy(character); //Destroy the character
            }
            
            GameManager.instance.Characters = new Dictionary<GameObject, Vector3Int>(); //Clear the Characters list
        }

        string path = Path.Combine(Application.persistentDataPath, "Saves"); //path = C:\Users\User\AppData\LocalLow\HumbleRPG\Saves
        path = Path.Combine(path, characterName); //path = C:\Users\User\AppData\LocalLow\HumbleRPG\Saves\CharacterName
        
        //Load Player
        GameObject playerInstance = Instantiate(Resources.Load<GameObject>("Prefabs/Player"), Vector3.zero, Quaternion.identity); //Instantiate the player
        playerInstance.transform.SetParent(GameObject.Find("Characters").transform); //Set the player's parent to Characters
        playerInstance.GetComponent<Foundation>().LoadState(characterName, path); //Load the player's state
        playerInstance.name = characterName; //Set the player's name to the save name

        path = Path.Combine(path, GameManager.instance.sceneName); //path = C:\Users\User\AppData\LocalLow\HumbleRPG\Saves\CharacterName\SceneName

        //Initialize the mapPath
        string mapPath = Path.Combine(path, "Maps"); //path = C:\Users\User\AppData\LocalLow\HumbleRPG\Saves\CharacterName\SceneName\Maps
        
        //Load Map
        
        foreach (string map in Directory.GetFiles(mapPath))
        {
            string mapName = Path.GetFileNameWithoutExtension(map); //Get the map name without the extension
            //Debug.Log("Loading map: " + mapName);
            switch (mapName)
            {
                case "Floor":
                    MapManager.instance.floorTiles = MapSerializer.LoadMap(mapName, mapPath, MapManager.instance.floorMap, MapManager.instance.floorTiles);
                    break;
                case "Obstacle":
                    MapManager.instance.obstacleTiles =MapSerializer.LoadMap(mapName, mapPath, MapManager.instance.obstacleMap, MapManager.instance.obstacleTiles);
                    break;
                case "Fog":
                    MapManager.instance.fogTiles =MapSerializer.LoadMap(mapName, mapPath, MapManager.instance.fogMap, MapManager.instance.fogTiles);
                    break;
                default:
                    break;
            }
        }  

        //Initialize the npcPath
        string npcPath = Path.Combine(path, "NPCS"); //path = C:\Users\User\AppData\LocalLow\DefaultCompany\HumbleRPG\Saves\save\scene\NPCS
        
        //Load NPCs
        foreach (string npc in Directory.GetFiles(npcPath))
        {
            string npcName = Path.GetFileNameWithoutExtension(npc); //Get the npc name without the extension
            GameObject npcInstance = Instantiate(Resources.Load<GameObject>("Prefabs/NPC"), Vector3.zero, Quaternion.identity); //Instantiate the NPC
            npcInstance.transform.SetParent(GameObject.Find("Characters").transform); //Set the NPC's parent to Characters
            npcInstance.GetComponent<Foundation>().LoadState(npcName, npcPath); //Load the NPC's state
            npcInstance.GetComponent<NPCStateManager>().IsAggressive = npcInstance.GetComponent<Foundation>().IsAggressive; //Set the NPC's IsAggressive to the save value
            npcInstance.name = npcName; //Set the NPC's name to the npc name
        }  
    }
}
