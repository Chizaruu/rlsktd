using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.HardMaterials{
    [System.Serializable]
    public class Common : Material {
        public enum Material{
            Copper, Tin, Bronze, Iron, Gold, Bone,
            Wood, Stone, Mica, Coral, Sand, HardLeather
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

        public Common() {
            _Rarity = Rarity.Common;
        }

        public Common(Material material) {
            _Rarity = Rarity.Common;
            _Material = material;
        }

        private void GetMaterialWeight() {
            switch (material) {
                case Material.Copper:
                case Material.Tin:
                case Material.Iron:
                case Material.Bronze:
                case Material.Stone:
                    Weight = 1f;
                    break;
                case Material.Gold:
                    Weight = 1.3f;
                    break;
                case Material.Wood:
                    Weight = 0.8f;
                    break;
                case Material.Mica:
                case Material.Sand:
                case Material.Coral:
                case Material.Bone:
                    Weight = 0.3f;
                    break;
                case Material.HardLeather:
                    Weight = 0.5f;
                    break;
                default:
                    Weight = 1f;
                    break;
            }
        }
    
        private void GetMaterialColor(){
            switch (material)
            {
                case Material.Copper:
                    Color = Support.GetColourFromHex("#B87333");
                    break;
                case Material.Tin:
                    Color = Support.GetColourFromHex("#d3d4d5");
                    break;
                case Material.Bronze:
                    Color = Support.GetColourFromHex("#8B4513");
                    break;
                case Material.Iron:
                    Color = Support.GetColourFromHex("#a19d94");
                    break;
                case Material.Gold:
                    Color = Support.GetColourFromHex("#ffd700");
                    break;
                case Material.Wood:
                    Color = Support.GetColourFromHex("#9c8b64");
                    break;
                case Material.Stone:
                    Color = Support.GetColourFromHex("#a19d94");
                    break;
                case Material.Mica:
                    Color = Support.GetColourFromHex("#c8cece");
                    break;
                case Material.Coral:
                    Color = Support.GetColourFromHex("#ff7f50");
                    break;
                case Material.Sand:
                    Color = Support.GetColourFromHex("#f5f5dc");
                    break;
                case Material.HardLeather:
                    Color = Support.GetColourFromHex("#624a2e");
                    break;
                default:  
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}