using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class FurnitureGenerator{
        public static Item Generate(){
            switch ((Furniture.FurnitureType)Random.Range(0, System.Enum.GetNames(typeof(Tool.ToolType)).Length)){
                case Furniture.FurnitureType.Bed: 
                    return new Furniture(Furniture.FurnitureType.Bed, MaterialGenerator.Generate(false, true));
                case Furniture.FurnitureType.Chair: 
                    return new Furniture(Furniture.FurnitureType.Chair, MaterialGenerator.Generate(false, true));
                case Furniture.FurnitureType.Storage: 
                    return new Furniture(Furniture.FurnitureType.Storage, MaterialGenerator.Generate(false, true));
                case Furniture.FurnitureType.Clock: 
                    return new Furniture(Furniture.FurnitureType.Clock, MaterialGenerator.Generate(false, true));
                case Furniture.FurnitureType.Table: 
                    return new Furniture(Furniture.FurnitureType.Table, MaterialGenerator.Generate(false, true));
                case Furniture.FurnitureType.Light: 
                    return new Furniture(Furniture.FurnitureType.Light, MaterialGenerator.Generate(false, true));
                case Furniture.FurnitureType.Entertainment: 
                    return new Furniture(Furniture.FurnitureType.Entertainment, MaterialGenerator.Generate(false, false));
                case Furniture.FurnitureType.Art: 
                    return new Furniture(Furniture.FurnitureType.Art, MaterialGenerator.Generate(false, false));
                default: Debug.Log("GetItem: Type not found"); return null;
            }
        }
    }
}