using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class MiscellaneousGenerator{
        public static Item Generate(){
            Miscellaneous.MiscellaneousType type = (Miscellaneous.MiscellaneousType)Random.Range(0, System.Enum.GetNames(typeof(Tool.ToolType)).Length);
            switch (type){
                default:
                    return new Miscellaneous(type, MaterialGenerator.Generate(false, true));
            }
        }
    }
}