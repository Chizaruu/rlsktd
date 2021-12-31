using UnityEngine;
using System.Collections.Generic;
using RLSKTD.General.ItemCategories;
using RLSKTD.General.ItemCategories.WeaponSubcategories;
using RLSKTD.General.ItemCategories.ArmorSubcategories;
using RLSKTD.General.ItemCategories.FoodSubcategories;
using RLSKTD.General.ItemCategories.PotionSubcategories;
using RLSKTD.General.ItemCategories.ReadableSubcategories;

namespace RLSKTD.General{
    /*
        Currently lacking support for:
        - Artifacts
        - Magic Items
    */
    public class RandomItemGenerator{
        public static List<Item> GenerateItem(int requiredItemAmount){
            List<Item> items = new List<Item>();
            while(requiredItemAmount > 0){
                //Randomly get an item type
                switch((Item.Type)Random.Range(0, System.Enum.GetNames(typeof(Item.Type)).Length)){
                    case Item.Type.Weapon: 
                        items.Add(GenerateWeapon()); break;
                    case Item.Type.Armor: 
                        items.Add(GenerateArmor()); break;
                    case Item.Type.Food: 
                        items.Add(GenerateFood()); break;
                    case Item.Type.Potion: 
                        items.Add(GeneratePotion()); break;
                    case Item.Type.Readable: 
                        items.Add(GenerateReadable()); break;
                    case Item.Type.Rod: 
                        items.Add(GenerateRod()); break;
                    case Item.Type.Tool: 
                        items.Add(GenerateTool()); break;
                    case Item.Type.Furniture: 
                        items.Add(GenerateFurniture()); break;
                    case Item.Type.Material: 
                        items.Add(new Item(GenerateMaterialEnum())); break;
                    case Item.Type.Misc: 
                        //items.Add(new Item()); break;
                    default: Debug.Log("RandomItemGenerator: GenerateItem: Type not found"); continue;
                }
                requiredItemAmount--;
            }
            return items;
        }

        //Randomly get a weapon type and subtype then return the item
        public static Item GenerateWeapon()
        {
            switch ((Weapon.WeaponType)Random.Range(0, System.Enum.GetNames(typeof(Weapon.WeaponType)).Length)){
                case Weapon.WeaponType.OneHanded:
                    return new OneHanded((OneHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(OneHanded.SubType)).Length), GenerateMaterialEnum());
                case Weapon.WeaponType.TwoHanded:
                    return new TwoHanded((TwoHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(TwoHanded.SubType)).Length), GenerateMaterialEnum());   
                case Weapon.WeaponType.Shield:
                    return new Shield((Shield.SubType)Random.Range(0, System.Enum.GetNames(typeof(Shield.SubType)).Length), GenerateMaterialEnum()); 
                case Weapon.WeaponType.Ranged:
                    return new Ranged((Ranged.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ranged.SubType)).Length), GenerateMaterialEnum());
                case Weapon.WeaponType.Ammo:
                    return new Ammo((Ammo.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ammo.SubType)).Length), GenerateMaterialEnum());
                default: Debug.Log("RandomItemGenerator: GenerateWeapon: Weapon type not found"); return null;
            }
        }

        //Randomly get an armor type, subtype then return the item
        public static Item GenerateArmor()
        {
            switch ((Armor.ArmorType)Random.Range(0, System.Enum.GetNames(typeof(Armor.ArmorType)).Length)){
                case Armor.ArmorType.Head:
                    return new Head((Head.SubType)Random.Range(0, System.Enum.GetNames(typeof(Head.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Back:
                    return new Back((Back.SubType)Random.Range(0, System.Enum.GetNames(typeof(Back.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Body:
                    return new Body((Body.SubType)Random.Range(0, System.Enum.GetNames(typeof(Body.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Hand: 
                    return new Hand((Hand.SubType)Random.Range(0, System.Enum.GetNames(typeof(Hand.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Waist:
                    return new Waist((Waist.SubType)Random.Range(0, System.Enum.GetNames(typeof(Waist.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Foot:
                    return new Foot((Foot.SubType)Random.Range(0, System.Enum.GetNames(typeof(Foot.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Neck:
                    return new Neck((Neck.SubType)Random.Range(0, System.Enum.GetNames(typeof(Neck.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Finger:
                    return new Finger((Finger.SubType)Random.Range(0, System.Enum.GetNames(typeof(Finger.SubType)).Length), GenerateMaterialEnum());
                case Armor.ArmorType.Ear:
                    return new Ear((Ear.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ear.SubType)).Length), GenerateMaterialEnum());
                default: Debug.Log("RandomItemGenerator: GenerateArmor: Armor type not found"); return null;
            }
        }

        //Randomly get a food type and subtype then return the item
        public static Item GenerateFood()
        {
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
                default: Debug.Log("RandomItemGenerator: GenerateFood: Food type not found"); return null;
            }
        }

        public static Item GeneratePotion()
        {
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
                default: Debug.Log("RandomItemGenerator: GeneratePotion: Potion type not found"); return null;
            }
        }

        public static Item GenerateReadable()
        {
            switch ((Readable.ReadableType)Random.Range(0, System.Enum.GetNames(typeof(Readable.ReadableType)).Length))
            {
                case Readable.ReadableType.Book:
                    return new Book((Book.SubType)Random.Range(0, System.Enum.GetNames(typeof(Book.SubType)).Length));
                case Readable.ReadableType.Scroll:
                    return new Scroll((Scroll.SubType)Random.Range(0, System.Enum.GetNames(typeof(Scroll.SubType)).Length));
                default : Debug.Log("RandomItemGenerator: GenerateReadable: Readable type not found"); return null;
            }
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

        /// <summary> Generates a random material enum </summary>
        private static ItemHelpers.Material.MaterialEnum GenerateMaterialEnum() => (ItemHelpers.Material.MaterialEnum)Random.Range(0, System.Enum.GetNames(typeof(ItemHelpers.Material.MaterialEnum)).Length);
    }
}