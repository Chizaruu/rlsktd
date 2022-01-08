using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.PotionSubcategories
{
    [System.Serializable]
    public class Dye : Potion
    {
        public enum SubType{
            Yellow, Blue, Red, Green, Purple, Orange, White, Black,
            Brown, Cyan, Magenta, Lime, Pink, Gray, Teal
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;
        
        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                
                SetNameAndDescription();
                SetThirst();
                SetBaseWeight();
                SetColor();
            }
        }

        public Dye(){
            _PotionType = PotionType.Dye;
            IsIdentified = true;
        }

        public Dye(SubType subType){
            _PotionType = PotionType.Dye;
            _SubType = subType; //This is set after PotionType for Color reasons 
            IsIdentified = true;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            Description = "A " + subType + " dye that can be used to dye clothes, weapons, and other items.";
        }

        private void SetThirst(){
            switch (subType)
            {
                default: Thirst = 10; break;
            }
        }

        private void SetBaseWeight(){
            switch (subType)
            {
                default: BaseWeight = 0.25f; break;
            }
        }

        private void SetColor(){
            switch (subType)
            {
                case SubType.Yellow: Color = UnityEngine.Color.yellow; break;
                case SubType.Blue: Color = UnityEngine.Color.blue; break;
                case SubType.Red: Color = UnityEngine.Color.red; break;
                case SubType.Green: Color = UnityEngine.Color.green; break;
                case SubType.Purple: Color = GetColourFromHex("#800080"); break;
                case SubType.Orange: Color = GetColourFromHex("#FFA500"); break;
                case SubType.White: Color = UnityEngine.Color.white; break;
                case SubType.Black: Color = UnityEngine.Color.black; break;
                case SubType.Brown: Color = GetColourFromHex("#964B00"); break;
                case SubType.Cyan: Color = UnityEngine.Color.cyan; break;
                case SubType.Magenta: Color = UnityEngine.Color.magenta; break;
                case SubType.Lime: Color = GetColourFromHex("#BFFF00"); break;
                case SubType.Pink: Color = GetColourFromHex("#FFC0CB"); break;
                case SubType.Gray: Color = UnityEngine.Color.gray; break;
                case SubType.Teal: Color = GetColourFromHex("#008080"); break;
                default: Color = UnityEngine.Color.white; break;
            }
        }

        private UnityEngine.Color GetColourFromHex(string v)
        {
            UnityEngine.Color color;
            if (UnityEngine.ColorUtility.TryParseHtmlString(v, out color))
            {
                return color;
            } else
            {
                UnityEngine.Debug.Log("RandomItemGenerator: GetColourFromHex: Could not parse colour from string");
                return UnityEngine.Color.white;
            }
        }

        [Button("Generate New Dye")]
        public void GenerateNewDye(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _PotionType = PotionType.Dye;
        }
    }
}