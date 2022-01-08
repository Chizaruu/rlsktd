using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemHelpers.SoftMaterials {
    [System.Serializable]
    public class Rare : Material {
        public enum Material{
            SoftPlastic, Mithril
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
                case Material.Mithril: //As light as silk. (Soft.Common.Silk)
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
                case Material.Mithril:
                    Color = UnityEngine.Color.blue;
                    break;
                default: 
                    Color = UnityEngine.Color.white;
                    break;
            }
        }
    }
}