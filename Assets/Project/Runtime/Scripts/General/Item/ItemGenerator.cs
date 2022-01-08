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
        public static List<Item> GenerateItems(int requiredItemAmount){
            List<Item> items = new List<Item>();
            while(requiredItemAmount > 0){
                //Randomly get an item type
                switch((Item.Type)Random.Range(0, System.Enum.GetNames(typeof(Item.Type)).Length)){
                    case Item.Type.Weapon: 
                        items.Add(WeaponGenerator.Generate()); break;
                    case Item.Type.Armor: 
                        items.Add(ArmorGenerator.Generate()); break;
                    case Item.Type.Food: 
                        items.Add(FoodGenerator.Generate()); break;
                    case Item.Type.Potion: 
                        items.Add(PotionGenerator.Generate()); break;
                    case Item.Type.Readable: 
                        items.Add(ReadableGenerator.Generate()); break;
                    case Item.Type.Rod: 
                        items.Add(GenerateRod()); break;
                    case Item.Type.Tool: 
                        items.Add(GenerateTool()); break;
                    case Item.Type.Furniture: 
                        items.Add(GenerateFurniture()); break;
                    case Item.Type.Material: 
                        items.Add(new Item(ItemHelpers.MaterialGenerator.Generate(true, false))); break;
                    case Item.Type.Miscellaneous: 
                        items.Add(GenerateMiscellaneous()); break;
                    default: Debug.Log("ItemGenerator: GenerateItem: Type not found"); continue;
                }
                requiredItemAmount--;
            }
            return items;
        }

        public static Item GenerateRod()
        {
            throw new System.NotImplementedException();
        }

        public static Item GenerateTool()
        {
            throw new System.NotImplementedException();
        }

        public static Item GenerateFurniture()
        {
            throw new System.NotImplementedException();
        }

        public static Item GenerateMiscellaneous()
        {
            throw new System.NotImplementedException();
        }
    }
}