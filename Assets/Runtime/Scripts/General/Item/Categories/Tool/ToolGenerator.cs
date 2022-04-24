using RLSKTD.General.ItemCategories.ToolSubcategories;
using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class ToolGenerator{
        public static Item Generate(){
            Tool.ToolType type = (Tool.ToolType)Random.Range(0, System.Enum.GetNames(typeof(Tool.ToolType)).Length);
            switch (type){
                case Tool.ToolType.Magical:
                    return new Magical((Magical.SubType)Random.Range(0, System.Enum.GetNames(typeof(Magical.SubType)).Length), MaterialGenerator.Generate(false, true));
                default:
                    return new Tool(type, MaterialGenerator.Generate(false, true));
            }
        }
    }
}