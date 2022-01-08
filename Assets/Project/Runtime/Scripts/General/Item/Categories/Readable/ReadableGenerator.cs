using RLSKTD.General.ItemCategories.ReadableSubcategories;
using RLSKTD.General.ItemHelpers;
using UnityEngine;

namespace RLSKTD.General.ItemCategories{
    public class ReadableGenerator{
        public static Item Generate(){
            switch ((Readable.ReadableType)Random.Range(0, System.Enum.GetNames(typeof(Readable.ReadableType)).Length))
            {
                case Readable.ReadableType.Book:
                    return new Book((Book.SubType)Random.Range(0, System.Enum.GetNames(typeof(Book.SubType)).Length));
                case Readable.ReadableType.Scroll:
                    return new Scroll((Scroll.SubType)Random.Range(0, System.Enum.GetNames(typeof(Scroll.SubType)).Length));
                default : Debug.Log("Generate: Readable type not found"); return null;
            }
        }
    }
}