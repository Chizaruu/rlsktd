using RLSKTD.General.ItemCategories.WeaponSubcategories;
using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class WeaponGenerator{
        public static Item Generate(){
            switch ((Weapon.WeaponType)Random.Range(0, System.Enum.GetNames(typeof(Weapon.WeaponType)).Length)){
                case Weapon.WeaponType.OneHanded:
                    return new OneHanded((OneHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(OneHanded.SubType)).Length), MaterialGenerator.Generate(false, true));
                case Weapon.WeaponType.TwoHanded:
                    return new TwoHanded((TwoHanded.SubType)Random.Range(0, System.Enum.GetNames(typeof(TwoHanded.SubType)).Length), MaterialGenerator.Generate(false, true));   
                case Weapon.WeaponType.Shield:
                    return new Shield((Shield.SubType)Random.Range(0, System.Enum.GetNames(typeof(Shield.SubType)).Length), MaterialGenerator.Generate(false, true)); 
                case Weapon.WeaponType.Ranged:
                    return new Ranged((Ranged.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ranged.SubType)).Length), MaterialGenerator.Generate(false, true));
                case Weapon.WeaponType.Ammo:
                    return new Ammo((Ammo.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ammo.SubType)).Length), MaterialGenerator.Generate(false, true));
                default: Debug.Log("Generate: Weapon type not found"); return null;
            }
        }
    }
}