using UnityEngine;
using System.Collections.Generic;
using RLSKTD.General.ItemCategories;

namespace RLSKTD.General{
    /*
        Currently lacking support for:
        - Artifacts
        - Magic Items
    */
    public class ItemGenerator{
        public static List<Item> GenerateItems(int requiredItemAmount, bool isRandom, Item.Type type){
            List<Item> items = new List<Item>();

            if(isRandom){
                for(int i = 0; i < requiredItemAmount; i++){
                    items.Add(GenerateItem((Item.Type)Random.Range(0, System.Enum.GetNames(typeof(Item.Type)).Length)));
                }
            }
            else{
                for(int i = 0; i < requiredItemAmount; i++){
                    items.Add(GenerateItem(type));
                }
            }
            return items;
        }

        public static Item GenerateItem(Item.Type type){
            switch(type){
                case Item.Type.Weapon: 
                    return WeaponGenerator.Generate();
                case Item.Type.Armor: 
                    return ArmorGenerator.Generate();
                case Item.Type.Food: 
                    return FoodGenerator.Generate();
                case Item.Type.Potion: 
                    return PotionGenerator.Generate();
                case Item.Type.Readable: 
                    return ReadableGenerator.Generate();
                case Item.Type.Tool: 
                    return ToolGenerator.Generate();
                case Item.Type.Furniture: 
                    return FurnitureGenerator.Generate();
                case Item.Type.Material: 
                    return new Item(ItemHelpers.MaterialGenerator.Generate(true, false));
                case Item.Type.Miscellaneous: 
                    return MiscellaneousGenerator.Generate();
                default: Debug.Log("GetItem: Type not found"); return null;
            }
        }
    }
}