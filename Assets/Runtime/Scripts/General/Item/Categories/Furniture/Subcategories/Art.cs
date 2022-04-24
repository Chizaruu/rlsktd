using RLSKTD.General.ItemHelpers;
using RLSKTD.General.ItemHelpers.SoftMaterials;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Art : Furniture
    {
        public enum SubType{
            Statue, Painting, Sculpture, Decorative
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;
        
        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                
                SetNameAndDescription();
                SetWeight();

                if(subType == SubType.Painting){
                    _Material = new Common(Common.Material.Paper);
                }
            }
        }

        public Art(){
            _FurnitureType = FurnitureType.Art;
        }

        public Art(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Art;
        }

        private void SetNameAndDescription()
        {
            GenerateName(subType.ToString());

            switch (subType)
            {
                case SubType.Statue:
                    Description = "A statue is a large statue of a person or thing. " +
                                  "Statues are usually made of stone, but can be made of other materials as well.";
                    break;
                case SubType.Painting:
                    Description = "A painting is a picture or graphic representation of a person, place, or thing. " +
                                  "A painting is usually made of a medium such as oil, watercolor, or acrylic.";
                    break;
                case SubType.Sculpture:
                    Description = "A sculpture is a work of art that is made from a stone, metal, wood, or other material. " +
                                  "A sculpture is usually made of a medium such as clay, metal, wood, or other material.";
                    break;
                case SubType.Decorative:
                    Description = "A decorative is a piece of art that is not a work of art. " +
                                  "Decorative art is usually made of a medium such as wood, metal, or other material.";
                    break;
                default:
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Statue:
                    Weight = 1.3f;
                    break;
                case SubType.Painting:
                    Weight = 0.5f;
                    break;
                case SubType.Sculpture:
                    Weight = 2f;
                    break;
                case SubType.Decorative:
                    Weight = 0.2f;
                    break;
                default:
                    Weight = 0.5f;
                    break;
            }
        }
    }
}