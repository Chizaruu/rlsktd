using RLSKTD.General.ItemCategories.FoodSubcategories;
using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class FoodGenerator{
        public static Item Generate(){
            switch ((Food.FoodType)Random.Range(0, System.Enum.GetNames(typeof(Food.FoodType)).Length))
            {
                case Food.FoodType.Dairy:
                    return new Dairy((Dairy.SubType)Random.Range(0, System.Enum.GetNames(typeof(Dairy.SubType)).Length));
                case Food.FoodType.Fruit:
                    return new Fruit((Fruit.SubType)Random.Range(0, System.Enum.GetNames(typeof(Fruit.SubType)).Length));
                case Food.FoodType.Meat:
                    return new Meat((Meat.SubType)Random.Range(0, System.Enum.GetNames(typeof(Meat.SubType)).Length), Random.Range(0, 2) == 0);
                case Food.FoodType.Plant:
                    return new Plant((Plant.SubType)Random.Range(0, System.Enum.GetNames(typeof(Plant.SubType)).Length));
                case Food.FoodType.Processed:
                    return new Processed((Processed.SubType)Random.Range(0, System.Enum.GetNames(typeof(Processed.SubType)).Length));
                case Food.FoodType.Seafood: 
                    return new Seafood((Seafood.SubType)Random.Range(0, System.Enum.GetNames(typeof(Seafood.SubType)).Length), Random.Range(0, 2) == 0);
                case Food.FoodType.Seed:
                    return new Seed((Seed.SubType)Random.Range(0, System.Enum.GetNames(typeof(Seed.SubType)).Length));
                case Food.FoodType.Vegetable:
                    return new Vegetable((Vegetable.SubType)Random.Range(0, System.Enum.GetNames(typeof(Vegetable.SubType)).Length), Random.Range(0, 2) == 0);
                default: Debug.Log("Generate: Food type not found"); return null;
            }
        }
    }
}