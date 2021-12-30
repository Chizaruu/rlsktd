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
                SetBaseWeight();
            }
        }

        public Seafood(){
            _FoodType = FoodType.Seafood;
        }

        public Seafood(SubType subType, bool isCooked){
            _SubType = subType;
            IsCooked = isCooked;
            _FoodType = FoodType.Seafood;
        }

        private void SetNameAndDescription()
        {
            Name = "Raw " + subType.ToString();

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

        private void SetBaseWeight(){
            switch (subType)
            {
                case SubType.Carp:
                    BaseWeight = 1.7f;
                    break;
                case SubType.Cod:
                    BaseWeight = 1.1f;
                    break;
                case SubType.Crab:
                    BaseWeight = 0.7f;
                    break;
                case SubType.Crayfish:
                    BaseWeight = 0.5f;
                    break;
                case SubType.Eel:
                    BaseWeight = 3f;
                    break;
                case SubType.Lobster:
                    BaseWeight = 2f;
                    break;
                case SubType.Mussel:
                    BaseWeight = 0.2f;
                    break;
                case SubType.Octopus:
                    BaseWeight = 2f;
                    break;
                case SubType.Winkle:
                    BaseWeight = 0.1f;
                    break;
                case SubType.Prawn:
                    BaseWeight = 0.1f;
                    break;
                case SubType.Salmon:
                    BaseWeight = 0.8f;
                    break;
                case SubType.Scallop:
                    BaseWeight = 0.2f;
                    break;
                case SubType.Shrimp:
                    BaseWeight = 0.1f;
                    break;
                case SubType.Snapper:
                    BaseWeight = 1f;
                    break;
                case SubType.Squid:
                    BaseWeight = 1.5f;
                    break;
                case SubType.Turtle:
                    BaseWeight = 3f;
                    break;
                case SubType.Trout:
                    BaseWeight = 1.3f;
                    break;
                case SubType.Tuna:
                    BaseWeight = 20f;
                    break;
                default:
                    BaseWeight = 0.1f;
                    break;
            }
        }
    }
}