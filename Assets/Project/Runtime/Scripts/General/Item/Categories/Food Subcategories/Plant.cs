using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.FoodSubcategories{
    [System.Serializable]
    public class Plant : Food{
        public enum SubType
        {
            SugarCane, Rose
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
                    case SubType.SugarCane:
                        _Name = "SugarCane";
                        _Description = "A sweet, sweet sugar cane.";
                        Satiety = 5;
                        break;
                    case SubType.Rose:
                        _Name = "Rose";
                        _Description = "A beautiful flower";
                        Satiety = 5;
                        break;
                    default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); break;
                }
            }
        }

        public float GetSubTypeWeight()
        {
            switch (subType)
            {
                case SubType.SugarCane: return 2f;
                case SubType.Rose: return 0.1f;
                default: UnityEngine.Debug.LogError("Unhandled subtype: " + subType); return 0f;
            }
        }
    }
}