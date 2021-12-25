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
                _Material = ItemHelpers.Material.MaterialEnum.Organic;
                _IsIdentified = true;
                switch (subType)
                {
                    case SubType.Carp:
                        _Name = "Carp";
                        _Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Cod:
                        _Name = "Cod";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Crab:
                        _Name = "Crab";
                        _Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Crayfish:
                        _Name = "Crayfish";
                        _Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Eel:
                        _Name = "Eel";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Lobster:
                        _Name = "Lobster";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Mussel:
                        _Name = "Mussel";
                        _Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Octopus:   
                        _Name = "Octopus";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Winkle:
                        _Name = "Winkle";
                        _Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Prawn:
                        _Name = "Prawn";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Salmon:
                        _Name = "Salmon";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Scallop:
                        _Name = "Scallop";
                        _Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Shrimp:    
                        _Name = "Shrimp";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Snapper:
                        _Name = "Snapper";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Squid:
                        _Name = "Squid";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Turtle:
                        _Name = "Turtle";
                        _Description = "A Whole Turtle";
                        Satiety = 10;
                        break; 
                    case SubType.Trout:
                        _Name = "Trout";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Tuna:
                        _Name = "Tuna";
                        _Description = "A fish that is found in the ocean.";
                        Satiety = 100;
                        break;                
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.Carp: return 1.7f;
                case SubType.Cod: return 1.1f;
                case SubType.Crab: return 0.7f;
                case SubType.Crayfish: return 0.5f;
                case SubType.Eel: return 3f;
                case SubType.Lobster: return 2f;
                case SubType.Mussel: return 0.2f;
                case SubType.Octopus: return 2f;
                case SubType.Winkle: return 0.1f;
                case SubType.Prawn: return 0.1f;
                case SubType.Salmon: return 0.8f;
                case SubType.Scallop: return 0.2f;
                case SubType.Shrimp: return 0.1f;
                case SubType.Snapper: return 1f;
                case SubType.Squid: return 1.5f;
                case SubType.Turtle: return 3f;
                case SubType.Trout: return 1.3f;
                case SubType.Tuna: return 20f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}