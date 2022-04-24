using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Light : Furniture
    {
        public enum SubType{
            Candle, Lamp, Lantern
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;
        
        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                
                SetNameAndDescription();
                SetWeight();
            }
        }

        public Light(){
            _FurnitureType = FurnitureType.Light;
        }

        public Light(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Light;
        }

        private void SetNameAndDescription()
        {
            GenerateName(subType.ToString());

            switch (subType)
            {
                case SubType.Candle:
                    Description = "A candle is a small, unlit, wick-lit, flammable, and usually transparent, burning object.";
                    break;
                case SubType.Lamp:
                    Description = "A lamp is a light source that is usually made of metal or glass.";
                    break;
                case SubType.Lantern:
                    Description = "A lantern is a light source that is usually made of metal or glass.";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Candle:
                    Weight = 1;
                    break;
                case SubType.Lamp:
                    Weight = 1;
                    break;
                case SubType.Lantern:
                    Weight = 1;
                    break;
            }
        }
    }
}