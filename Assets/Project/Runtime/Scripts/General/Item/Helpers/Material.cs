using UnityEngine;

namespace RLSKTD.General.Item.Helpers {
  /// <summary> /// <summary> The material of an item. </summary>
    public class Material {
        /// <summary> Types of all materials. </summary>
        public enum MaterialEnum {
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
            /// <summary> (Epic) The item is made of Zylon. </summary>
            Zylon,
        }

        /// <summary> The material of the item. </summary>
        private MaterialEnum materialEnum;

        public MaterialEnum _MaterialEnum { get => materialEnum; set => materialEnum = value; }

        public Material(MaterialEnum materialEnum) => this.materialEnum = materialEnum;

        public static float GetMaterialWeight(MaterialEnum materialEnum) {
            switch (materialEnum) {
                case MaterialEnum.Copper:
                    return 0.1f;
                case MaterialEnum.Tin:
                    return 0.1f;
                case MaterialEnum.Bronze:
                    return 0.2f;
                case MaterialEnum.Iron:
                    return 0.3f;
                case MaterialEnum.Gold:
                    return 0.4f;
                case MaterialEnum.Bone:
                    return 0.5f;
                case MaterialEnum.Cloth:
                    return 0.6f;
                case MaterialEnum.Silk:
                    return 0.7f;
                case MaterialEnum.Leather:
                    return 0.8f;
                case MaterialEnum.Wood:
                    return 0.9f;
                case MaterialEnum.Stone:
                    return 1.0f;
                case MaterialEnum.Flesh:
                    return 1.1f;
                case MaterialEnum.Paper:
                    return 1.2f;
                case MaterialEnum.Mica:
                    return 1.3f;
                case MaterialEnum.Coral:
                    return 1.4f;
                case MaterialEnum.Sand:
                    return 1.5f;
                case MaterialEnum.Lunarite:
                    return 1.6f;
                case MaterialEnum.Silver:
                    return 1.7f;
                case MaterialEnum.Chain:
                    return 1.8f;
                case MaterialEnum.Steel:
                    return 1.9f;
                case MaterialEnum.Zylon:
                    return 2.0f;
                case MaterialEnum.Obsidian:
                    return 2.1f;
                case MaterialEnum.Glass:
                    return 2.2f;
                case MaterialEnum.Scale:
                    return 2.3f;
                case MaterialEnum.MagicCloth:
                    return 2.4f;
                case MaterialEnum.MagicLeather:
                    return 2.5f;
                case MaterialEnum.MagicWood:
                    return 2.6f;
                case MaterialEnum.MagicStone:
                    return 2.7f;
                case MaterialEnum.Emerald:
                    return 2.8f;
                case MaterialEnum.Ruby:
                    return 2.9f;
                case MaterialEnum.Sapphire:
                    return 3.0f;
                case MaterialEnum.Topaz:
                    return 3.1f;
                case MaterialEnum.Mithril:
                    return 3.2f;
                case MaterialEnum.Adamantium:
                    return 3.3f;
                case MaterialEnum.DenseCoral:
                    return 3.4f;
                case MaterialEnum.Diamond:
                    return 3.5f;
                case MaterialEnum.Opal:
                    return 3.6f;
                case MaterialEnum.Amethyst:
                    return 3.7f;
                case MaterialEnum.Jade:
                    return 3.8f;
                case MaterialEnum.Orichalcum:
                    return 3.9f;
                case MaterialEnum.Runite:
                    return 4.0f;
                case MaterialEnum.Dragonite:
                    return 4.1f;
                case MaterialEnum.Moonstone:
                    return 4.2f;
                case MaterialEnum.Sunstone:
                    return 4.3f;
                case MaterialEnum.Onyx:
                    return 4.4f;
                default:
                    return 0.0f;
            }
        }
    
        public static UnityEngine.Color GetMaterialColor(MaterialEnum materialEnum){
            switch (materialEnum)
            {
                case MaterialEnum.Copper:
                    return GetColourFromHex("#B87333");
                case MaterialEnum.Tin:
                    return GetColourFromHex("#d3d4d5");
                case MaterialEnum.Bronze:
                    return GetColourFromHex("#8B4513");
                case MaterialEnum.Iron:
                    return GetColourFromHex("#a19d94");
                case MaterialEnum.Gold:
                    return GetColourFromHex("#ffd700");
                case MaterialEnum.Bone:
                    return UnityEngine.Color.white;
                case MaterialEnum.Cloth:
                    return GetColourFromHex("#f5f5dc");
                case MaterialEnum.Silk:
                    return GetColourFromHex("#f5f5dc");
                case MaterialEnum.Leather:
                    return GetColourFromHex("#624a2e");
                case MaterialEnum.Wood:
                    return GetColourFromHex("#9c8b64");
                case MaterialEnum.Stone:
                    return GetColourFromHex("#a19d94");
                case MaterialEnum.Flesh:
                    return UnityEngine.Color.red;
                case MaterialEnum.Paper:
                    return GetColourFromHex("#f5f5dc");
                case MaterialEnum.Mica:
                    return GetColourFromHex("#c8cece");
                case MaterialEnum.Coral:
                    return GetColourFromHex("#ff7f50");
                case MaterialEnum.Sand:
                    return GetColourFromHex("#f5f5dc");
                case MaterialEnum.Lunarite:
                    return GetColourFromHex("#ADD8E6");
                case MaterialEnum.Silver:
                    return GetColourFromHex("#c8cece");
                case MaterialEnum.Chain:
                    return GetColourFromHex("#c8cece");
                case MaterialEnum.Steel:
                    return GetColourFromHex("#c8cece");
                case MaterialEnum.Zylon:
                    return GetColourFromHex("#c8cece");
                case MaterialEnum.Obsidian:
                    return UnityEngine.Color.black;
                case MaterialEnum.Glass:
                    return UnityEngine.Color.white;
                case MaterialEnum.Scale:
                    return UnityEngine.Color.green;
                case MaterialEnum.MagicCloth:
                    return GetColourFromHex("#ADD8E6");
                case MaterialEnum.MagicLeather:
                    return GetColourFromHex("#624a2e");
                case MaterialEnum.MagicWood:
                    return GetColourFromHex("#9c8b64");
                case MaterialEnum.MagicStone:
                    return GetColourFromHex("#a19d94");
                case MaterialEnum.Emerald:
                    return UnityEngine.Color.green;
                case MaterialEnum.Ruby:
                    return UnityEngine.Color.red;
                case MaterialEnum.Sapphire:
                    return UnityEngine.Color.blue;
                case MaterialEnum.Topaz:
                    return UnityEngine.Color.yellow;
                case MaterialEnum.Mithril:
                    return UnityEngine.Color.blue;
                case MaterialEnum.Adamantium:
                    return UnityEngine.Color.green;
                case MaterialEnum.DenseCoral:
                    return GetColourFromHex("#ff7f50");
                case MaterialEnum.Diamond:
                    return UnityEngine.Color.white;
                case MaterialEnum.Opal:
                    return UnityEngine.Color.white;
                case MaterialEnum.Amethyst:
                    return GetColourFromHex("#9966cc");
                case MaterialEnum.Jade:
                    return GetColourFromHex("#00A36C");
                case MaterialEnum.Orichalcum:
                    return GetColourFromHex("#DFBB90");
                case MaterialEnum.Runite:
                    return GetColourFromHex("#6699CC");
                case MaterialEnum.Dragonite:
                    return GetColourFromHex("#6699CC");
                case MaterialEnum.Moonstone:
                    return GetColourFromHex("#ADD8E6");
                case MaterialEnum.Sunstone:
                    return GetColourFromHex("#e7c4ac");
                case MaterialEnum.Onyx:
                    return GetColourFromHex("#353935");
                default: UnityEngine.Debug.Log("RandomItemGenerator: GetMaterialColor: RandomMaterial out of range"); 
                    return UnityEngine.Color.white;
            }
        }

        private static Color GetColourFromHex(string v)
        {
            Color color;
            if (UnityEngine.ColorUtility.TryParseHtmlString(v, out color))
            {
                return color;
            } else
            {
                UnityEngine.Debug.Log("RandomItemGenerator: GetColourFromHex: Could not parse colour from string");
                return UnityEngine.Color.white;
            }
        }
    }
}