using UnityEngine;
using System.Collections.Generic;
using RLSKTD.General.ItemCategories;
using RLSKTD.General.ItemCategories.WeaponSubcategories;
using RLSKTD.General.ItemCategories.ArmorSubcategories;
using RLSKTD.General.ItemCategories.FoodSubcategories;

namespace RLSKTD.General{
    public class RandomItemGenerator{

        public static List<Item> GenerateItem(int requiredItemAmount){
            List<Item> items = new List<Item>();
            while(requiredItemAmount > 0){
                switch(GenerateTypeEnum()){
                    case Item.Type.Weapon: 
                        items.Add(GenerateWeapon()); break;
                    case Item.Type.Armor: 
                        items.Add(GenerateArmor()); break;
                    case Item.Type.Food: 
                        items.Add(GenerateFood()); break;
                    case Item.Type.Potion: 
                        items.Add(GeneratePotion()); break;
                    case Item.Type.Scroll: 
                        items.Add(GenerateScroll()); break;
                    case Item.Type.Rod: 
                        items.Add(GenerateRod()); break;
                    case Item.Type.Book: 
                        items.Add(GenerateBook()); break;
                    case Item.Type.Tool: 
                        items.Add(GenerateTool()); break;
                    case Item.Type.Furniture: 
                        items.Add(GenerateFurniture()); break;
                    case Item.Type.Material: 
                        items.Add(GenerateMaterial()); break;
                    case Item.Type.Misc: 
                        items.Add(GenerateMisc()); break;
                    default: Debug.Log("RandomItemGenerator: GenerateItem: Type not found"); continue;
                }
                requiredItemAmount--;
            }
            return items;
        }

        private static Item GenerateWeapon()
        {
            switch (GenerateWeaponTypeEnum()){
                case Weapon.WeaponType.OneHanded:
                    OneHanded oneHanded = new OneHanded();
                    oneHanded._WeaponType = Weapon.WeaponType.OneHanded;
                    oneHanded._Material = GetRandomMaterialEnum();
                    oneHanded._SubType = (OneHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(OneHanded.SubType)).Length + 1);               
                    oneHanded._Quality = GenerateQualityEnum(); 
                    oneHanded.Dice = Random.Range(1, 4); //TODO: Add dice generation from material and subtype
                    oneHanded.Damage = Random.Range(1, 6); //TODO: Add damage generation from material and subtype
                    oneHanded._Value = Random.Range(1, 10); //TODO: Add value generation from material and subtype
                    oneHanded._Description = GenerateDescription();
                    oneHanded._Name = GenerateName();
                    return oneHanded;
                case Weapon.WeaponType.TwoHanded:
                    TwoHanded twoHanded = new TwoHanded();
                    twoHanded._WeaponType = Weapon.WeaponType.TwoHanded;
                    twoHanded._Material = GetRandomMaterialEnum();
                    twoHanded._SubType = (TwoHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(TwoHanded.SubType)).Length + 1);
                    twoHanded._Quality = GenerateQualityEnum();
                    twoHanded.Dice = Random.Range(1, 4); //TODO: Add dice generation from material and subtype
                    twoHanded.Damage = Random.Range(1, 6); //TODO: Add damage generation from material and subtype
                    twoHanded._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    twoHanded._Description = GenerateDescription();
                    twoHanded._Name = GenerateName();
                    return twoHanded;;   
                case Weapon.WeaponType.Shield:
                    Shield shield = new Shield();
                    shield._WeaponType = Weapon.WeaponType.Shield;
                    shield._Material = GetRandomMaterialEnum();
                    shield._SubType = (Shield.SubType)Random.Range(0, System.Enum.GetNames(typeof(Shield.SubType)).Length + 1);
                    shield._Quality = GenerateQualityEnum();
                    shield.Dice = Random.Range(1, 4); //TODO: Add dice generation from material and subtype
                    shield.Damage = Random.Range(1, 6); //TODO: Add damage generation from material and subtype
                    shield._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    shield._Description = GenerateDescription();
                    shield._Name = GenerateName();
                    return shield;; 
                case Weapon.WeaponType.Ranged:
                    Ranged ranged = new Ranged();
                    ranged._WeaponType = Weapon.WeaponType.Ranged;
                    ranged._Material = GetRandomMaterialEnum();
                    ranged._SubType = (Ranged.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ranged.SubType)).Length + 1);
                    ranged._Quality = GenerateQualityEnum();
                    ranged.Dice = Random.Range(1, 4); //TODO: Add dice generation from material and subtype
                    ranged.Damage = Random.Range(1, 6); //TODO: Add damage generation from material and subtype
                    ranged._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    ranged._Description = GenerateDescription();
                    ranged._Name = GenerateName();
                    return ranged;
                case Weapon.WeaponType.Ammo:
                    Ammo ammo = new Ammo();
                    ammo._WeaponType = Weapon.WeaponType.Ammo;
                    ammo._Material = GetRandomMaterialEnum();
                    ammo._SubType = (Ammo.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ammo.SubType)).Length + 1);
                    ammo._Quality = GenerateQualityEnum();
                    ammo.Dice = 1;
                    ammo.Damage = Random.Range(1, 12); //TODO: Add damage generation from material and subtype
                    ammo._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    ammo._Description = GenerateDescription();
                    ammo._Name = GenerateName();
                    return ammo;
                default: Debug.Log("RandomItemGenerator: GenerateWeapon: Weapon type not found"); return null;
            }
        }

        private static Item GenerateArmor()
        {
            switch (GenerateArmorTypeEnum()){
                case Armor.ArmorType.Head:
                    Head head = new Head();
                    head._ArmorType = Armor.ArmorType.Head;
                    head._Material = GetRandomMaterialEnum();
                    head._SubType = (Head.SubType)Random.Range(0, System.Enum.GetNames(typeof(Head.SubType)).Length + 1);
                    head._Quality = GenerateQualityEnum();
                    head.ProtectionValue = Random.Range(1, 6); //TODO: Add protection value generation from material and subtype
                    head.DefensiveValue = Random.Range(1, 6); //TODO: Add defensive value generation from material and subtype
                    head._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    head._Description = GenerateDescription();
                    head._Name = GenerateName();
                    return head;
                case Armor.ArmorType.Back:
                    Back back = new Back();
                    back._ArmorType = Armor.ArmorType.Back;
                    back._Material = GetRandomMaterialEnum();
                    back._SubType = (Back.SubType)Random.Range(0, System.Enum.GetNames(typeof(Back.SubType)).Length + 1);
                    back._Quality = GenerateQualityEnum();
                    back.ProtectionValue = Random.Range(1, 7); //TODO: Add protection value generation from material and subtype
                    back.DefensiveValue = Random.Range(1, 7); //TODO: Add defensive value generation from material and subtype
                    back._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    back._Description = GenerateDescription();
                    back._Name = GenerateName();
                    return back;
                case Armor.ArmorType.Body:
                    Body body = new Body();
                    body._ArmorType = Armor.ArmorType.Body;
                    body._Material = GetRandomMaterialEnum();
                    body._SubType = (Body.SubType)Random.Range(0, System.Enum.GetNames(typeof(Body.SubType)).Length + 1);
                    body._Quality = GenerateQualityEnum();
                    body.ProtectionValue = Random.Range(1, 20); //TODO: Add protection value generation from material and subtype
                    body.DefensiveValue = Random.Range(1, 20); //TODO: Add defensive value generation from material and subtype
                    body._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    body._Description = GenerateDescription();
                    body._Name = GenerateName();
                    return body;
                case Armor.ArmorType.Hand: 
                    Hand hand = new Hand();
                    hand._ArmorType = Armor.ArmorType.Hand;
                    hand._Material = GetRandomMaterialEnum();
                    hand._SubType = (Hand.SubType)Random.Range(0, System.Enum.GetNames(typeof(Hand.SubType)).Length + 1);
                    hand._Quality = GenerateQualityEnum();
                    hand.ProtectionValue = Random.Range(1, 7); //TODO: Add protection value generation from material and subtype
                    hand.DefensiveValue = Random.Range(1, 7); //TODO: Add defensive value generation from material and subtype
                    hand._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    hand._Description = GenerateDescription();
                    hand._Name = GenerateName();
                    return hand;
                case Armor.ArmorType.Waist:
                    Waist waist = new Waist();
                    waist._ArmorType = Armor.ArmorType.Waist;
                    waist._Material = GetRandomMaterialEnum();
                    waist._SubType = (Waist.SubType)Random.Range(0, System.Enum.GetNames(typeof(Waist.SubType)).Length + 1);
                    waist._Quality = GenerateQualityEnum();
                    waist.ProtectionValue = Random.Range(1, 5); //TODO: Add protection value generation from material and subtype
                    waist.DefensiveValue = Random.Range(1, 5); //TODO: Add defensive value generation from material and subtype
                    waist._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    waist._Description = GenerateDescription();
                    waist._Name = GenerateName();
                    return waist;
                case Armor.ArmorType.Foot:
                    Foot foot = new Foot();
                    foot._ArmorType = Armor.ArmorType.Foot;
                    foot._Material = GetRandomMaterialEnum();
                    foot._SubType = (Foot.SubType)Random.Range(0, System.Enum.GetNames(typeof(Foot.SubType)).Length + 1);
                    foot._Quality = GenerateQualityEnum();
                    foot.ProtectionValue = Random.Range(1, 7); //TODO: Add protection value generation from material and subtype
                    foot.DefensiveValue = Random.Range(1, 7); //TODO: Add defensive value generation from material and subtype
                    foot._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    foot._Description = GenerateDescription();
                    foot._Name = GenerateName();
                    return foot;
                case Armor.ArmorType.Neck:
                    Neck neck = new Neck();
                    neck._ArmorType = Armor.ArmorType.Neck;
                    neck._Material = GetRandomMaterialEnum();
                    neck._SubType = (Neck.SubType)Random.Range(0, System.Enum.GetNames(typeof(Neck.SubType)).Length + 1);
                    neck._Quality = GenerateQualityEnum();
                    neck.ProtectionValue = Random.Range(1, 3); //TODO: Add protection value generation from material and subtype
                    neck.DefensiveValue = Random.Range(1, 3); //TODO: Add defensive value generation from material and subtype
                    neck._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    neck._Description = GenerateDescription();
                    neck._Name = GenerateName();
                    return neck;
                case Armor.ArmorType.Finger:
                    Finger finger = new Finger();
                    finger._ArmorType = Armor.ArmorType.Finger;
                    finger._Material = GetRandomMaterialEnum();
                    finger._SubType = (Finger.SubType)Random.Range(0, System.Enum.GetNames(typeof(Finger.SubType)).Length + 1);
                    finger._Quality = GenerateQualityEnum();
                    finger.ProtectionValue = Random.Range(1, 3); //TODO: Add protection value generation from material and subtype
                    finger.DefensiveValue = Random.Range(1, 3); //TODO: Add defensive value generation from material and subtype
                    finger._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    finger._Description = GenerateDescription();
                    finger._Name = GenerateName();
                    return finger;
                case Armor.ArmorType.Ear:
                    Ear ear = new Ear();
                    ear._ArmorType = Armor.ArmorType.Ear;
                    ear._Material = GetRandomMaterialEnum();
                    ear._SubType = (Ear.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ear.SubType)).Length + 1);
                    ear._Quality = GenerateQualityEnum();
                    ear.ProtectionValue = Random.Range(1, 3); //TODO: Add protection value generation from material and subtype
                    ear.DefensiveValue = Random.Range(1, 3); //TODO: Add defensive value generation from material and subtype
                    ear._Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    ear._Description = GenerateDescription();
                    ear._Name = GenerateName();
                    return ear;
                default: Debug.Log("RandomItemGenerator: GenerateArmor: Armor type not found"); return null;
            }
        }
        //Need to develop a value system for food
        private static Item GenerateFood()
        {
            switch (GenerateFoodTypeEnum())
            {
                case Food.FoodType.Dairy:
                    Dairy dairy = new Dairy();
                    dairy._FoodType = Food.FoodType.Dairy;
                    dairy._SubType = (Dairy.SubType)Random.Range(0, System.Enum.GetNames(typeof(Dairy.SubType)).Length + 1);
                    dairy._Quality = GenerateQualityEnum();
                    dairy.ShelfLife = Random.Range((int)dairy.Satiety * (int)dairy._Quality, 100);
                    dairy._Value = Random.Range((int)dairy.Satiety * (int)dairy._Quality, 100);
                    return dairy;
                case Food.FoodType.Fruit:
                    Fruit fruit = new Fruit();
                    fruit._FoodType = Food.FoodType.Fruit;
                    fruit._SubType = (Fruit.SubType)Random.Range(0, System.Enum.GetNames(typeof(Fruit.SubType)).Length + 1);
                    fruit._Quality = GenerateQualityEnum();
                    fruit._Weight = fruit.GetSubTypeWeight();
                    fruit.ShelfLife = Random.Range((int)fruit.Satiety * (int)fruit._Quality, 100);
                    fruit._Value = Random.Range((int)fruit.Satiety * (int)fruit._Quality, 100); 
                    return fruit;
                case Food.FoodType.Meat:
                    Meat meat = new Meat();
                    meat._FoodType = Food.FoodType.Meat;
                    meat._SubType = (Meat.SubType)Random.Range(0, System.Enum.GetNames(typeof(Meat.SubType)).Length + 1);
                    meat._Quality = GenerateQualityEnum();
                    meat._Weight = meat.GetSubTypeWeight();
                    meat.IsCooked = Random.Range(0, 2) == 0;
                    meat.ShelfLife = Random.Range((int)meat.Satiety * (int)meat._Quality, 100);
                    meat._Value = Random.Range((int)meat.Satiety * (int)meat._Quality, 100);
                    if (meat.IsCooked){
                        meat._Name = meat._Quality + " Cooked " + meat._Name;
                    } else {
                        meat._Name = meat._Quality + " Raw " + meat._Name;
                    }
                    return meat;
                case Food.FoodType.Plant:
                    Plant plant = new Plant();
                    plant._FoodType = Food.FoodType.Plant;
                    plant._SubType = (Plant.SubType)Random.Range(0, System.Enum.GetNames(typeof(Plant.SubType)).Length + 1);
                    plant._Quality = GenerateQualityEnum();
                    plant._Weight = plant.GetSubTypeWeight();
                    plant.ShelfLife = Random.Range((int)plant.Satiety * (int)plant._Quality, 100);
                    plant._Value = Random.Range((int)plant.Satiety * (int)plant._Quality, 100);
                    return plant;
                case Food.FoodType.Processed:
                    Processed processed = new Processed();
                    processed._FoodType = Food.FoodType.Processed;
                    processed._SubType = (Processed.SubType)Random.Range(0, System.Enum.GetNames(typeof(Processed.SubType)).Length + 1);
                    processed._Quality = GenerateQualityEnum();
                    processed._Weight = processed.GetSubTypeWeight();
                    processed.ShelfLife = Random.Range((int)processed.Satiety * (int)processed._Quality, 100);
                    processed._Value = Random.Range((int)processed.Satiety * (int)processed._Quality, 100);
                    return processed;
                case Food.FoodType.Seafood:
                    Seafood seafood = new Seafood();
                    seafood._FoodType = Food.FoodType.Seafood;
                    seafood._SubType = (Seafood.SubType)Random.Range(0, System.Enum.GetNames(typeof(Seafood.SubType)).Length + 1);
                    seafood._Quality = GenerateQualityEnum();
                    seafood._Weight = seafood.GetSubTypeWeight();
                    seafood.ShelfLife = Random.Range((int)seafood.Satiety * (int)seafood._Quality, 100);
                    seafood._Value = Random.Range((int)seafood.Satiety * (int)seafood._Quality, 100);
                    if (seafood.IsCooked){
                        seafood._Name = seafood._Quality + " Cooked " + seafood._Name;
                    } else {
                        seafood._Name = seafood._Quality + " Raw " + seafood._Name;
                    }
                    return seafood;
                case Food.FoodType.Seed:
                    Seed seed = new Seed();
                    seed._FoodType = Food.FoodType.Seed;
                    seed._SubType = (Seed.SubType)Random.Range(0, System.Enum.GetNames(typeof(Seed.SubType)).Length + 1);
                    seed._Quality = GenerateQualityEnum();
                    seed._Weight = seed.GetSubTypeWeight();
                    seed.ShelfLife = Random.Range((int)seed.Satiety * (int)seed._Quality, 100);
                    seed._Value = Random.Range((int)seed.Satiety * (int)seed._Quality, 100);
                    return seed;
                case Food.FoodType.Vegetable:
                    Vegetable vegetable = new Vegetable();
                    vegetable._FoodType = Food.FoodType.Vegetable;
                    vegetable._SubType = (Vegetable.SubType)Random.Range(0, System.Enum.GetNames(typeof(Vegetable.SubType)).Length + 1);
                    vegetable._Quality = GenerateQualityEnum();
                    vegetable._Weight = vegetable.GetSubTypeWeight();
                    vegetable.IsCooked = Random.Range(0, 2) == 0;
                    vegetable.ShelfLife = Random.Range((int)vegetable.Satiety * (int)vegetable._Quality, 100);
                    vegetable._Value = Random.Range((int)vegetable.Satiety * (int)vegetable._Quality, 100);
                    if (vegetable.IsCooked){
                        vegetable._Name = vegetable._Quality + " Cooked " + vegetable._Name;
                    } else {
                        vegetable._Name = vegetable._Quality + vegetable._Name;
                    }
                    return vegetable;
                default: Debug.Log("RandomItemGenerator: GenerateFood: Food type not found"); return null;
            }
        }

        private static Item GeneratePotion()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateScroll()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateRod()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateBook()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateTool()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateFurniture()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateMaterial()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateMisc()
        {
            throw new System.NotImplementedException();
        }
    
        private static string GenerateName()
        {
            return ""; //TODO: Generate name
        }
        private static string GenerateDescription()
        {
            return ""; //TODO: Generate description
        }

        /// <summary> Generates a random quality enum </summary>
        private static Item.Type GenerateTypeEnum() => (Item.Type)Random.Range(0, System.Enum.GetNames(typeof(Item.Type)).Length + 1);
        /// <summary> Generates a random material enum </summary>
        private static ItemHelpers.Material.MaterialEnum GetRandomMaterialEnum() => (ItemHelpers.Material.MaterialEnum)Random.Range(0, System.Enum.GetNames(typeof(ItemHelpers.Material.MaterialEnum)).Length + 1);
        /// <summary> Generates a random quality enum </summary>
        private static Item.Quality GenerateQualityEnum() => (Item.Quality)Random.Range(0, System.Enum.GetNames(typeof(Item.Quality)).Length + 1);   
        /// <summary> Generates a random weapon type enum </summary>
        private static Weapon.WeaponType GenerateWeaponTypeEnum() => (Weapon.WeaponType)Random.Range(0, System.Enum.GetNames(typeof(Weapon.WeaponType)).Length + 1);
        /// <summary> Generates a random armor type enum </summary>
        private static Armor.ArmorType GenerateArmorTypeEnum() => (Armor.ArmorType)Random.Range(0, System.Enum.GetNames(typeof(Armor.ArmorType)).Length + 1);
        /// <summary> Generates a random food type enum </summary>
        private static Food.FoodType GenerateFoodTypeEnum() => (Food.FoodType)Random.Range(0, System.Enum.GetNames(typeof(Food.FoodType)).Length + 1);
    }
}