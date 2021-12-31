using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ReadableSubcategories
{
    [System.Serializable]
    public class Book : Readable
    {
        public enum SubType{
            Book, Journal, Tome, Booklet, Manual
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;
        
        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;

                SetNameAndDescription();
                SetBaseWeight();
            }
        }

        public Book(){
            _ReadableType = ReadableType.Book;
        }

        public Book(SubType subType){
            _SubType = subType;
            _ReadableType = ReadableType.Book;
        }

        private void SetNameAndDescription(){
            Name = subType.ToString();

            switch(subType){
                default :
                    Description = "A " + subType + " that can be read.";
                    break;
            }
        }

        private void SetBaseWeight(){
            switch (subType)
            {
                case SubType.Tome:
                    BaseWeight = 0.7f;
                    break;
                default: BaseWeight = 0.5f; break;
            }
        }

        [Button("Generate New Book")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _ReadableType = ReadableType.Book;
        }
    }
}