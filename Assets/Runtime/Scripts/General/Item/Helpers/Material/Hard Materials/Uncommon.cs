using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.HardMaterials {
    [System.Serializable]
    public class Uncommon : Material {
        public enum Material{
            Lunarite, Silver, Steel, Obsidian, Glass, Scale,
            MageWood, MageStone, Emerald, Ruby, Sapphire, Topaz
        }

        [OdinSerialize, UnityEngine.HideInInspector]private Material material;

        [ShowInInspector]public Material _Material
        {
            get => material; set
            {
                material = value;
                Name = value.ToString();
                GetMaterialWeight();
                GetMaterialColor();
            }
        }

        public Uncommon() {
            _Rarity = Rarity.Uncommon;
        }

        public Uncommon(Material material) {
            _Rarity = Rarity.Uncommon;
            _Material = material;
        }

        private void GetMaterialWeight() {
            switch (material) {
                case Material.Silver:
                    Weight = 1.2f;
                    break;
                case Material.Obsidian:
                    Weight = 2f;
                    break;
                case Material.Scale:
                    Weight = 0.3f;
                    break;
                case Material.Glass:
                case Material.Ruby:
                case Material.Sapphire:
                case Material.Topaz:
                    Weight = 0.1f;
                    break;
                default:
                    Weight = 1f;
                    break;
            }
        }
    
        private void GetMaterialColor(){
            switch (material)
            {
                case Material.Lunarite:
                    Color = Support.GetColourFromHex("#ADD8E6");
                    break;
                case Material.Silver:
                case Material.Steel:
                    Color = Support.GetColourFromHex("#c8cece");
                    break;
                case Material.Obsidian:
                    Color = UnityEngine.Color.black;
                    break;
                case Material.Scale:
                case Material.Emerald:
                    Color = UnityEngine.Color.green;
                    break;
                case Material.Ruby:
                    Color = UnityEngine.Color.red;
                    break;
                case Material.Sapphire:
                case Material.MageStone:
                    Color = UnityEngine.Color.blue;
                    break;
                case Material.Topaz:
                case Material.MageWood:
                    Color = UnityEngine.Color.yellow;
                    break;
                default: 
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}