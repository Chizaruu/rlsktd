using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Table : Furniture
    {
        public enum SubType{
            Table, CoffeeTable, DiningTable
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

        public Table(){
            _FurnitureType = FurnitureType.Table;
        }

        public Table(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Table;
        }

        private void SetNameAndDescription()
        {
            GenerateName(subType.ToString());

            switch (subType)
            {
                case SubType.Table:
                    Description = "A table is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.CoffeeTable:
                    Description = "A coffee table is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.DiningTable:
                    Description = "A dining table is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Table:
                    Weight = 1;
                    break;
                case SubType.CoffeeTable:
                    Weight = 1;
                    break;
                case SubType.DiningTable:
                    Weight = 1;
                    break;
            }
        }
    }
}