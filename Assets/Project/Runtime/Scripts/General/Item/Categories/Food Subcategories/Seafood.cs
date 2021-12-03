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
                IsIdentified = true;
                switch (subType)
                {
                    case SubType.Carp:
                        Name = "Carp";
                        Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Cod:
                        Name = "Cod";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Crab:
                        Name = "Crab";
                        Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Crayfish:
                        Name = "Crayfish";
                        Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Eel:
                        Name = "Eel";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Lobster:
                        Name = "Lobster";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Mussel:
                        Name = "Mussel";
                        Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Octopus:   
                        Name = "Octopus";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Winkle:
                        Name = "Winkle";
                        Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Prawn:
                        Name = "Prawn";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Salmon:
                        Name = "Salmon";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Scallop:
                        Name = "Scallop";
                        Description = "A small fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Shrimp:    
                        Name = "Shrimp";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Snapper:
                        Name = "Snapper";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Squid:
                        Name = "Squid";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Turtle:
                        Name = "Turtle";
                        Description = "A Whole Turtle";
                        Satiety = 10;
                        break; 
                    case SubType.Trout:
                        Name = "Trout";
                        Description = "A fish that is found in the ocean.";
                        Satiety = 10;
                        break;
                    case SubType.Tuna:
                        Name = "Tuna";
                        Description = "A fish that is found in the ocean.";
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