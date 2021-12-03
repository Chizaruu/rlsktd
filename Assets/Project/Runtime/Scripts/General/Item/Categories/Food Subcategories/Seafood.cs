using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.FoodSubcategories{
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
                switch (subType)
                {
                    case SubType.Carp:
                        Name = "Carp";
                        Description = "A small fish that is found in the ocean.";
                        break;
                    case SubType.Cod:
                        Name = "Cod";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Crab:
                        Name = "Crab";
                        Description = "A small fish that is found in the ocean.";
                        break;
                    case SubType.Crayfish:
                        Name = "Crayfish";
                        Description = "A small fish that is found in the ocean.";
                        break;
                    case SubType.Eel:
                        Name = "Eel";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Lobster:
                        Name = "Lobster";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Mussel:
                        Name = "Mussel";
                        Description = "A small fish that is found in the ocean.";
                        break;
                    case SubType.Octopus:   
                        Name = "Octopus";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Winkle:
                        Name = "Winkle";
                        Description = "A small fish that is found in the ocean.";
                        break;
                    case SubType.Prawn:
                        Name = "Prawn";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Salmon:
                        Name = "Salmon";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Scallop:
                        Name = "Scallop";
                        Description = "A small fish that is found in the ocean.";
                        break;
                    case SubType.Shrimp:    
                        Name = "Shrimp";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Snapper:
                        Name = "Snapper";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Squid:
                        Name = "Squid";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Turtle:
                        Name = "Turtle";
                        Description = "A Whole Turtle";
                        break; 
                    case SubType.Trout:
                        Name = "Trout";
                        Description = "A fish that is found in the ocean.";
                        break;
                    case SubType.Tuna:
                        Name = "Tuna";
                        Description = "A fish that is found in the ocean.";
                        break;                
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

    }
}