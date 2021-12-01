using UnityEngine;
using System.Collections.Generic;
using RLSKTD.General.Item.Helpers;
using RLSKTD.General.Item.Categories;
using RLSKTD.General.Item.Categories.WeaponSubcategories;

namespace RLSKTD.General.Item{
    public class RandomItemGenerator{

        public static void GenerateItem(List<Item> items, int requiredItemAmount){

            while(requiredItemAmount > 0){
                int randomType = Random.Range(0, System.Enum.GetNames(typeof(Type.TypeEnum)).Length + 1);
                Item item = null;
                switch(GenerateTypeEnum()){
                    case 0: item = GenerateWeapon(); break;
                    case 1: item = GenerateArmor(); break;
                    case 2: item = GenerateJewelry(); break;
                    case 3: item = GenerateFood(); break;
                    case 4: item = GeneratePotion(); break;
                    case 5: item = GenerateScroll(); break;
                    case 6: item = GenerateRod(); break;
                    case 7: item = GenerateBook(); break;
                    case 8: item = GenerateTool(); break;
                    case 9: item = GenerateFurniture(); break;
                    case 10: item = GenerateMaterial(); break;
                    case 11: item = GenerateMisc(); break;
                    default: Debug.Log("RandomItemGenerator: GenerateItem: RandomType out of range"); break;
                }

                if(item != null){
                    items.Add(item);
                    requiredItemAmount--;
                } else {
                    Debug.Log("RandomItemGenerator: GenerateItem: item is null");
                }
            }
        }

        private static Item GenerateWeapon()
        {
            switch (GenerateWeaponTypeEnum()){
                case (int)Weapon.WeaponType.OneHanded:
                    OneHanded oneHanded = new OneHanded(
                        "", "", GenerateMaterialEnum(), GenerateQualityEnum(), 1f,
                        false, 0, Color.white, 1, 5, Weapon.DamageType.Bludgeoning,
                        Weapon.WeaponType.OneHanded, (OneHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(OneHanded.SubType)).Length + 1)
                        );
                    return oneHanded;
                case (int)Weapon.WeaponType.TwoHanded:
                    TwoHanded twoHanded = new TwoHanded(
                        "", "", GenerateMaterialEnum(), GenerateQualityEnum(), 1f,
                        false, 0, Color.white, 1, 5, Weapon.DamageType.Bludgeoning,
                        Weapon.WeaponType.TwoHanded, (TwoHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(TwoHanded.SubType)).Length + 1)
                        );
                    return twoHanded;;   
                case (int)Weapon.WeaponType.Shield:
                    Shield shield = new Shield(
                        "", "", GenerateMaterialEnum(), GenerateQualityEnum(), 1f,
                        false, 0, Color.white, 1, 5, Weapon.DamageType.Bludgeoning,
                        Weapon.WeaponType.Shield, (Shield.SubType)Random.Range(0, System.Enum.GetNames(typeof(Shield.SubType)).Length + 1)
                        );
                    return shield;; 
                case (int)Weapon.WeaponType.Ranged:
                    Ranged ranged = new Ranged(
                        "", "", GenerateMaterialEnum(), GenerateQualityEnum(), 1f,
                        false, 0, Color.white, 1, 5, Weapon.DamageType.Bludgeoning,
                        Weapon.WeaponType.Ranged, (Ranged.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ranged.SubType)).Length + 1)
                        );
                    return ranged;;  
                case (int)Weapon.WeaponType.Ammo:
                    Ammo ammo = new Ammo(
                        "", "", GenerateMaterialEnum(), GenerateQualityEnum(), 1f,
                        false, 0, Color.white, 1, 5, Weapon.DamageType.Bludgeoning,
                        Weapon.WeaponType.Ammo, (Ammo.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ammo.SubType)).Length + 1)
                        );
                    return ammo;
                default: Debug.Log("RandomItemGenerator: GenerateWeapon: RandomEquipType out of range"); return null;
            }
        }

        private static Item GenerateArmor()
        {
            throw new System.NotImplementedException();
        }

        private static Item GenerateJewelry()
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
    
        private static int GenerateTypeEnum() => Random.Range(0, System.Enum.GetNames(typeof(Helpers.Type.TypeEnum)).Length + 1);
        private static Helpers.Material.MaterialEnum GenerateMaterialEnum() => (Helpers.Material.MaterialEnum)Random.Range(0, System.Enum.GetNames(typeof(Helpers.Material.MaterialEnum)).Length + 1);
        private static Helpers.Quality.QualityEnum GenerateQualityEnum() => (Helpers.Quality.QualityEnum)Random.Range(0, System.Enum.GetNames(typeof(Helpers.Quality.QualityEnum)).Length + 1);   
        private static int GenerateWeaponTypeEnum() => Random.Range(0, System.Enum.GetNames(typeof(Weapon.WeaponType)).Length + 1);
    }
}