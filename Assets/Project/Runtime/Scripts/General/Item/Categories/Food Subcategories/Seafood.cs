using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Seafood : Food{
        public enum SubType
        {
            Carp, Cod, Crab, Crayfish, Eel, Lobster, Mussel, Octopus,
            Winkle, Prawn, Salmon, Scallop, Shrimp, Snapper, Squid,
            Turtle, Trout, Tuna
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;

                SetNameAndDescription();
                SetSatiety();
                SetWeight();
            }
        }

        public Seafood(SubType subType, bool isCooked){
            _SubType = subType;
            IsCooked = isCooked;
            _FoodType = FoodType.Seafood;
            _Material = ItemHelpers.Material.MaterialEnum.Organic;
            IsIdentified = true;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            switch (subType)
            {
                case SubType.Carp:
                    Description = "A small fish that is found in the ocean.";
                    break;
                case SubType.Crab:
                    Description = "A small fish that is found in the ocean.";
                    break;
                case SubType.Crayfish:
                    Description = "A small fish that is found in the ocean.";
                    break;
                case SubType.Mussel:
                    Description = "A small fish that is found in the ocean.";
                    break;
                case SubType.Winkle:
                    Description = "A small fish that is found in the ocean.";
                    break;
                case SubType.Scallop:
                    Description = "A small fish that is found in the ocean.";
                    break;
                case SubType.Turtle:
                    Description = "A Whole Turtle";
                    break;              
                default: Description = "A fish. (?)"; break;
            }
        }

        private void SetSatiety(){
            switch (subType)
            {
                case SubType.Tuna:
                    Satiety = 100;
                    break;
                default: Satiety = 10; break;
            }
        }

        private void SetWeight(){
            switch (subType)
            {
                case SubType.Carp:
                    Weight = 1.7f;
                    break;
                case SubType.Cod:
                    Weight = 1.1f;
                    break;
                case SubType.Crab:
                    Weight = 0.7f;
                    break;
                case SubType.Crayfish:
                    Weight = 0.5f;
                    break;
                case SubType.Eel:
                    Weight = 3f;
                    break;
                case SubType.Lobster:
                    Weight = 2f;
                    break;
                case SubType.Mussel:
                    Weight = 0.2f;
                    break;
                case SubType.Octopus:
                    Weight = 2f;
                    break;
                case SubType.Winkle:
                    Weight = 0.1f;
                    break;
                case SubType.Prawn:
                    Weight = 0.1f;
                    break;
                case SubType.Salmon:
                    Weight = 0.8f;
                    break;
                case SubType.Scallop:
                    Weight = 0.2f;
                    break;
                case SubType.Shrimp:
                    Weight = 0.1f;
                    break;
                case SubType.Snapper:
                    Weight = 1f;
                    break;
                case SubType.Squid:
                    Weight = 1.5f;
                    break;
                case SubType.Turtle:
                    Weight = 3f;
                    break;
                case SubType.Trout:
                    Weight = 1.3f;
                    break;
                case SubType.Tuna:
                    Weight = 20f;
                    break;
                default:
                    Weight = 0.1f;
                    break;
            }
        }
    }
}