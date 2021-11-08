using System.Collections.Generic;
using UnityEngine;

/// <summary> Generators for Character Generation. </summary>
namespace RLSKTD.Character.Generators
{
    /// <summary> Generates Aliases for Character. </summary>
    sealed class AliasGenerator
    {
        /// <summary> A list of all possible first words. </summary>
        static private List<string> firstWord = new List<string>()
        {
            "Nifty", "Fantastic", "Rapid", "Smooth", "Vengeful",
            "Cool", "Dramatic", "Righteous", "Eager", "Electric",
            "Scarlet", "Kind", "Quantum", "Nimble", "Fearless",
            "Colossal", "Purple", "Fancy", "Honorable", "Outrageous",
            "Ancient", "Crimson", "Awesome", "Silver", "Confident",
            "Hypnotic", "Voiceless", "Merciful", "Clever", "Incredible",
            "Dark", "Golden", "Brave", "Hefty", "Bronze",
            "Flawless", "Distant", "Misty", "Perfect", "Alert",
            "Good", "Brief", "Keen", "Feisty", "Jolly",
            "Volatile", "Putrid", "Fragile", "Impure", "Heavenly",
            "Royal", "Hidden", "Elegant", "Crazy", "Ethereal",
            "Angelic", "Defiant", "Fallen", "Ratchet", "Grave",
            "Onyx", "Lucky", "Discount", "Fiery", "Savage",
            "Pouncing", "Glorious", "Resplendent", "Brilliant", "Blazing", 
            "Magnificent", "Forbidden", "Agile", "Majestic", "Beloved",
            "Crescent", "Deadly", "Careless", "Expert", "Mysterious",
            "Pure", "Thundering", "Living", "Reckless", "Dancing",
            "Vile",
        };

        /// <summary> A list of all possible second words. </summary>
        static private List<string> secondWord = new List<string>()
        {
            "Spectre", "Jackal", "Protector", "Defender", "Gunner",
            "Master", "Assassin",  "Smasher", "Masquerade", "Dazzler",
            "Agent", "Gladiator", "Phoenix", "Phantom", "Mage",
            "Storm", "Enchanter", "Conjurer", "Amazon", "Genius",
            "Professor", "Captain", "Omen", "Seer", "Shade",
            "Warden", "Commander", "Ghost", "Vulture",
            "Demon", "Maid", "Mastermind", "Spirit", "Doctor",
            "Shadow", "Diamond", "Flame", "Shark", "Prodigy",
            "Sparrow", "Crow", "Yeti", "Tiger", "Saviour",
            "Mute", "Quill", "Edge", "Dusk", "Mite",
            "Desire", "Trixy", "Wither", "Visage", "Silence",
            "Lynch", "Angel", "Hope", "Robin", "Mime", 
            "Lupus", "Boomer", "Venom", "Hex", "Mongrel",
            "Taint", "Thorne", "Rogue", "Retch", "Fiend",
            "Cloak", "Viper", "Totem", "Scar", "Myth",
            "Hound", "Titan", "Brute", "Savage", "Stranger",
            "Raven", "Blaze", "Haze", "Dead", "Silencer",
            "Dilemma", "Wendigo", "Blink", "Barb", "Mince",
            "Sentinel", "Rocket", "Crook", "Venin", "Nightshade",
            "Diablo", "Rascal", "Predator", "Typhoon", "Leech",
            "Twin", "Blessing", "Star", "Illusion", "Leech"
        };

        /// <summary> Generates random aliases. </summary>
        /// <param name="aliasList"> The number of aliases to generate. </param>
        /// <returns> A list of random aliases. </returns>
        static public List<string> GenerateAliases(List<string> aliasList)
        {
            aliasList = new List<string>(); // Initialize alias list.
    
            //Generate 16 random aliases.
            for(int i = 0; i < 16; i++)
            {
                aliasList.Add(firstWord[Random.Range(0, firstWord.Count)] 
                + " " + secondWord[Random.Range(0, secondWord.Count)]); // Add alias to list.
            }

            return aliasList; // Return alias list.
        }
    }
}

