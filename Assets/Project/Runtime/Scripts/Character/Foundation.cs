using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using RLSKTD.General.Item;
using RLSKTD.Character.NPC;
using RLSKTD.Character.NPC.State;

/// <summary> Holds all the scripts for a character </summary>
namespace RLSKTD.Character
{
    /// <summary> Foundation for a character </summary>
    public class Foundation : SerializedMonoBehaviour
    {
        [OdinSerialize, HideInInspector]private CharacterState state = new CharacterState(); // Character State - GitHub Co-Pilot
        
        [OdinSerialize, TabGroup("Information")]private bool isPlayer; // Used to determine if the character is the player or not

        [ShowInInspector, TabGroup("Information")]public string CharacterName{ get => this.state.characterName; set => this.state.characterName = value; }
        [ShowInInspector, TabGroup("Information")]public string CharacterAlias { get => this.state.characterAlias; set => this.state.characterAlias = value; }
        [ShowInInspector, TabGroup("Information")]public string Race { get => this.state.race; set => this.state.race = value; }
        [ShowInInspector, TabGroup("Information")]public string Gender { get => this.state.gender; set => this.state.gender = value; }
        [ShowInInspector, TabGroup("Information")]public string ClassPreset { get => this.state.classPreset; set => this.state.classPreset = value; }
        [ShowInInspector, TabGroup("Information")]public string Religion { get => this.state.religion; set => this.state.religion = value; }
        [ShowInInspector, TabGroup("Information")]public string Guild { get => this.state.guild; set => this.state.guild = value; }
        [ShowInInspector, TabGroup("Information")]public string Description { get => this.state.description; set => this.state.description = value; }
        
        [ShowInInspector, TabGroup("Information")]public int Age { get => this.state.age; set => this.state.age = value; }
        [ShowInInspector, TabGroup("Information")]public int Height { get => this.state.height; set => this.state.height = value; }
        [ShowInInspector, TabGroup("Information")]public int Weight { get => this.state.weight; set => this.state.weight = value; }
        [ShowInInspector, TabGroup("Information")]public int Level { get => this.state.level; set => this.state.level = value; }
        [ShowInInspector, TabGroup("Information")]public int Experience { get => this.state.experience; set => this.state.experience = value; }
        [ShowInInspector, TabGroup("Information")]public int RequiredExperience { get => this.state.requiredExperience; set => this.state.requiredExperience = (10 * Level) * (101 + Level); }
        [ShowInInspector, TabGroup("Information")]public int Gold { get => this.state.gold; set => this.state.gold = value; }
        [ShowInInspector, TabGroup("Information")]public int PP { get => this.state.pp; set => this.state.pp = value; }

        [ShowInInspector, TabGroup("Information")]public Vector3 Position { get => this.state.position; set => this.state.position = this.gameObject.transform.position; }
        [ShowInInspector, TabGroup("Information")]public string Scene { get => this.state.scene; set => this.state.scene = value; } 
        [ShowInInspector, TabGroup("Information")]public bool IsAggressive { get => this.state.isAggressive; set => this.state.isAggressive = value; }
        [ShowInInspector, TabGroup("Information")]public IState NpcState { get => this.state.npcState; set => this.state.npcState = value; }
        [ShowInInspector, TabGroup("Information")]public bool IsDead { get => this.state.isDead; set => this.state.isDead = value; }

        [ShowInInspector, TabGroup("Stats")]public int Strength { get => this.state.strength; set => this.state.strength = value; }
        [ShowInInspector, TabGroup("Stats")]public int Constitution { get => this.state.constitution; set => this.state.constitution = value; }
        [ShowInInspector, TabGroup("Stats")]public int Dexterity { get => this.state.dexterity; set => this.state.dexterity = value; }
        [ShowInInspector, TabGroup("Stats")]public int Intelligence { get => this.state.intelligence; set => this.state.intelligence = value; }
        [ShowInInspector, TabGroup("Stats")]public int Willpower { get => this.state.willpower; set => this.state.willpower = value; }
        [ShowInInspector, TabGroup("Stats")]public int Wisdom { get => this.state.wisdom; set => this.state.wisdom = value; }
        [ShowInInspector, TabGroup("Stats")]public int Charisma { get => this.state.charisma; set => this.state.charisma = value; }

        [ShowInInspector, TabGroup("Essentials")]public int Hp
        {
            get => this.state.hp; set
            {
                switch(value)
                {
                    case int n when n <= 0:
                        this.state.hp = 0;
                        this.state.isDead = true;
                        Debug.Log(CharacterName + " has died.");
                        break;
                    case int n when n > this.state.maxHp:
                        this.state.hp = this.state.maxHp;
                        break;
                    default:
                        this.state.hp = value;
                        break;
                }

                if(isPlayer)
                {
                    this.GetComponent<Player.UIController>().SetHP(this.state.hp, this.state.maxHp);
                }
            }
        }
        [ShowInInspector, TabGroup("Essentials")]public int Mp
        {
            get => this.state.mp; set
            {
                switch(value)
                {
                    case int n when n <= 0:
                        this.state.mp = 0;
                        Debug.Log(CharacterName + " takes mental damage.");
                        break;
                    case int n when n > this.state.maxMp:
                        this.state.mp = this.state.maxMp;
                        break;
                    default:
                        this.state.mp = value;
                        break;
                }
                
                if(isPlayer)
                {
                    this.GetComponent<Player.UIController>().SetHP(this.state.hp, this.state.maxHp);
                }
            }
        }
        [ShowInInspector, TabGroup("Essentials")]public int MaxHp
        {
            get => this.state.maxHp; set
            {
                this.state.maxHp = value;
                if(isPlayer)
                {
                    this.GetComponent<Player.UIController>().SetHP(this.state.hp, this.state.maxHp);
                }
            }
        }
        [ShowInInspector, TabGroup("Essentials")]public int MaxMp
        {
            get => this.state.maxMp; set
            {
                this.state.maxMp = value;
                if(isPlayer)
                {
                    this.GetComponent<Player.UIController>().SetMP(this.state.mp, this.state.maxMp);
                }
            }
        }
        [ShowInInspector, TabGroup("Essentials")]public int Sanity { get => this.state.sanity; set => this.state.sanity = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Intiative { get => this.state.intiative; set => this.state.intiative = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Speed { get => this.state.speed; set => this.state.speed = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Fatigue { get => this.state.fatigue; set => this.state.fatigue = value; }
        [ShowInInspector, TabGroup("Essentials")]public int MaxFatigue { get => this.state.maxFatigue; set => this.state.maxFatigue = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Sleepiness { get => this.state.sleepiness; set => this.state.sleepiness = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Life { get => this.state.life; set => this.state.life = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Soul { get => this.state.soul; set => this.state.soul = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Hunger { get => this.state.hunger; set => this.state.hunger = value; }
        [ShowInInspector, TabGroup("Essentials")]public int Thirst { get => this.state.thirst; set => this.state.thirst = value; }

        [ShowInInspector, TabGroup("Resistances")]public int Fire { get => this.state.fire; set => this.state.fire = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Cold { get => this.state.cold; set => this.state.cold = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Lightning { get => this.state.lightning; set => this.state.lightning = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Nature { get => this.state.nature; set => this.state.nature = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Magic { get => this.state.magic; set => this.state.magic = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Space { get => this.state.space; set => this.state.space = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Time { get => this.state.time; set => this.state.time = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Sound { get => this.state.sound; set => this.state.sound = value; }
        [ShowInInspector, TabGroup("Resistances")]public int Chaos { get => this.state.chaos; set => this.state.chaos = value; }

        [ShowInInspector, TabGroup("Vanity")]public int Difficulty { get => this.state.difficulty; set => this.state.difficulty = value; }
        [ShowInInspector, TabGroup("Vanity")]public int Luck { get => this.state.luck; set => this.state.luck = value; }
        [ShowInInspector, TabGroup("Vanity")]public int Karma { get => this.state.karma; set => this.state.karma = value; }
        [ShowInInspector, TabGroup("Vanity")]public int Favour { get => this.state.favour; set => this.state.favour = value; }
        [ShowInInspector, TabGroup("Vanity")]public int Fame { get => this.state.fame; set => this.state.fame = value; }

        [ShowInInspector, TabGroup("Abilities")]public List<string> TalentList { get => this.state.talentList; set => this.state.talentList = value; }
        [ShowInInspector, TabGroup("Abilities")]public List<string> RacialTraits { get => this.state.racialTraits; set => this.state.racialTraits = value; }
        [ShowInInspector, TabGroup("Abilities")]public Dictionary<string, double> ProficiencyDictionary { get => this.state.proficiencyDictionary; set => this.state.proficiencyDictionary = value; }
        [ShowInInspector, TabGroup("Abilities")]public Dictionary<string, int> SkillDictionary { get => this.state.skillDictionary; set => this.state.skillDictionary = value; }
        [ShowInInspector, TabGroup("Abilities")]public Dictionary<string, int> SpellDictionary { get => this.state.spellDictionary; set => this.state.spellDictionary = value; }

        [OdinSerialize, TabGroup("Group 2", "Inventory & Equipment")]public List<Item> Inventory { get => this.state.inventory; set => this.state.inventory = value; }
        [OdinSerialize, TabGroup("Group 2", "Inventory & Equipment")]public List<Item> Equipment { get => this.state.equipment; set => this.state.equipment = value; }
        
        [ShowInInspector, TabGroup("Group 2", "Status")]public Dictionary<string, int> StatusEffects { get => this.state.statusEffects; set => this.state.statusEffects = value; }

        [ShowInInspector, TabGroup("Group 2", "Combat")]public int MainHandModifier { get => this.state.mainHandModifier; set => this.state.mainHandModifier = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int MainHandAttackRollDice { get => this.state.mainHandAttackRollDice; set => this.state.mainHandAttackRollDice = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int MainHandAttackRollDiceAmount { get => this.state.mainHandAttackRollDiceAmount; set => this.state.mainHandAttackRollDiceAmount = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int MainHandDamageRollDice { get => this.state.mainHandDamageRollDice; set => this.state.mainHandDamageRollDice = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int MainHandDamageAmount { get => this.state.mainHandDamageAmount; set => this.state.mainHandDamageAmount = value; }

        [ShowInInspector, TabGroup("Group 2", "Combat")]public int OffHandModifier { get => this.state.offHandModifier; set => this.state.offHandModifier = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int OffHandAttackRollDice { get => this.state.offHandAttackRollDice; set => this.state.offHandAttackRollDice = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int OffHandAttackRollDiceAmount { get => this.state.offHandAttackRollDiceAmount; set => this.state.offHandAttackRollDiceAmount = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int OffHandDamageRollDice { get => this.state.offHandDamageRollDice; set => this.state.offHandDamageRollDice = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int OffHandDamageAmount { get => this.state.offHandDamageAmount; set => this.state.offHandDamageAmount = value; }
        
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int RangedModifier { get => this.state.rangedModifier; set => this.state.rangedModifier = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int RangedAttackRollDice { get => this.state.rangedAttackRollDice; set => this.state.rangedAttackRollDice = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int RangedAttackRollDiceAmount { get => this.state.rangedAttackRollDiceAmount; set => this.state.rangedAttackRollDiceAmount = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int RangedDamageRollDice { get => this.state.rangedDamageRollDice; set => this.state.rangedDamageRollDice = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int RangedDamageAmount { get => this.state.rangedDamageAmount; set => this.state.rangedDamageAmount = value; }
        [ShowInInspector, TabGroup("Group 2", "Combat")]public int AmmoModifer { get => this.state.ammoModifer; set => this.state.ammoModifer = value; }

        [ShowInInspector, TabGroup("Group 2", "Defense")]public int DefensiveValue { get => this.state.defensiveValue; set => this.state.defensiveValue = value; } 
        [ShowInInspector, TabGroup("Group 2", "Defense")]public int ProtectionValue { get => this.state.protectionValue; set => this.state.protectionValue = value; }
        [ShowInInspector, TabGroup("Group 2", "Defense")]public int ReductionPercentage { get => this.state.reductionPercentage; set => this.state.reductionPercentage = value; }
        [ShowInInspector, TabGroup("Group 2", "Defense")]public int ProtectionValueDiceRolls { get => this.state.protectionValueDiceRolls; set => this.state.protectionValueDiceRolls = value; }
        [ShowInInspector, TabGroup("Group 2", "Defense")]public int DiceRollAmount { get => this.state.diceRollAmount; set => this.state.diceRollAmount = value; }
        [ShowInInspector, TabGroup("Group 2", "Defense")]public int ShieldDV { get => this.state.shieldDV; set => this.state.shieldDV = value; }
        [ShowInInspector, TabGroup("Group 2", "Defense")]public int EvadeDV { get => this.state.evadeDV; set => this.state.evadeDV = value; }
        
        [ShowInInspector, TabGroup("Group 2", "Defense")]public double ArmorWeight { get => this.state.armorWeight; set => this.state.armorWeight = value; }
        public bool IsPlayer { get => isPlayer;}

        /// <summary> Adds the character to the list of characters in the game. </summary>
        private void Start() => GameManager.instance.AddCharacter(this.gameObject);

        /// <summary> Save the character's state to a file </summary>
        public void SaveState(string path)
        {
            Scene = GameManager.instance.sceneName; // Set the scene name
            Position = this.gameObject.transform.position; // Set the position
            
            if(!isPlayer){
                IsAggressive = GetComponent<NPCStateManager>().IsAggressive;
                path = Path.Combine(path, GameManager.instance.sceneName);

                if(!Directory.Exists(path)){
                    Directory.CreateDirectory (path); // Create the directory if it doesn't exist
                    Debug.Log("Created directory: " + path);
                }

                path = Path.Combine(path, "NPCS"); //path = C:\Users\User\AppData\LocalLow\DefaultCompany\HumbleRPG\Saves\save\scene\NPCS

                if(!Directory.Exists(path)){
                    Directory.CreateDirectory (path); // Create the directory if it doesn't exist
                    Debug.Log("Created directory: " + path);
                }
            }

            path = Path.Combine(path, CharacterName + ".humble"); //path = C:\Users\User\AppData\LocalLow\DefaultCompany\HumbleRPG\Saves\save\scene\NPCS\CharacterName.humble

            byte[] saveJson = SerializationUtility.SerializeValue(this.state, DataFormat.JSON); //Serialize the state to JSON
            File.WriteAllBytes(path, saveJson); //Save the state to a file

            //Debug.Log("Saved to " + path);
        }

        /// <summary> Load the character's state from a file </summary>
        public bool LoadState(string characterName, string path)
        {
            path = Path.Combine(path, characterName + ".humble"); //path = C:\Users\User\AppData\LocalLow\DefaultCompany\HumbleRPG\Saves\save\scene\NPCS\characterName.humble

            if (!File.Exists(path))
            {
                Debug.LogError("File does not exist");
                return true;
            } 
                
            byte[] loadJson = File.ReadAllBytes(path); //loadJson = byte[]
            this.state = SerializationUtility.DeserializeValue<CharacterState>(loadJson, DataFormat.JSON); //DeserializeValue<T> is a generic method that takes in a byte array and a data format and returns a T.

            this.gameObject.transform.position = this.state.position; //sets the position of the character to the position of the state.

            if(isPlayer)
            {
                this.GetComponent<Player.UIController>().SetHP(this.state.hp, this.state.maxHp); //sets the hp of the player UI to the hp of the state.
                this.GetComponent<Player.UIController>().SetMP(this.state.mp, this.state.maxMp); //sets the mp of the player UI to the mp of the state.
            }

            //Debug.Log("Loaded from " + path);
            return true;
        }
   }

    /// <summary> The state of the character </summary>
    [System.Serializable]
    public class CharacterState
    {
        public string characterName; //The name of the character
        public string characterAlias; //The alias of the character
        public string race; 
        public string gender; 
        public string classPreset; 
        public string religion; 
        public string guild; 

        public int age; 
        public int height; 
        public int weight;
        
        public int level; //The level of the character
        public int experience; //The experience of the character
        public int requiredExperience; //The required experience to level up
        public int gold; //The amount of gold the character has
        public int pp; //The amount of pp the character has
        
        public int strength; //The amount of strength the character has
        public int constitution; //The amount of constitution the character has
        public int dexterity; //The amount of dexterity the character has
        public int intelligence; //The amount of intelligence the character has
        public int willpower; //The amount of willpower the character has
        public int wisdom; //The amount of wisdom the character has
        public int charisma; //The amount of charisma the character has

        public int hp; //The current hp of the character
        public int mp; //The current mp of the character
        public int maxHp; //Max HP is the maximum hp of the character
        public int maxMp; //Max MP is the maximum mp of the character
        public int sanity = 15; //The amount of sanity the character has.
        public int intiative; //The initiative of the character
        public int speed; //The speed of the character
        public int fatigue; //The amount of fatigue the character has
        public int maxFatigue; //The maximum amount of fatigue the character can have
        public int sleepiness = 750; //750 is the default sleepiness value
        public int life; //The amount of life the character has
        public int soul; //The amount of soul the character has
        public int hunger = 10; //How hungry the character is
        public int thirst = 5; //How thirsty the character is

        public int fire; //The amount of fire resistance the character has
        public int cold; //The amount of cold resistance the character has
        public int lightning; //The amount of lightning resistance the character has
        public int nature; //The amount of nature resistance the character has
        public int magic; //The amount of magic resistance the character has
        public int space; //The amount of space resistance the character has
        public int time; //The amount of time resistance the character has
        public int sound; //The amount of sound resistance the character has
        public int chaos; //The amount of chaos resistance the character has

        public int difficulty; //The current difficulty of the game
        public int luck = 5; //The luck of the character
        public int karma = 0; //The amount of karma the character has.
        public int favour = 0; //The amount of favour the character has.
        public int fame = 0; //The amount of fame the character has.

        public List<string> talentList; //List of talents
        public List<string> racialTraits; //List of racial traits

        public Dictionary<string, double> proficiencyDictionary; //Dictionary of the character's proficiencies
        public Dictionary<string, int> skillDictionary; //The dictionary of skills 
        public Dictionary<string, int> spellDictionary; //The dictionary of spells

        public List<Item> inventory; //The inventory of the character
        public List<Item> equipment; //Equipment is a list of items that are equipped to the character.

        public Dictionary<string, int> statusEffects; //Dictionary of status effects and their duration

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
        public int evadeDV; //evade DV is the DV of the character's evasion skill.

        public double armorWeight; //The weight of the armor

        public Vector3 position; //The position of the character

        public string scene; //The scene the character is in
        public string description; //The description of the character
        public bool isAggressive; //If the character is aggressive or not.
        public IState npcState; //The state of the npc
        public bool isDead; //If the character is dead or not.
    }
}