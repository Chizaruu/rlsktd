using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.HardMaterials {
    [System.Serializable]
    public class Epic : Material {
        public enum Material{
            Orichalcum, Runite, Dragonite, Moonstone, Sunstone,
            Onyx
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
                case Material.Orichalcum:
                case Material.Runite:
                    Weight = 1.9f;
                    break;
                case Material.Dragonite:
                    Weight = 2f;
                    break;
                case Material.Moonstone:
                case Material.Sunstone:
                    Weight = 1.5f;
                    break;
                case Material.Onyx:
                    Weight = 0.3f;
                    break;
                default:
                    Weight = 1f;
                    break;
            }
        }
    
        private void GetMaterialColor(){
            switch (material)
            {
                case Material.Orichalcum:
                    Color = Support.GetColourFromHex("#DFBB90");
                    break;
                case Material.Runite:
                    Color = Support.GetColourFromHex("#6699CC");
                    break;
                case Material.Dragonite:
                    Color = Support.GetColourFromHex("#F1B46D");
                    break;
                case Material.Moonstone:
                    Color = Support.GetColourFromHex("#ADD8E6");
                    break;
                case Material.Sunstone:
                    Color = Support.GetColourFromHex("#e7c4ac");
                    break;
                case Material.Onyx:
                    Color = Support.GetColourFromHex("#353935");
                    break;
                default:
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}