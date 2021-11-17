using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RLSKTD.Character.NPC;
using RLSKTD.AI.Pathfinding;
using RLSKTD.Map;
using Sirenix.OdinInspector;
using UnityEngine.SceneManagement;
using RLSKTD.Character;
using Sirenix.Serialization;
using System.Linq;

/// <summary> The GameManager is the main controller of the game. It handles the game state and the game flow. </summary>
//SerializedMonoBehaviour to check dictionaries, can be changed back to MonoBehaviour
public class GameManager : SerializedMonoBehaviour
{
	public static GameManager instance; //Singleton

	public string sceneName; //name of the scene

	[OdinSerialize]private float time = 0.1f;	//Time between each frame

	[OdinSerialize]private bool isPlaying = false; //Is the game currently playing?
	[OdinSerialize]private bool isPaused = false; //Is the game paused?
	[OdinSerialize]private bool diagonalMovement = true; //true = diagonal movement, false = no diagonal movement

	[OdinSerialize]private GameObject player; //Player

	[OdinSerialize]private Dictionary<GameObject, Vector3Int> characters = new Dictionary<GameObject, Vector3Int>(); //Dictionary of all characters and their world position
	[OdinSerialize]private Dictionary<Vector3Int, Node> allNodes = new Dictionary<Vector3Int, Node>(); //All nodes in the map


    public bool IsPlaying { get => isPlaying; set => isPlaying = value; } //Is the game currently playing?
	public bool DiagonalMovement { get => diagonalMovement; set => diagonalMovement = value; } //true = diagonal movement, false = no diagonal movement

	public GameObject Player { get => player; set => player = value; } //Player
	
	public Dictionary<GameObject, Vector3Int> Characters { get => characters; set => characters = value; } //Dictionary of all characters and their world position
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
		foreach(GameObject character in Characters.Keys.ToList()) //For each character
		{
			switch (character.GetComponent<Foundation>().IsPlayer)
			{
				case true: //If it is a player
					Characters[character] = MapManager.instance.floorMap.WorldToCell(character.transform.position);
					break;
				case false: //If it is not a player
					character.GetComponent<NPCStateManager>().UpdateCurrentState(); //Update the current state of the character
					Characters[character] = MapManager.instance.floorMap.WorldToCell(character.transform.position);

					if (Player.GetComponent<FOV>().VisibleTiles.Contains(Characters[character])) //If the character is visible to the player
					{
						character.gameObject.GetComponent<SpriteRenderer>().enabled = true; //Enable the sprite renderer
					}
					else
					{
						character.gameObject.GetComponent<SpriteRenderer>().enabled = false; //Disable the sprite renderer
					}
					
					isPlaying = true; //Set isPlaying to true
					break;
			}
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
	public void AddCharacter(GameObject character)
	{
		switch (character.GetComponent<Foundation>().IsPlayer)
		{
			case true:
				player = character;
				Characters.Add(character, MapManager.instance.floorMap.WorldToCell(character.transform.position));
				break;
			case false:
				Characters.Add(character, MapManager.instance.floorMap.WorldToCell(character.transform.position));

				if (character.GetComponent<FOV>().VisibleTiles.Contains(Characters[character])) //If the character is visible to the player
				{
					character.gameObject.GetComponent<SpriteRenderer>().enabled = true; //Enable the sprite renderer
				}
				else
				{
					character.gameObject.GetComponent<SpriteRenderer>().enabled = false; //Disable the sprite renderer
				}
				break;
		}
	}

	/// <summary> Remove a character from the character dictionary. </summary>
	public void RemoveCharacter(GameObject character)
	{
		characters.Remove(character);
	}
}


