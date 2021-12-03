using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Processed : Food{
        public enum SubType
        {
            Dough, Flour
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
                    case SubType.Dough:
                        Name = "Dough";
                        Description = "A dough is a flat, dry, round, or spherical mass of flour or doughy substance, used in cooking.";
                        Satiety = 1;
                        break;
                    case SubType.Flour:
                        Name = "Flour";
                        Description = "A flour is a type of food made by grinding or mixing whole grains, such as wheat, oats, barley, rye, or rice, into a paste or dough.";
                        Satiety = 1;
                        break;
                
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.Dough: return 0.3f;
                case SubType.Flour: return 0.2f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}