using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.SoftMaterials {
    [System.Serializable]
    public class Epic : Material {
        public enum Material{
            Zylon
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

        public Epic() {
            _Rarity = Rarity.Epic;
        }

        public Epic(Material material) {
            _Rarity = Rarity.Epic;
            _Material = material;
        }

        private void GetMaterialWeight() {
            switch (material) {
                default:
                    Weight = 0.1f;
                    break;
            }
        }
    
        private void GetMaterialColor(){
            switch (material)
            {
                case Material.Zylon:
                    Color = Support.GetColourFromHex("#c8cece");
                    break;
                default:
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}