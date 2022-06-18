using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using RLSKTD.General;
using RLSKTD.Character.NPC;
using RLSKTD.Character.NPC.State;

/// <summary> Holds all the scripts for a character </summary>
namespace RLSKTD.Character {
  /// <summary> Foundation for a character </summary>
  public class Foundation : SerializedMonoBehaviour {
    [OdinSerialize, HideInInspector] private CharacterState state = new CharacterState(); // Character State

    [OdinSerialize, TabGroup("Information")] private bool isPlayer; // Used to determine if the character is the player or not
    [ShowInInspector, TabGroup("Information")] public string CharacterName { get => this.state.characterName; set => this.state.characterName = value; }
    [ShowInInspector, TabGroup("Information")] public string Description { get => this.state.description; set => this.state.description = value; }
    [ShowInInspector, TabGroup("Information")] public Vector3 Position { get => this.state.position; set => this.state.position = this.gameObject.transform.position; }
    [ShowInInspector, TabGroup("Information")] public bool IsAggressive { get => this.state.isAggressive; set => this.state.isAggressive = value; }
    [ShowInInspector, TabGroup("Information")] public IState NpcState { get => this.state.npcState; set => this.state.npcState = value; }
    [ShowInInspector, TabGroup("Information")] public bool IsDead { get => this.state.isDead; set => this.state.isDead = value; }

    [ShowInInspector, TabGroup("Stats")] public int Strength { get => this.state.strength; set => this.state.strength = value; }
    [ShowInInspector, TabGroup("Stats")] public int Constitution { get => this.state.constitution; set => this.state.constitution = value; }
    [ShowInInspector, TabGroup("Stats")] public int Dexterity { get => this.state.dexterity; set => this.state.dexterity = value; }
    [ShowInInspector, TabGroup("Stats")] public int Intelligence { get => this.state.intelligence; set => this.state.intelligence = value; }
    [ShowInInspector, TabGroup("Stats")] public int Willpower { get => this.state.willpower; set => this.state.willpower = value; }
    [ShowInInspector, TabGroup("Stats")] public int Wisdom { get => this.state.wisdom; set => this.state.wisdom = value; }
    [ShowInInspector, TabGroup("Stats")] public int Charisma { get => this.state.charisma; set => this.state.charisma = value; }

    [ShowInInspector, TabGroup("Essentials")]
    public int Health {
      get => this.state.health; set {
        switch (value) {
          case int n when n <= 0:
            this.state.health = 0;
            this.state.isDead = true;
            Debug.Log(CharacterName + " has died.");
            break;
          case int n when n > this.state.maxHealth:
            this.state.health = this.state.maxHealth;
            break;
          default:
            this.state.health = value;
            break;
        }

        if (isPlayer) SetUI();
      }
    }

    [ShowInInspector, TabGroup("Essentials")]
    public int MaxHealth {
      get => this.state.maxHealth; set {
        this.state.maxHealth = value;
        if (isPlayer) SetUI();
      }
    }

    [OdinSerialize, TabGroup("Group 2", "Inventory & Equipment")] public List<Item> Inventory { get => this.state.inventory; set => this.state.inventory = value; }
    [OdinSerialize, TabGroup("Group 2", "Inventory & Equipment")] public List<Item> Equipment { get => this.state.equipment; set => this.state.equipment = value; }

    [ShowInInspector, TabGroup("Group 2", "Combat")] public int MainHandModifier { get => this.state.mainHandModifier; set => this.state.mainHandModifier = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int MainHandAttackRollDice { get => this.state.mainHandAttackRollDice; set => this.state.mainHandAttackRollDice = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int MainHandAttackRollDiceAmount { get => this.state.mainHandAttackRollDiceAmount; set => this.state.mainHandAttackRollDiceAmount = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int MainHandDamageRollDice { get => this.state.mainHandDamageRollDice; set => this.state.mainHandDamageRollDice = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int MainHandDamageAmount { get => this.state.mainHandDamageAmount; set => this.state.mainHandDamageAmount = value; }

    [ShowInInspector, TabGroup("Group 2", "Combat")] public int OffHandModifier { get => this.state.offHandModifier; set => this.state.offHandModifier = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int OffHandAttackRollDice { get => this.state.offHandAttackRollDice; set => this.state.offHandAttackRollDice = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int OffHandAttackRollDiceAmount { get => this.state.offHandAttackRollDiceAmount; set => this.state.offHandAttackRollDiceAmount = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int OffHandDamageRollDice { get => this.state.offHandDamageRollDice; set => this.state.offHandDamageRollDice = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int OffHandDamageAmount { get => this.state.offHandDamageAmount; set => this.state.offHandDamageAmount = value; }

    [ShowInInspector, TabGroup("Group 2", "Combat")] public int RangedModifier { get => this.state.rangedModifier; set => this.state.rangedModifier = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int RangedAttackRollDice { get => this.state.rangedAttackRollDice; set => this.state.rangedAttackRollDice = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int RangedAttackRollDiceAmount { get => this.state.rangedAttackRollDiceAmount; set => this.state.rangedAttackRollDiceAmount = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int RangedDamageRollDice { get => this.state.rangedDamageRollDice; set => this.state.rangedDamageRollDice = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int RangedDamageAmount { get => this.state.rangedDamageAmount; set => this.state.rangedDamageAmount = value; }
    [ShowInInspector, TabGroup("Group 2", "Combat")] public int AmmoModifer { get => this.state.ammoModifer; set => this.state.ammoModifer = value; }

    [ShowInInspector, TabGroup("Group 2", "Defense")] public int DefensiveValue { get => this.state.defensiveValue; set => this.state.defensiveValue = value; }
    [ShowInInspector, TabGroup("Group 2", "Defense")] public int ProtectionValue { get => this.state.protectionValue; set => this.state.protectionValue = value; }
    [ShowInInspector, TabGroup("Group 2", "Defense")] public int ReductionPercentage { get => this.state.reductionPercentage; set => this.state.reductionPercentage = value; }
    [ShowInInspector, TabGroup("Group 2", "Defense")] public int ProtectionValueDiceRolls { get => this.state.protectionValueDiceRolls; set => this.state.protectionValueDiceRolls = value; }
    [ShowInInspector, TabGroup("Group 2", "Defense")] public int DiceRollAmount { get => this.state.diceRollAmount; set => this.state.diceRollAmount = value; }
    [ShowInInspector, TabGroup("Group 2", "Defense")] public int ShieldDV { get => this.state.shieldDV; set => this.state.shieldDV = value; }
    public bool IsPlayer { get => isPlayer; }

    /// <summary> Adds the character to the list of characters in the game. </summary>
    private void Start() {
      GameManager.instance.AddCharacter(this.gameObject);

      if (isPlayer) SetUI();
    }

    /// <summary> Save the character's state to a file </summary>
    public void SaveState(string path) {
      string Scene = GameManager.instance.sceneName; // Set the scene name
      Position = this.gameObject.transform.position; // Set the position

      if (!isPlayer) {
        IsAggressive = GetComponent<NPCStateManager>().IsAggressive;
        path = Path.Combine(path, GameManager.instance.sceneName);

        if (!Directory.Exists(path)) {
          Directory.CreateDirectory(path); // Create the directory if it doesn't exist
          Debug.Log("Created directory: " + path);
        }

        path = Path.Combine(path, "NPCS"); //path = C:\Users\User\AppData\LocalLow\DefaultCompany\HumbleRPG\Saves\save\scene\NPCS

        if (!Directory.Exists(path)) {
          Directory.CreateDirectory(path); // Create the directory if it doesn't exist
          Debug.Log("Created directory: " + path);
        }
      }

      path = Path.Combine(path, CharacterName + ".humble"); //path = C:\Users\User\AppData\LocalLow\DefaultCompany\HumbleRPG\Saves\save\scene\NPCS\CharacterName.humble

      byte[] saveJson = SerializationUtility.SerializeValue(this.state, DataFormat.JSON); //Serialize the state to JSON
      File.WriteAllBytes(path, saveJson); //Save the state to a file

      //Debug.Log("Saved to " + path);
    }

    /// <summary> Load the character's state from a file </summary>
    public bool LoadState(string characterName, string path) {
      path = Path.Combine(path, characterName + ".humble"); //path = C:\Users\User\AppData\LocalLow\DefaultCompany\HumbleRPG\Saves\save\scene\NPCS\characterName.humble

      if (!File.Exists(path)) {
        Debug.LogError("File does not exist");
        return true;
      }

      byte[] loadJson = File.ReadAllBytes(path); //loadJson = byte[]
      this.state = SerializationUtility.DeserializeValue<CharacterState>(loadJson, DataFormat.JSON); //DeserializeValue<T> is a generic method that takes in a byte array and a data format and returns a T.

      this.gameObject.transform.position = this.state.position; //sets the position of the character to the position of the state.

      if (isPlayer) SetUI();

      //Debug.Log("Loaded from " + path);
      return true;
    }

    private void SetUI() {
      this.GetComponent<Player.UIController>().SetHealth(this.state.health, this.state.maxHealth); //sets the health of the player UI to the health of the state.
    }
  }

  /// <summary> The state of the character </summary>
  [System.Serializable]
  public class CharacterState {
    public string characterName;
    public Vector3 position; //The position of the character

    public string description; //The description of the character
    public bool isAggressive; //If the character is aggressive or not.
    public IState npcState; //The state of the npc
    public bool isDead; //If the character is dead or not.
    public int strength;
    public int constitution;
    public int dexterity;
    public int intelligence;
    public int willpower;
    public int wisdom;
    public int charisma;
    public int health;
    public int maxHealth;
    public List<Item> inventory; //The inventory of the character
    public List<Item> equipment; //Equipment is a list of items that are equipped to the character.

    public int mainHandModifier; //The modifier of the main hand weapon
    public int mainHandAttackRollDice = 1; //The number of dice to roll for the attack roll
    public int mainHandAttackRollDiceAmount = 20; //The number of sides on each dice
    public int mainHandDamageRollDice; //The number of dice to roll for main hand damage
    public int mainHandDamageAmount; //The amount of damage the main hand weapon does

    public int offHandModifier; //The modifier for the offhand
    public int offHandAttackRollDice = 1; //The number of dice to roll for the attack
    public int offHandAttackRollDiceAmount = 20; //The number of sides on each dice
    public int offHandDamageRollDice; //The number of dice to roll for offhand damage
    public int offHandDamageAmount; //The amount of damage the character does with their off hand.

    public int rangedModifier; //The modifier for the ranged weapon
    public int rangedAttackRollDice = 1; //The number of dice to roll
    public int rangedAttackRollDiceAmount = 20; //The number of sides on each dice
    public int rangedDamageRollDice; //The number of dice to roll for ranged damage 
    public int rangedDamageAmount; //The amount of damage the character deals with ranged attacks
    public int ammoModifer = 0; //The modifier to the damage roll of the ammo.

    public int defensiveValue; //The defensive value of the character
    public int protectionValue; //The protection value of the character
    public int reductionPercentage; //The percentage of damage reduced by the armor
    public int protectionValueDiceRolls; //The number of dice rolls to roll for the protection value of the character (?)
    public int diceRollAmount; //The amount of dice rolls to be made.
    public int shieldDV; //shield DV is the DV of the shield.
  }
}