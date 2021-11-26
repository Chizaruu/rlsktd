using System;
using RLSKTD.General.Item.Helpers;
using RLSKTD.General.Item.Categories;
using RLSKTD.General.Item.Categories.WeaponSubcategories;

namespace RLSKTD.General.Item{
    public class RandomItemGenerator{

        private Item item;
        private Weapon weapon;
        private OneHanded oneHanded;

        public void GenerateItem()
        {
            item = new Item("", "", Material.MaterialType.Gold, Quality.QualityEnum.Superior, Weight.WeightEnum.VeryLight,
                0.1f, true, 0, UnityEngine.Color.red);

            GenerateWeapon(item);
        }


        public void GenerateWeapon(Item item)
        {
            weapon = new Weapon(item.Name, item.Description, item._MaterialType, item._Quality, item._WeightClass, item.Weight, item.IsIdentified, item.Worth, item.Color, 0, 0, 0);

            int randomEquipType = new System.Random().Next(0, Enum.GetNames(typeof(Weapon.WeaponType)).Length + 1); // Generates a number between 0 to EquipType.Length
            switch (randomEquipType){
                case (int)Weapon.WeaponType.One_Handed:
                    weapon._WeaponType = Weapon.WeaponType.One_Handed;

                    int randomOneHanded = new System.Random().Next(0, Enum.GetNames(typeof(Weapon.WeaponType)).Length + 1); // Generates a number between 0 to EquipType.Length
                    switch (randomOneHanded){
                        case (int)OneHanded.SubType.Shortsword:
                            oneHanded = new OneHanded(weapon.Name, weapon.Description, weapon._MaterialType, weapon._Quality, weapon._WeightClass, weapon.Weight, weapon.IsIdentified, weapon.Worth, weapon.Color, 
                            weapon.Damage, Weapon.DamageType.Slashing, weapon._WeaponType, OneHanded.SubType.Shortsword);
                            break;
                        case (int)OneHanded.SubType.Longsword:
                            break;
                        case (int)OneHanded.SubType.Dagger:
                            break;
                        case (int)OneHanded.SubType.Scimitar:
                            break;
                        case (int)OneHanded.SubType.Cutlass:
                            break;
                        case (int)OneHanded.SubType.Rapier:
                            break;
                        case (int)OneHanded.SubType.Kris:
                            break;
                        case (int)OneHanded.SubType.Saber:
                            break;
                        case (int)OneHanded.SubType.Club:
                            break;
                        case (int)OneHanded.SubType.Mace:
                            break;
                        case (int)OneHanded.SubType.Shortspear:
                            break;
                        case (int)OneHanded.SubType.Sickle:
                            break;
                        case (int)OneHanded.SubType.Morningstar:
                            break;
                        case (int)OneHanded.SubType.Whip:
                            break;
                        case (int)OneHanded.SubType.Flail:
                            break;
                        case (int)OneHanded.SubType.Handaxe:
                            break;
                    }
                    break;
                case (int)Weapon.WeaponType.Two_Handed:
                    break;   
                case (int)Weapon.WeaponType.Shield:
                    break; 
                case (int)Weapon.WeaponType.Ranged:
                    break;  
                case (int)Weapon.WeaponType.Ammo:
                    break;
            }
        }
    }
}