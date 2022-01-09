using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Clock : Furniture
    {
        public enum SubType{
            Clock, WallClock, GrandfatherClock
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

        public Clock(){
            _FurnitureType = FurnitureType.Clock;
        }

        public Clock(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Clock;
        }

        private void SetNameAndDescription()
        {
            GenerateName(subType.ToString());

            switch (subType)
            {
                case SubType.Clock:
                    Description = "A clock is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.WallClock:
                    Description = "A wall clock is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
                case SubType.GrandfatherClock:
                    Description = "A grandfather clock is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Clock:
                    Weight = 1;
                    break;
                case SubType.WallClock:
                    Weight = 1;
                    break;
                case SubType.GrandfatherClock:
                    Weight = 1;
                    break; 
            }
        }
    }
}