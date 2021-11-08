using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RLSKTD.Character.NPC;
using RLSKTD.AI.Pathfinding;
using RLSKTD.Map;
using Sirenix.OdinInspector;
using UnityEngine.SceneManagement;

/// <summary> The GameManager is the main controller of the game. It handles the game state and the game flow. </summary>
//SerializedMonoBehaviour to check dictionaries, can be changed back to MonoBehaviour
public class GameManager : SerializedMonoBehaviour
{
	public static GameManager instance; //Singleton

	public string sceneName; //name of the scene

	[SerializeField]private float time = 0.1f;	//Time between each frame

	[SerializeField]private bool isPlaying = false; //Is the game currently playing?
	[SerializeField]private bool isPaused = false; //Is the game paused?
	[SerializeField]private bool diagonalMovement = true; //true = diagonal movement, false = no diagonal movement
	
	[SerializeField]private List<GameObject> characters; //List of all characters in the scene
	[SerializeField]private Dictionary<string, Vector3Int> charactersWorldPos = new Dictionary<string, Vector3Int>(); //Key is character name, value is world position
	[SerializeField]private Dictionary<Vector3Int, Node> allNodes = new Dictionary<Vector3Int, Node>(); //All nodes in the map


    public bool IsPlaying { get => isPlaying; set => isPlaying = value; } //Is the game currently playing?
	public bool DiagonalMovement { get => diagonalMovement; set => diagonalMovement = value; } //true = diagonal movement, false = no diagonal movement

	public List<GameObject> Characters { get => characters; set => characters = value; } //List of all characters in the scene
	public Dictionary<string, Vector3Int> CharactersWorldPos { get => charactersWorldPos; set => charactersWorldPos = value; } //Key is character name, value is world position
	public Dictionary<Vector3Int, Node> AllNodes { get => allNodes; set => allNodes = value; } //All nodes in the map

	/// <summary> Awake is called when the script instance is being loaded. </summary>
	private void Awake()
	{
		if (instance == null) //If instance is not assigned
		{
			instance = this; //Assign instance to this
		}
		else //else no need for this gameobject!
		{
			Destroy(gameObject); //Destroy this gameobject
		}
			
		sceneName = SceneManager.GetActiveScene().name; //Get the name of the scene
	} 
    
	/// <summary> This function is called when the player ends its turn. </summary>
	public void TurnChange()
	{
		//Debug.Log("Turn Change");
		CharactersWorldPos[characters[0].name] = MapManager.instance.floorMap.WorldToCell(characters[0].transform.position); //Update the player's world position
		for(int i = 1; i < characters.Count; i++)
		{
			characters[i].GetComponent<NPCStateManager>().UpdateCurrentState(); //Update the current state of the character
			CharactersWorldPos[characters[i].name] = MapManager.instance.floorMap.WorldToCell(characters[i].transform.position); //Update the character's world position
			isPlaying = true; //Set isPlaying to true
		}
		StartCoroutine(waiting()); //Start waiting coroutine
	}

	/// <summary> Coroutine to wait for a certain amount of time. </summary>
	private IEnumerator waiting() 
	{
		yield return new WaitForSeconds(time); //Wait for time
		isPlaying = false; //Set isPlaying to false
	}
	
	/// <summary> Add a character to the character and world position lists. </summary>
	public void AddCharacter(GameObject character, bool isPlayer)
	{
		if (isPlayer)
		{
			characters.Insert(0, character);
		}
		else
		{
			characters.Add(character);
		}
		charactersWorldPos.Add(character.name, MapManager.instance.floorMap.WorldToCell(character.transform.position));
	}

	/// <summary> Remove a character from the character and world position lists. </summary>
	public void RemoveCharacter(GameObject character)
	{
		characters.Remove(character);
		charactersWorldPos.Remove(character.name);
	}
}


