using RLSKTD.General.ItemCategories.PotionSubcategories;
using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class PotionGenerator{
        public static Item Generate(){
            switch ((Potion.PotionType)Random.Range(0, System.Enum.GetNames(typeof(Potion.PotionType)).Length))
            {
                case Potion.PotionType.Beverage:
                    return new Beverage((Beverage.SubType)Random.Range(0, System.Enum.GetNames(typeof(Beverage.SubType)).Length));
                case Potion.PotionType.Positive:
                    return new Positive((Positive.SubType)Random.Range(0, System.Enum.GetNames(typeof(Positive.SubType)).Length));
                case Potion.PotionType.Negative:
                    return new Negative((Negative.SubType)Random.Range(0, System.Enum.GetNames(typeof(Negative.SubType)).Length));
                case Potion.PotionType.Dye:
                    return new Dye((Dye.SubType)Random.Range(0, System.Enum.GetNames(typeof(Dye.SubType)).Length));
                default: Debug.Log("Generate: Potion type not found"); return null;
            }
        }
    }
}