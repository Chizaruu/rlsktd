using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Bed : Furniture
    {
        public enum SubType{
            Bed, Daybed, Futon, Waterbed
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

        public Bed(){
            _FurnitureType = FurnitureType.Bed;
        }

        public Bed(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Bed;
        }

        private void SetNameAndDescription()
        {
            GenerateName(subType.ToString());

            switch (subType)
            {
                case SubType.Bed:
                    Description = "A bed is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Daybed:
                    Description = "A daybed is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Futon:
                    Description = "A futon is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Waterbed:
                    Description = "A waterbed is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Bed:
                    Weight = 1;
                    break;
                case SubType.Daybed:
                    Weight = 1;
                    break;
                case SubType.Futon:
                    Weight = 1;
                    break;
                case SubType.Waterbed:
                    Weight = 1;
                    break;
            }
        }
    }
}