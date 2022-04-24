using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.HardMaterials {
    [System.Serializable]
    public class Rare : Material {
        public enum Material{
            Adamantium, DenseCoral, Diamond, Opal, Amethyst, Jade, HardPlastic
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

        public Rare() {
            _Rarity = Rarity.Rare;
        }

        public Rare(Material material) {
            _Rarity = Rarity.Rare;
            _Material = material;
        }

        private void GetMaterialWeight() {
            switch (material) {
                case Material.Adamantium:
                    Weight = 1.7f;
                    break;
                case Material.DenseCoral:
                    Weight = 0.9f;
                    break;
                case Material.Diamond:
                case Material.Opal:
                case Material.Amethyst:
                case Material.Jade:
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
                case Material.Adamantium:
                    Color = UnityEngine.Color.green;
                    break;
                case Material.DenseCoral:
                    Color = Support.GetColourFromHex("#ff7f50");
                    break;
                case Material.Amethyst:
                    Color = Support.GetColourFromHex("#9966cc");
                    break;
                case Material.Jade:
                    Color = Support.GetColourFromHex("#00A36C");
                    break;
                default:
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}