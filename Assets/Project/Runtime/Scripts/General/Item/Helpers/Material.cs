using UnityEngine;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> /// <summary> The material of an item. </summary>
    [System.Serializable]
    public class Material 
    {
        /// <summary> Enumeration of all materials. </summary>
        public enum ItemMaterial
        {
            /// <summary> The item is made of Copper. </summary>
            Copper,
            /// <summary> The item is made of Tin. </summary>
            Tin,
            /// <summary> The item is made of Bronze. </summary>
            Bronze,
            /// <summary> The item is made of Iron. </summary>
            Iron,
            /// <summary> The item is made of Gold. </summary>
            Gold,
            /// <summary> The item is made of Bone. </summary>
            Bone,
            /// <summary> The item is made of Cloth. </summary>
            Cloth,
            /// <summary> The item is made of Silk. </summary>
            Silk,
            /// <summary> The item is made of Leather. </summary>
            Leather,
            /// <summary> The item is made of Wood. </summary>
            Wood,
            /// <summary> The item is made of Stone. </summary>
            Stone,
            /// <summary> The item is made of Flesh. </summary>
            Flesh,
            /// <summary> The item is made of Paper. </summary>
            Paper,
            /// <summary> The item is made of Mica. </summary>
            Mica,
            /// <summary> The item is made of Coral. </summary>
            Coral,
            /// <summary> The item is made of Sand. </summary>
            Sand,
            /// <summary> The item is made of Lunarite. </summary>
            Lunarite,
            /// <summary> The item is made of Silver. </summary>
            Silver,
            /// <summary> The item is made of Chain. </summary>
            Chain,
            /// <summary> The item is made of Steel. </summary>
            Steel,
            /// <summary> The item is made of Zylon. </summary>
            Zylon,
            /// <summary> The item is made of Obsidian. </summary>
            Obsidian,
            /// <summary> The item is made of Glass. </summary>
            Glass,
            /// <summary> The item is made of Scale. </summary>
            Scale,
            /// <summary> The item is made of Magic Cloth. </summary>
            MagicCloth,
            /// <summary> The item is made of Magic Leather. </summary>
            MagicLeather,
            /// <summary> The item is made of Magic Wood. </summary>
            MagicWood,
            /// <summary> The item is made of Magic Stone. </summary>
            MagicStone,
            /// <summary> The item is made of Emerald. </summary>
            Emerald,
            /// <summary> The item is made of Ruby. </summary>
            Ruby,
            /// <summary> The item is made of Sapphire. </summary>
            Sapphire,
            /// <summary> The item is made of Topaz. </summary>
            Topaz,
            /// <summary> The item is made of Mithril. </summary>
            Mithril,
            /// <summary> The item is made of Adamantium. </summary>
            Adamantium,
            /// <summary> The item is made of Dense Coral. </summary>
            DenseCoral,
            /// <summary> The item is made of Diamond. </summary>
            Diamond,
            /// <summary> The item is made of Opal. </summary>
            Opal,
            /// <summary> The item is made of Amethyst. </summary>
            Amethyst,
            /// <summary> The item is made of Jade. </summary>
            Jade,
            /// <summary> The item is made of Orichalcum. </summary>
            Orichalcum,
            /// <summary> The item is made of Runite. </summary>
            Runite,
            /// <summary> The item is made of Dragonite. </summary>
            Dragonite,
            /// <summary> The item is made of Moonstone. </summary>
            Moonstone,
            /// <summary> The item is made of Sunstone. </summary>
            Sunstone,
            /// <summary> The item is made of Onyx. </summary>
            Onyx,
            
        }

        /// <summary> The material of the item. </summary>
        public ItemMaterial itemMaterial;

        public Material(ItemMaterial itemMaterial)
        {
            this.itemMaterial = itemMaterial;
        }

        /// <summary> Get the color of the material. (Incomplete)</summary>
        /// <returns> The color of the material. </returns>
        public Color GetColor()
        {
            switch (itemMaterial)
            {
                case ItemMaterial.Copper:
                    return new Color(0.8f, 0.5f, 0.2f);
                case ItemMaterial.Tin:
                    return new Color(0.8f, 0.8f, 0.2f);
                case ItemMaterial.Bronze:
                    return new Color(0.8f, 0.5f, 0.2f);
                case ItemMaterial.Iron:
                    return new Color(0.8f, 0.8f, 0.8f);
                case ItemMaterial.Gold:
                    return new Color(1f, 0.8f, 0.2f);
                case ItemMaterial.Leather:
                    return new Color(0.5f, 0.5f, 0.5f);
                case ItemMaterial.Wood:
                    return new Color(0.5f, 0.5f, 0.5f);
                case ItemMaterial.Stone:
                    return new Color(0.5f, 0.5f, 0.5f);

                default:
                    return Color.white;
            }
        }       

        /// <summary> Returns the name of the material as a string. </summary>
        /// <returns> The name of the material as a string. </returns>
        public override string ToString()
        {
            switch (itemMaterial)
            {
                case ItemMaterial.Copper:
                    return "Copper";
                case ItemMaterial.Tin:
                    return "Tin";
                case ItemMaterial.Bronze:
                    return "Bronze";
                case ItemMaterial.Iron:
                    return "Iron";
                case ItemMaterial.Gold:
                    return "Gold";
                case ItemMaterial.Bone:
                    return "Bone";
                case ItemMaterial.Cloth:
                    return "Cloth";
                case ItemMaterial.Silk:
                    return "Silk";
                case ItemMaterial.Leather:
                    return "Leather";
                case ItemMaterial.Wood:
                    return "Wood";
                case ItemMaterial.Stone:
                    return "Stone";
                case ItemMaterial.Flesh:
                    return "Flesh";
                case ItemMaterial.Paper:
                    return "Paper";
                case ItemMaterial.Mica:
                    return "Mica";
                case ItemMaterial.Coral:
                    return "Coral";
                case ItemMaterial.Sand:
                    return "Sand";
                case ItemMaterial.Lunarite:
                    return "Lunarite";
                case ItemMaterial.Silver:
                    return "Silver";
                case ItemMaterial.Chain:
                    return "Chain";
                case ItemMaterial.Steel:
                    return "Steel";
                case ItemMaterial.Zylon:
                    return "Zylon";
                case ItemMaterial.Obsidian:
                    return "Obsidian";
                case ItemMaterial.Glass:
                    return "Glass";
                case ItemMaterial.Scale:
                    return "Scale";
                case ItemMaterial.MagicCloth:
                    return "Magic Cloth";
                case ItemMaterial.MagicLeather:
                    return "Magic Leather";
                case ItemMaterial.MagicWood:
                    return "Magic Wood";
                case ItemMaterial.MagicStone:
                    return "Magic Stone";
                case ItemMaterial.Emerald:
                    return "Emerald";
                case ItemMaterial.Ruby:
                    return "Ruby";
                case ItemMaterial.Sapphire:
                    return "Sapphire";
                case ItemMaterial.Topaz:  
                    return "Topaz";
                case ItemMaterial.Mithril: 
                    return "Mithril";
                case ItemMaterial.Adamantium:
                    return "Adamantium";
                case ItemMaterial.DenseCoral:   
                    return "Dense Coral";
                case ItemMaterial.Diamond:  
                    return "Diamond";
                case ItemMaterial.Opal:
                    return "Opal";
                case ItemMaterial.Amethyst:
                    return "Amethyst";
                case ItemMaterial.Jade:
                    return "Jade";
                case ItemMaterial.Orichalcum:
                    return "Orichalcum";
                case ItemMaterial.Runite:
                    return "Runite";
                case ItemMaterial.Dragonite:
                    return "Dragonite";
                case ItemMaterial.Moonstone:
                    return "Moonstone";
                case ItemMaterial.Sunstone:
                    return "Sunstone";
                case ItemMaterial.Onyx:
                    return "Onyx";
                default:
                    return "";
            }
        }
    
        /// <summary> Returns the item material as an int. </summary>
        /// <returns> The item material as an int. </returns>
        public int ToInt() {
            switch (itemMaterial)
            {
                case ItemMaterial.Copper:
                    return 0;
                case ItemMaterial.Tin:
                    return 1;
                case ItemMaterial.Bronze:
                    return 2;
                case ItemMaterial.Iron:
                    return 3;
                case ItemMaterial.Gold:
                    return 4;
                case ItemMaterial.Bone:
                    return 5;
                case ItemMaterial.Cloth:
                    return 6;
                case ItemMaterial.Silk:
                    return 7;
                case ItemMaterial.Leather:
                    return 8;
                case ItemMaterial.Wood:
                    return 9;
                case ItemMaterial.Stone:
                    return 10;
                case ItemMaterial.Flesh:
                    return 11;
                case ItemMaterial.Paper:
                    return 12;
                case ItemMaterial.Mica:
                    return 13;
                case ItemMaterial.Coral:
                    return 14;
                case ItemMaterial.Sand:
                    return 15;
                case ItemMaterial.Lunarite:
                    return 16;
                case ItemMaterial.Silver:
                    return 17;
                case ItemMaterial.Chain:
                    return 18;
                case ItemMaterial.Steel:
                    return 19;
                case ItemMaterial.Zylon:
                    return 20;
                case ItemMaterial.Obsidian:
                    return 21;
                case ItemMaterial.Glass:
                    return 22;
                case ItemMaterial.Scale:
                    return 23;
                case ItemMaterial.MagicCloth:
                    return 24;
                case ItemMaterial.MagicLeather:
                    return 25;
                case ItemMaterial.MagicWood:
                    return 26;
                case ItemMaterial.MagicStone:
                    return 27;
                case ItemMaterial.Emerald:
                    return 28;
                case ItemMaterial.Ruby:
                    return 29;
                case ItemMaterial.Sapphire:
                    return 30;
                case ItemMaterial.Topaz:
                    return 31;
                case ItemMaterial.Mithril:
                    return 32;
                case ItemMaterial.Adamantium:
                    return 33;
                case ItemMaterial.DenseCoral:
                    return 34;
                case ItemMaterial.Diamond:
                    return 35;
                case ItemMaterial.Opal:
                    return 36;
                case ItemMaterial.Amethyst:
                    return 37;
                case ItemMaterial.Jade:
                    return 38;
                case ItemMaterial.Orichalcum:
                    return 39;
                case ItemMaterial.Runite:
                    return 40;
                case ItemMaterial.Dragonite:
                    return 41;
                case ItemMaterial.Moonstone:
                    return 42;
                case ItemMaterial.Sunstone:
                    return 43;
                case ItemMaterial.Onyx:
                    return 44;
                default:
                    return 0;
            }
        }
    }
}