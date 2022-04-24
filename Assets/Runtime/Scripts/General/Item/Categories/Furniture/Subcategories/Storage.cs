using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Storage : Furniture
    {
        public enum SubType{
            Cabinet, Bookcase, Chest, Drawer, Dresser, Wardrobe,
            Coffer, Safe
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

        public Storage(){
            _FurnitureType = FurnitureType.Storage;
        }

        public Storage(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Storage;
        }

        private void SetNameAndDescription()
        {
            GenerateName(subType.ToString());

            switch (subType)
            {
                case SubType.Cabinet:
                    Description = "A cabinet is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Bookcase:
                    Description = "A bookcase is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Chest:
                    Description = "A chest is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Drawer:
                    Description = "A drawer is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Dresser:
                    Description = "A dresser is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Wardrobe:
                    Description = "A wardrobe is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Coffer:
                    Description = "A coffer is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.Safe:
                    Description = "A safe is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Cabinet:
                    Weight = 1;
                    break;
                case SubType.Bookcase:
                    Weight = 1;
                    break;
                case SubType.Chest:
                    Weight = 1;
                    break;
                case SubType.Drawer:
                    Weight = 1;
                    break;
                case SubType.Dresser:
                    Weight = 1;
                    break;
                case SubType.Wardrobe:
                    Weight = 1;
                    break;
                case SubType.Coffer:
                    Weight = 1;
                    break;
                case SubType.Safe:
                    Weight = 1;
                    break; 
            }
        }
    }
}