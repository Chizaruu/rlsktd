using RLSKTD.General.ItemCategories.ArmorSubcategories;
using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class ArmorGenerator{
        public static Item Generate(){
            switch ((Armor.ArmorType)Random.Range(0, System.Enum.GetNames(typeof(Armor.ArmorType)).Length)){
                default:
                case Armor.ArmorType.Head:
                    return new Head((Head.SubType)Random.Range(0, System.Enum.GetNames(typeof(Head.SubType)).Length), MaterialGenerator.Generate(true, false));
                case Armor.ArmorType.Back:
                    return new Back((Back.SubType)Random.Range(0, System.Enum.GetNames(typeof(Back.SubType)).Length), MaterialGenerator.Generate(false, false));
                case Armor.ArmorType.Body:
                    return new Body((Body.SubType)Random.Range(0, System.Enum.GetNames(typeof(Body.SubType)).Length), MaterialGenerator.Generate(true, false));
                case Armor.ArmorType.Hand: 
                    return new Hand((Hand.SubType)Random.Range(0, System.Enum.GetNames(typeof(Hand.SubType)).Length), MaterialGenerator.Generate(true, false));
                case Armor.ArmorType.Waist:
                    return new Waist((Waist.SubType)Random.Range(0, System.Enum.GetNames(typeof(Waist.SubType)).Length), MaterialGenerator.Generate(true, false));
                case Armor.ArmorType.Foot:
                    return new Foot((Foot.SubType)Random.Range(0, System.Enum.GetNames(typeof(Foot.SubType)).Length), MaterialGenerator.Generate(true, false));
                case Armor.ArmorType.Neck:
                    return new Neck((Neck.SubType)Random.Range(0, System.Enum.GetNames(typeof(Neck.SubType)).Length), MaterialGenerator.Generate(false, true));
                case Armor.ArmorType.Finger:
                    return new Finger((Finger.SubType)Random.Range(0, System.Enum.GetNames(typeof(Finger.SubType)).Length), MaterialGenerator.Generate(false, true));
                case Armor.ArmorType.Ear:
                    return new Ear((Ear.SubType)Random.Range(0, System.Enum.GetNames(typeof(Ear.SubType)).Length), MaterialGenerator.Generate(false, true));
            }
        }
    }
}