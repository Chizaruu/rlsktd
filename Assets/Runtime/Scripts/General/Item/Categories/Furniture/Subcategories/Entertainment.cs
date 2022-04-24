using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FurnitureSubcategories
{
    [System.Serializable]
    public class Entertainment : Furniture
    {
        public enum SubType{
            Piano, HiFi, Jukebox, TV, Radio, Aquarium
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

        public Entertainment(){
            _FurnitureType = FurnitureType.Entertainment;
        }

        public Entertainment(SubType subType, Material material){
            _SubType = subType;
            _FurnitureType = FurnitureType.Entertainment;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            switch (subType)
            {
                case SubType.Piano:
                    Description = "A piano is a musical instrument that is played by pressing a keyboard and hitting a key.";
                    break;
                case SubType.HiFi:
                    Description = "A Hi-Fi system is a system for playing music and other audio signals through a loudspeaker.";
                    break;
                case SubType.Jukebox:
                    Description = "A jukebox is a musical instrument that is played by pressing a keyboard and hitting a key.";
                    break;
                case SubType.TV:
                    Description = "A TV is a television set that is used to watch television programs.";
                    break;
                case SubType.Radio:
                    Description = "A radio is a device that is used to listen to radio programs.";
                    break;
                case SubType.Aquarium:
                    Description = "An aquarium is a piece of furniture that is usually made of wood or metal and usually has four legs.";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Piano:
                    Weight = 25f;
                    break;
                case SubType.HiFi:
                    Weight = 3.5f;
                    break;
                case SubType.Jukebox:
                    Weight = 5f;
                    break;
                case SubType.TV:
                    Weight = 7f;
                    break;
                case SubType.Radio:
                    Weight = 1f;
                    break;
                default:
                    Weight = 0.5f;
                    break;
            }
        }
    }
}