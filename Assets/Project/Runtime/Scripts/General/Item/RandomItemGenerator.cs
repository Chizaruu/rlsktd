using UnityEngine;
using System.Collections.Generic;
using RLSKTD.General.Item.Helpers;
using RLSKTD.General.Item.Categories;
using RLSKTD.General.Item.Categories.WeaponSubcategories;

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
                    default: Debug.Log("RandomItemGenerator: GenerateItem: RandomType out of range"); break;
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
                default: Debug.Log("RandomItemGenerator: GenerateWeapon: RandomEquipType out of range"); return null;
            }
        }

        private static Item GenerateArmor()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateFood()
        {
            throw new System.NotImplementedException();
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
        private static Type.TypeEnum GenerateTypeEnum() => (Type.TypeEnum)Random.Range(0, System.Enum.GetNames(typeof(Type.TypeEnum)).Length + 1);
        private static Helpers.Material.MaterialEnum GetRandomMaterialEnum() => (Helpers.Material.MaterialEnum)Random.Range(0, System.Enum.GetNames(typeof(Helpers.Material.MaterialEnum)).Length + 1);
        private static Quality.QualityEnum GenerateQualityEnum() => (Quality.QualityEnum)Random.Range(0, System.Enum.GetNames(typeof(Quality.QualityEnum)).Length + 1);   
        private static Weapon.WeaponType GenerateWeaponTypeEnum() => (Weapon.WeaponType)Random.Range(0, System.Enum.GetNames(typeof(Weapon.WeaponType)).Length + 1);

    }
}