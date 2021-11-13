using UnityEngine;
using Sirenix.OdinInspector;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> /// <summary> The material of an item. </summary>
    [System.Serializable]
    public class Material 
    {
        /// <summary> Enumeration of all materials. </summary>
        public enum MaterialEnum
        {
            /// <summary> (Common) The item is made of Copper. </summary>
            Copper,
            /// <summary> (Common) The item is made of Tin. </summary>
            Tin,
            /// <summary> (Common) The item is made of Bronze. </summary>
            Bronze,
            /// <summary> (Common) The item is made of Iron. </summary>
            Iron,
            /// <summary> (Common) The item is made of Gold. </summary>
            Gold,
            /// <summary> (Common) The item is made of Bone. </summary>
            Bone,
            /// <summary> (Common) The item is made of Cloth. </summary>
            Cloth,
            /// <summary> (Common) The item is made of Silk. </summary>
            Silk,
            /// <summary> (Common) The item is made of Leather. </summary>
            Leather,
            /// <summary> (Common) The item is made of Wood. </summary>
            Wood,
            /// <summary> (Common) The item is made of Stone. </summary>
            Stone,
            /// <summary> (Common) The item is made of Flesh. </summary>
            Flesh,
            /// <summary> (Common) The item is made of Paper. </summary>
            Paper,
            /// <summary> (Common) The item is made of Mica. </summary>
            Mica,
            /// <summary> (Common) The item is made of Coral. </summary>
            Coral,
            /// <summary> (Common) The item is made of Sand. </summary>
            Sand,
            /// <summary> (Uncommon) The item is made of Lunarite. </summary>
            Lunarite,
            /// <summary> (Uncommon) The item is made of Silver. </summary>
            Silver,
            /// <summary> (Uncommon) The item is made of Chain. </summary>
            Chain,
            /// <summary> (Uncommon) The item is made of Steel. </summary>
            Steel,
            /// <summary> (Uncommon) The item is made of Zylon. </summary>
            Zylon,
            /// <summary> (Uncommon) The item is made of Obsidian. </summary>
            Obsidian,
            /// <summary> (Uncommon) The item is made of Glass. </summary>
            Glass,
            /// <summary> (Uncommon) The item is made of Scale. </summary>
            Scale,
            /// <summary> (Uncommon) The item is made of Magic Cloth. </summary>
            MagicCloth,
            /// <summary> (Uncommon) The item is made of Magic Leather. </summary>
            MagicLeather,
            /// <summary> (Uncommon) The item is made of Magic Wood. </summary>
            MagicWood,
            /// <summary> (Uncommon) The item is made of Magic Stone. </summary>
            MagicStone,
            /// <summary> (Uncommon) The item is made of Emerald. </summary>
            Emerald,
            /// <summary> (Uncommon) The item is made of Ruby. </summary>
            Ruby,
            /// <summary> (Uncommon) The item is made of Sapphire. </summary>
            Sapphire,
            /// <summary> (Uncommon) The item is made of Topaz. </summary>
            Topaz,
            /// <summary> (Rare) The item is made of Mithril. </summary>
            Mithril,
            /// <summary> (Rare) The item is made of Adamantium. </summary>
            Adamantium,
            /// <summary> (Rare) The item is made of Dense Coral. </summary>
            DenseCoral,
            /// <summary> (Rare) The item is made of Diamond. </summary>
            Diamond,
            /// <summary> (Rare) The item is made of Opal. </summary>
            Opal,
            /// <summary> (Rare) The item is made of Amethyst. </summary>
            Amethyst,
            /// <summary> (Rare) The item is made of Jade. </summary>
            Jade,
            /// <summary> (Epic) The item is made of Orichalcum. </summary>
            Orichalcum,
            /// <summary> (Epic) The item is made of Runite. </summary>
            Runite,
            /// <summary> (Epic) The item is made of Dragonite. </summary>
            Dragonite,
            /// <summary> (Epic) The item is made of Moonstone. </summary>
            Moonstone,
            /// <summary> (Epic) The item is made of Sunstone. </summary>
            Sunstone,
            /// <summary> (Epic) The item is made of Onyx. </summary>
            Onyx,
        }

        /// <summary> The material of the item. </summary>
        [SerializeField, HideInInspector]
        private MaterialEnum itemMaterial;
        
        [ShowInInspector] 
        public MaterialEnum ItemMaterial { get => itemMaterial; set => itemMaterial = value; }

        public Material(MaterialEnum itemMaterial)
        {
            this.itemMaterial = itemMaterial;
            
        }

        /// <summary> Get the color of the material. (Incomplete)</summary>
        /// <returns> The color of the material. </returns>
        public Color GetMaterialColor()
        {
            switch (itemMaterial)
            {
                case MaterialEnum.Copper:
                    return new Color(0.8f, 0.5f, 0.2f);
                case MaterialEnum.Tin:
                    return new Color(0.8f, 0.8f, 0.2f);
                case MaterialEnum.Bronze:
                    return new Color(0.8f, 0.5f, 0.2f);
                case MaterialEnum.Iron:
                    return new Color(0.8f, 0.8f, 0.8f);
                case MaterialEnum.Gold:
                    return new Color(1f, 0.8f, 0.2f);
                case MaterialEnum.Leather:
                    return new Color(0.5f, 0.5f, 0.5f);
                case MaterialEnum.Wood:
                    return new Color(0.5f, 0.5f, 0.5f);
                case MaterialEnum.Stone:
                    return new Color(0.5f, 0.5f, 0.5f);

                default:
                    return Color.white;
            }
        }       
    }
}