using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Chair : Furniture
    {
        public enum SubType{
            Chair, Seat, Stool, Ottoman, Bench, Sofa, LoveSeat,
            RockingChair
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

        public Chair(){
            _FurnitureType = FurnitureType.Chair;
        }

        public Chair(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Chair;
        }

        private void SetNameAndDescription()
        {
            GenerateName(subType.ToString());

            switch (subType)
            {
                case SubType.Chair:
                    Description = "A chair is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Seat:
                    Description = "A seat is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Stool:
                    Description = "A stool is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Ottoman:
                    Description = "An ottoman is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Bench:
                    Description = "A bench is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Sofa:
                    Description = "A sofa is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.LoveSeat:
                    Description = "A love seat is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.RockingChair:
                    Description = "A rocking chair is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Chair:
                    Weight = 25f;
                    break;
                case SubType.Seat:
                    Weight = 25f;
                    break;
                case SubType.Stool:
                    Weight = 25f;
                    break;
                case SubType.Ottoman:
                    Weight = 25f;
                    break;
                case SubType.Bench:
                    Weight = 25f;
                    break;
                case SubType.Sofa:
                    Weight = 25f;
                    break;
                case SubType.LoveSeat:
                    Weight = 25f;
                    break;
                case SubType.RockingChair:
                    Weight = 25f;
                    break;
            }
        }
    }
}