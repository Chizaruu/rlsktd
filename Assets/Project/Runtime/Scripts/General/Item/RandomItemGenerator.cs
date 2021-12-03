using UnityEngine;
using System.Collections.Generic;
using RLSKTD.General.Item.Helpers;
using RLSKTD.General.Item.Categories;
using RLSKTD.General.Item.Categories.WeaponSubcategories;
using RLSKTD.General.Item.Categories.ArmorSubcategories;
using RLSKTD.General.Item.Categories.FoodSubcategories;

namespace RLSKTD.General.Item{
    public class RandomItemGenerator{

        public static List<Item> GenerateItem(int requiredItemAmount){
            List<Item> items = new List<Item>();
            while(requiredItemAmount > 0){
                switch(GenerateTypeEnum()){
                    case Type.TypeEnum.Weapon: 
                        items.Add(GenerateWeapon()); break;
                    case Type.TypeEnum.Armor: 
                        items.Add(GenerateArmor()); break;
                    case Type.TypeEnum.Food: 
                        items.Add(GenerateFood()); break;
                    case Type.TypeEnum.Potion: 
                        items.Add(GeneratePotion()); break;
                    case Type.TypeEnum.Scroll: 
                        items.Add(GenerateScroll()); break;
                    case Type.TypeEnum.Rod: 
                        items.Add(GenerateRod()); break;
                    case Type.TypeEnum.Book: 
                        items.Add(GenerateBook()); break;
                    case Type.TypeEnum.Tool: 
                        items.Add(GenerateTool()); break;
                    case Type.TypeEnum.Furniture: 
                        items.Add(GenerateFurniture()); break;
                    case Type.TypeEnum.Material: 
                        items.Add(GenerateMaterial()); break;
                    case Type.TypeEnum.Misc: 
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
                    oneHanded.Value = Random.Range(1, 10); //TODO: Add value generation from material and subtype
                    oneHanded.Description = GenerateDescription();
                    oneHanded.Name = GenerateName();
                    return oneHanded;
                case Weapon.WeaponType.TwoHanded:
                    TwoHanded twoHanded = new TwoHanded();
                    twoHanded._WeaponType = Weapon.WeaponType.TwoHanded;
                    twoHanded._Material = GetRandomMaterialEnum();
                    twoHanded._SubType = (TwoHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(TwoHanded.SubType)).Length + 1);
                    twoHanded._Quality = GenerateQualityEnum();
                    twoHanded.Dice = Random.Range(1, 4); //TODO: Add dice generation from material and subtype
                    twoHanded.Damage = Random.Range(1, 6); //TODO: Add damage generation from material and subtype
                    twoHanded.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    twoHanded.Description = GenerateDescription();
                    twoHanded.Name = GenerateName();
                    return twoHanded;;   
                case Weapon.WeaponType.Shield:
                    Shield shield = new Shield();
                    shield._WeaponType = Weapon.WeaponType.Shield;
                    shield._Material = GetRandomMaterialEnum();
                    shield._SubType = (Shield.SubType)Random.Range(0, System.Enum.GetNames(typeof(Shield.SubType)).Length + 1);
                    shield._Quality = GenerateQualityEnum();
                    shield.Dice = Random.Range(1, 4); //TODO: Add dice generation from material and subtype
                    shield.Damage = Random.Range(1, 6); //TODO: Add damage generation from material and subtype
                    shield.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    shield.Description = GenerateDescription();
                    shield.Name = GenerateName();
                    return shield;; 
                case Weapon.WeaponType.Ranged:
                    Ranged ranged = new Ranged();
                    ranged._WeaponType = Weapon.WeaponType.Ranged;
                    ranged._Material = GetRandomMaterialEnum();
                    ranged._SubType = (Ranged.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ranged.SubType)).Length + 1);
                    ranged._Quality = GenerateQualityEnum();
                    ranged.Dice = Random.Range(1, 4); //TODO: Add dice generation from material and subtype
                    ranged.Damage = Random.Range(1, 6); //TODO: Add damage generation from material and subtype
                    ranged.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    ranged.Description = GenerateDescription();
                    ranged.Name = GenerateName();
                    return ranged;
                case Weapon.WeaponType.Ammo:
                    Ammo ammo = new Ammo();
                    ammo._WeaponType = Weapon.WeaponType.Ammo;
                    ammo._Material = GetRandomMaterialEnum();
                    ammo._SubType = (Ammo.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ammo.SubType)).Length + 1);
                    ammo._Quality = GenerateQualityEnum();
                    ammo.Dice = 1;
                    ammo.Damage = Random.Range(1, 12); //TODO: Add damage generation from material and subtype
                    ammo.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    ammo.Description = GenerateDescription();
                    ammo.Name = GenerateName();
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
                    head.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    head.Description = GenerateDescription();
                    head.Name = GenerateName();
                    return head;
                case Armor.ArmorType.Back:
                    Back back = new Back();
                    back._ArmorType = Armor.ArmorType.Back;
                    back._Material = GetRandomMaterialEnum();
                    back._SubType = (Back.SubType)Random.Range(0, System.Enum.GetNames(typeof(Back.SubType)).Length + 1);
                    back._Quality = GenerateQualityEnum();
                    back.ProtectionValue = Random.Range(1, 7); //TODO: Add protection value generation from material and subtype
                    back.DefensiveValue = Random.Range(1, 7); //TODO: Add defensive value generation from material and subtype
                    back.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    back.Description = GenerateDescription();
                    back.Name = GenerateName();
                    return back;
                case Armor.ArmorType.Body:
                    Body body = new Body();
                    body._ArmorType = Armor.ArmorType.Body;
                    body._Material = GetRandomMaterialEnum();
                    body._SubType = (Body.SubType)Random.Range(0, System.Enum.GetNames(typeof(Body.SubType)).Length + 1);
                    body._Quality = GenerateQualityEnum();
                    body.ProtectionValue = Random.Range(1, 20); //TODO: Add protection value generation from material and subtype
                    body.DefensiveValue = Random.Range(1, 20); //TODO: Add defensive value generation from material and subtype
                    body.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    body.Description = GenerateDescription();
                    body.Name = GenerateName();
                    return body;
                case Armor.ArmorType.Hand: 
                    Hand hand = new Hand();
                    hand._ArmorType = Armor.ArmorType.Hand;
                    hand._Material = GetRandomMaterialEnum();
                    hand._SubType = (Hand.SubType)Random.Range(0, System.Enum.GetNames(typeof(Hand.SubType)).Length + 1);
                    hand._Quality = GenerateQualityEnum();
                    hand.ProtectionValue = Random.Range(1, 7); //TODO: Add protection value generation from material and subtype
                    hand.DefensiveValue = Random.Range(1, 7); //TODO: Add defensive value generation from material and subtype
                    hand.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    hand.Description = GenerateDescription();
                    hand.Name = GenerateName();
                    return hand;
                case Armor.ArmorType.Waist:
                    Waist waist = new Waist();
                    waist._ArmorType = Armor.ArmorType.Waist;
                    waist._Material = GetRandomMaterialEnum();
                    waist._SubType = (Waist.SubType)Random.Range(0, System.Enum.GetNames(typeof(Waist.SubType)).Length + 1);
                    waist._Quality = GenerateQualityEnum();
                    waist.ProtectionValue = Random.Range(1, 5); //TODO: Add protection value generation from material and subtype
                    waist.DefensiveValue = Random.Range(1, 5); //TODO: Add defensive value generation from material and subtype
                    waist.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    waist.Description = GenerateDescription();
                    waist.Name = GenerateName();
                    return waist;
                case Armor.ArmorType.Foot:
                    Foot foot = new Foot();
                    foot._ArmorType = Armor.ArmorType.Foot;
                    foot._Material = GetRandomMaterialEnum();
                    foot._SubType = (Foot.SubType)Random.Range(0, System.Enum.GetNames(typeof(Foot.SubType)).Length + 1);
                    foot._Quality = GenerateQualityEnum();
                    foot.ProtectionValue = Random.Range(1, 7); //TODO: Add protection value generation from material and subtype
                    foot.DefensiveValue = Random.Range(1, 7); //TODO: Add defensive value generation from material and subtype
                    foot.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    foot.Description = GenerateDescription();
                    foot.Name = GenerateName();
                    return foot;
                case Armor.ArmorType.Neck:
                    Neck neck = new Neck();
                    neck._ArmorType = Armor.ArmorType.Neck;
                    neck._Material = GetRandomMaterialEnum();
                    neck._SubType = (Neck.SubType)Random.Range(0, System.Enum.GetNames(typeof(Neck.SubType)).Length + 1);
                    neck._Quality = GenerateQualityEnum();
                    neck.ProtectionValue = Random.Range(1, 3); //TODO: Add protection value generation from material and subtype
                    neck.DefensiveValue = Random.Range(1, 3); //TODO: Add defensive value generation from material and subtype
                    neck.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    neck.Description = GenerateDescription();
                    neck.Name = GenerateName();
                    return neck;
                case Armor.ArmorType.Finger:
                    Finger finger = new Finger();
                    finger._ArmorType = Armor.ArmorType.Finger;
                    finger._Material = GetRandomMaterialEnum();
                    finger._SubType = (Finger.SubType)Random.Range(0, System.Enum.GetNames(typeof(Finger.SubType)).Length + 1);
                    finger._Quality = GenerateQualityEnum();
                    finger.ProtectionValue = Random.Range(1, 3); //TODO: Add protection value generation from material and subtype
                    finger.DefensiveValue = Random.Range(1, 3); //TODO: Add defensive value generation from material and subtype
                    finger.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    finger.Description = GenerateDescription();
                    finger.Name = GenerateName();
                    return finger;
                case Armor.ArmorType.Ear:
                    Ear ear = new Ear();
                    ear._ArmorType = Armor.ArmorType.Ear;
                    ear._Material = GetRandomMaterialEnum();
                    ear._SubType = (Ear.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ear.SubType)).Length + 1);
                    ear._Quality = GenerateQualityEnum();
                    ear.ProtectionValue = Random.Range(1, 3); //TODO: Add protection value generation from material and subtype
                    ear.DefensiveValue = Random.Range(1, 3); //TODO: Add defensive value generation from material and subtype
                    ear.Value = Random.Range(1, 100); //TODO: Add value generation from material and subtype
                    ear.Description = GenerateDescription();
                    ear.Name = GenerateName();
                    return ear;
                default: Debug.Log("RandomItemGenerator: GenerateArmor: Armor type not found"); return null;
            }
        }

        private static Item GenerateFood()
        {
            switch (GenerateFoodTypeEnum())
            {
                case Food.FoodType.Vegetable:
                    Vegetable vegetable = new Vegetable();
                    vegetable._FoodType = Food.FoodType.Vegetable;
                    vegetable._Material = Helpers.Material.MaterialEnum.Organic;
                    vegetable._SubType = (Vegetable.SubType)Random.Range(0, System.Enum.GetNames(typeof(Vegetable.SubType)).Length + 1);
                    vegetable._Quality = GenerateQualityEnum();
                    vegetable.Weight = 0.1f; //TODO: Add weight generation from quality
                    vegetable.IsCooked = Random.Range(0, 2) == 0;
                    vegetable.Wellness = Random.Range(1, 30); //TODO: Add wellness value generation from quality
                    vegetable.ShelfLife = Random.Range(0, 100); //TODO: Add shelf life generation from wellness and quality
                    vegetable.Value = Random.Range(1, 100); //TODO: Add value generation from wellness, quality and subtype
                    vegetable.IsIdentified = true;
                    if (vegetable.IsCooked)
                    {
                        vegetable.Name = "A Cooked " + vegetable.Name;
                    }
                    return vegetable;
                case Food.FoodType.Fruit:
                    Fruit fruit = new Fruit();
                    fruit._FoodType = Food.FoodType.Fruit;
                    fruit._Material = Helpers.Material.MaterialEnum.Organic;
                    fruit._SubType = (Fruit.SubType)Random.Range(0, System.Enum.GetNames(typeof(Fruit.SubType)).Length + 1);
                    fruit._Quality = GenerateQualityEnum();
                    fruit.Weight = 0.1f; //TODO: Add weight generation from quality
                    fruit.Wellness = Random.Range(1, 30); //TODO: Add wellness value generation from quality
                    fruit.ShelfLife = Random.Range(0, 100); //TODO: Add shelf life generation from wellness and quality
                    fruit.Value = Random.Range(1, 100); //TODO: Add value generation from wellness, quality and subtype
                    fruit.IsIdentified = true;
                    return fruit;
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
        private static Type.TypeEnum GenerateTypeEnum() => (Type.TypeEnum)Random.Range(0, System.Enum.GetNames(typeof(Type.TypeEnum)).Length + 1);
        /// <summary> Generates a random material enum </summary>
        private static Helpers.Material.MaterialEnum GetRandomMaterialEnum() => (Helpers.Material.MaterialEnum)Random.Range(0, System.Enum.GetNames(typeof(Helpers.Material.MaterialEnum)).Length + 1);
        /// <summary> Generates a random quality enum </summary>
        private static Quality.QualityEnum GenerateQualityEnum() => (Quality.QualityEnum)Random.Range(0, System.Enum.GetNames(typeof(Quality.QualityEnum)).Length + 1);   
        /// <summary> Generates a random weapon type enum </summary>
        private static Weapon.WeaponType GenerateWeaponTypeEnum() => (Weapon.WeaponType)Random.Range(0, System.Enum.GetNames(typeof(Weapon.WeaponType)).Length + 1);
        /// <summary> Generates a random armor type enum </summary>
        private static Armor.ArmorType GenerateArmorTypeEnum() => (Armor.ArmorType)Random.Range(0, System.Enum.GetNames(typeof(Armor.ArmorType)).Length + 1);
        /// <summary> Generates a random food type enum </summary>
        private static Food.FoodType GenerateFoodTypeEnum() => (Food.FoodType)Random.Range(0, System.Enum.GetNames(typeof(Food.FoodType)).Length + 1);
    }
}