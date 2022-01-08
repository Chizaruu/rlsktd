using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.SoftMaterials {
    [System.Serializable]
    public class Uncommon : Material {
        public enum Material{
            MageCloth, MageLeather
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
                case Material.MageLeather:
                case Material.MageCloth:
                    Weight = 0.25f;
                    break;
                default:
                    Weight = 0.1f;
                    break;
            }
        }
    
        private void GetMaterialColor(){
            switch (material)
            {
                case Material.MageCloth:
                    Color = Support.GetColourFromHex("#ADD8E6"); //Light Blue
                    break;
                case Material.MageLeather:
                    Color = Support.GetColourFromHex("#8c7356"); //Slightly lighter than regular leather
                    break;
                default: 
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}