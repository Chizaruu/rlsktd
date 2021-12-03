using UnityEngine;

namespace RLSKTD.General.ItemHelpers {
  /// <summary> /// <summary> The material of an item. </summary>
    public class Material {
        /// <summary> Types of all materials. </summary>
        public enum MaterialEnum {
            /// <summary> (Common) The material is Organic. </summary>
            Organic,
            /// <summary> (Common) The material is Copper. </summary>
            Copper,
            /// <summary> (Common) The material is Tin. </summary>
            Tin,
            /// <summary> (Common) The material is Bronze. </summary>
            Bronze,
            /// <summary> (Common) The material is Iron. </summary>
            Iron,
            /// <summary> (Common) The material is Gold. </summary>
            Gold,
            /// <summary> (Common) The material is Bone. </summary>
            Bone,
            /// <summary> (Common) The material is Cloth. </summary>
            Cloth,
            /// <summary> (Common) The material is Silk. </summary>
            Silk,
            /// <summary> (Common) The material is Leather. </summary>
            Leather,
            /// <summary> (Common) The material is Wood. </summary>
            Wood,
            /// <summary> (Common) The material is Stone. </summary>
            Stone,
            /// <summary> (Common) The material is Flesh. </summary>
            Flesh,
            /// <summary> (Common) The material is Paper. </summary>
            Paper,
            /// <summary> (Common) The material is Mica. </summary>
            Mica,
            /// <summary> (Common) The material is Coral. </summary>
            Coral,
            /// <summary> (Common) The material is Sand. </summary>
            Sand,
            /// <summary> (Uncommon) The material is Lunarite. </summary>
            Lunarite,
            /// <summary> (Uncommon) The material is Silver. </summary>
            Silver,
            /// <summary> (Uncommon) The material is Steel. </summary>
            Steel,
            /// <summary> (Uncommon) The material is Obsidian. </summary>
            Obsidian,
            /// <summary> (Uncommon) The material is Glass. </summary>
            Glass,
            /// <summary> (Uncommon) The material is Scale. </summary>
            Scale,
            /// <summary> (Uncommon) The material is Magic Cloth. </summary>
            MagicCloth,
            /// <summary> (Uncommon) The material is Magic Leather. </summary>
            MagicLeather,
            /// <summary> (Uncommon) The material is Magic Wood. </summary>
            MagicWood,
            /// <summary> (Uncommon) The material is Magic Stone. </summary>
            MagicStone,
            /// <summary> (Uncommon) The material is Emerald. </summary>
            Emerald,
            /// <summary> (Uncommon) The material is Ruby. </summary>
            Ruby,
            /// <summary> (Uncommon) The material is Sapphire. </summary>
            Sapphire,
            /// <summary> (Uncommon) The material is Topaz. </summary>
            Topaz,
            /// <summary> (Rare) The material is Mithril. </summary>
            Mithril,
            /// <summary> (Rare) The material is Adamantium. </summary>
            Adamantium,
            /// <summary> (Rare) The material is Dense Coral. </summary>
            DenseCoral,
            /// <summary> (Rare) The material is Diamond. </summary>
            Diamond,
            /// <summary> (Rare) The material is Opal. </summary>
            Opal,
            /// <summary> (Rare) The material is Amethyst. </summary>
            Amethyst,
            /// <summary> (Rare) The material is Jade. </summary>
            Jade,
            /// <summary> (Epic) The material is Orichalcum. </summary>
            Orichalcum,
            /// <summary> (Epic) The material is Runite. </summary>
            Runite,
            /// <summary> (Epic) The material is Dragonite. </summary>
            Dragonite,
            /// <summary> (Epic) The material is Moonstone. </summary>
            Moonstone,
            /// <summary> (Epic) The material is Sunstone. </summary>
            Sunstone,
            /// <summary> (Epic) The material is Onyx. </summary>
            Onyx,
            /// <summary> (Epic) The material is Zylon. </summary>
            Zylon,
        }

        /// <summary> The material of the item. </summary>
        private MaterialEnum materialEnum;

        public MaterialEnum _MaterialEnum { get => materialEnum; set => materialEnum = value; }

        public Material(MaterialEnum materialEnum) => this.materialEnum = materialEnum;

        public static float GetMaterialWeight(MaterialEnum materialEnum) {
            switch (materialEnum) {
                case MaterialEnum.Copper:
                    return 1f;
                case MaterialEnum.Tin:
                    return 1f;
                case MaterialEnum.Bronze:
                    return 1.2f;
                case MaterialEnum.Iron:
                    return 1f;
                case MaterialEnum.Gold:
                    return 1f;
                case MaterialEnum.Bone:
                    return 0.2f;
                case MaterialEnum.Cloth:
                    return 0.25f;
                case MaterialEnum.Silk:
                    return 0.25f;
                case MaterialEnum.Leather:
                    return 0.8f;
                case MaterialEnum.Wood:
                    return 1.2f;
                case MaterialEnum.Stone:
                    return 1f;
                case MaterialEnum.Flesh:
                    return 0.55f;
                case MaterialEnum.Mica:
                    return 0.6f;
                case MaterialEnum.Coral:
                    return 0.3f;
                case MaterialEnum.Sand:
                    return 0.5f;
                case MaterialEnum.Lunarite:
                    return 1f;
                case MaterialEnum.Silver:
                    return 0.5f;
                case MaterialEnum.Steel:
                    return 1.5f;
                case MaterialEnum.Zylon:
                    return 0.5f;
                case MaterialEnum.Obsidian:
                    return 2f;
                case MaterialEnum.Scale:
                    return 0.3f;
                case MaterialEnum.MagicLeather:
                    return 0.7f;
                case MaterialEnum.MagicWood:
                    return 0.8f;
                case MaterialEnum.MagicStone:
                    return 1.5f;
                case MaterialEnum.Adamantium:
                    return 1.7f;
                case MaterialEnum.DenseCoral:
                    return 0.9f;
                case MaterialEnum.Orichalcum:
                    return 1.9f;
                case MaterialEnum.Runite:
                    return 1.9f;
                case MaterialEnum.Dragonite:
                    return 2f;
                case MaterialEnum.Moonstone:
                    return 1.5f;
                case MaterialEnum.Sunstone:
                    return 1.5f;
                default:
                    return 0.1f;
            }
        }
    
        public static UnityEngine.Color GetMaterialColor(MaterialEnum materialEnum){
            switch (materialEnum)
            {
                case MaterialEnum.Organic:
                    return UnityEngine.Color.white;
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