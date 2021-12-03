using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.Item.Categories.FoodSubcategories{
    [System.Serializable]
    public class Processed : Food{
        public enum SubType
        {
            Dough, Flour,
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                switch (subType)
                {
                    case SubType.Dough:
                        Name = "Dough";
                        Description = "A dough is a flat, dry, round, or spherical mass of flour or doughy substance, used in cooking.";
                        break;
                    case SubType.Flour:
                        Name = "Flour";
                        Description = "A flour is a type of food made by grinding or mixing whole grains, such as wheat, oats, barley, rye, or rice, into a paste or dough.";
                        break;
                
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

    }
}