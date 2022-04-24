using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.SoftMaterials {
    [System.Serializable]
    public class Common : Material {
        public enum Material{
            Organic, Cloth, Silk, SoftLeather, Flesh, Paper
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
                case Material.Cloth:
                case Material.Silk:
                    Weight = 0.25f;
                    break;
                case Material.Flesh:
                case Material.SoftLeather:
                    Weight = 0.55f;
                    break;
                default:
                    Weight = 0.1f;
                    break;
            }
        }
    
        private void GetMaterialColor(){
            switch (material)
            {
                case Material.Paper:
                case Material.Silk:
                    Color = Support.GetColourFromHex("#f5f5dc");
                    break;
                case Material.SoftLeather:
                    Color = Support.GetColourFromHex("#624a2e");
                    break;
                case Material.Flesh:
                    Color = UnityEngine.Color.red;
                    break;
                default:
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}