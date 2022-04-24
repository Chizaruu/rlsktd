using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ReadableSubcategories
{
    [System.Serializable]
    public class Scroll : Readable
    {
        public enum SubType{
            Scroll, Atlas, Note, Map, Tablet
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

        public Scroll(){
            _ReadableType = ReadableType.Scroll;
        }

        public Scroll(SubType subType){
            _SubType = subType;
            _ReadableType = ReadableType.Scroll;
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
                case SubType.Atlas:
                    BaseWeight = 0.35f;
                    break;
                case SubType.Tablet:
                    BaseWeight = 1.1f;
                    break;
                default: BaseWeight = 0.1f; break;
            }
        }

        [Button("Generate New Scroll")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _ReadableType = ReadableType.Scroll;
        }
    }
}