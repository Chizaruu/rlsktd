using UnityEngine;

namespace RLSKTD.General.ItemHelpers{
    public class MaterialGenerator{
        /// <summary> Generates a random material</summary>
        public static Material Generate(bool isRandom, bool isHard){
            if (isRandom)
            {
                isHard = Random.Range(0, 2) == 0; // 50% chance of being hard
            }

            switch (isHard){
                case true :
                    switch ((Material.Rarity)Random.Range(0, System.Enum.GetNames(typeof(Material.Rarity)).Length)){
                        case Material.Rarity.Common:
                            return new HardMaterials.Common(
                                (HardMaterials.Common.Material)Random.Range(0, System.Enum.GetNames(typeof(HardMaterials.Common.Material)).Length)
                                );
                        case Material.Rarity.Uncommon:
                            return new HardMaterials.Uncommon(
                                (HardMaterials.Uncommon.Material)Random.Range(0, System.Enum.GetNames(typeof(HardMaterials.Uncommon.Material)).Length)
                                );
                        case Material.Rarity.Rare:
                            return new HardMaterials.Rare(
                                (HardMaterials.Rare.Material)Random.Range(0, System.Enum.GetNames(typeof(HardMaterials.Rare.Material)).Length)
                                );
                        case Material.Rarity.Epic:
                            return new HardMaterials.Epic(
                                (HardMaterials.Epic.Material)Random.Range(0, System.Enum.GetNames(typeof(HardMaterials.Epic.Material)).Length)
                                );
                        default : Debug.Log("RandomItemGenerator: GenerateMaterial: Material rarity not found"); return null;
                    }    
                case false:
                    switch ((Material.Rarity)Random.Range(0, System.Enum.GetNames(typeof(Material.Rarity)).Length)){
                        case Material.Rarity.Common:
                            return new SoftMaterials.Common(
                                (SoftMaterials.Common.Material)Random.Range(0, System.Enum.GetNames(typeof(SoftMaterials.Common.Material)).Length)
                                );
                        case Material.Rarity.Uncommon:
                            return new SoftMaterials.Uncommon(
                                (SoftMaterials.Uncommon.Material)Random.Range(0, System.Enum.GetNames(typeof(SoftMaterials.Uncommon.Material)).Length)
                                );
                        case Material.Rarity.Rare:
                            return new SoftMaterials.Rare(
                                (SoftMaterials.Rare.Material)Random.Range(0, System.Enum.GetNames(typeof(SoftMaterials.Rare.Material)).Length)
                                );
                        case Material.Rarity.Epic:
                            return new SoftMaterials.Epic(
                                (SoftMaterials.Epic.Material)Random.Range(0, System.Enum.GetNames(typeof(SoftMaterials.Epic.Material)).Length)
                                );
                        default : Debug.Log("RandomItemGenerator: GenerateMaterial: Material rarity not found"); return null;
                    }
            }
        }
    }

}

