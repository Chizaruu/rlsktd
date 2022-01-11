using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.PotionSubcategories
{
    [System.Serializable]
    public class Negative : Potion
    {
        public enum SubType{
            Acid, Poison, Blindness, Slow, Confusion, Love, Paralysis,
            Silence, Vomit, Weakness, Curse
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [OdinSerialize, UnityEngine.HideInInspector]private Effect effect;
        
        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                
                SetNameAndDescription();
                SetThirst();
                SetBaseWeight();
            }
        }

        [ShowInInspector]public Effect _Effect { get => effect; set => effect = value; }

        public Negative(){
            _PotionType = PotionType.Negative;
        }

        public Negative(SubType subType){
            _SubType = subType;
            _PotionType = PotionType.Negative;
        }

        private void SetNameAndDescription()
        {
            switch (subType)
            {
                case SubType.Acid:
                    Name = "Potion of Acid";
                    Description = "A strong acidic liquid";
                    break;
                case SubType.Poison:
                    Name = "Potion of Poison";
                    Description = "Green and bubbly liquid.";
                    break;
                case SubType.Blindness:
                    Name = "Potion of Blindness";
                    Description = "Causes sudden blindness.";
                    break;
                case SubType.Slow:
                    Name = "Potion of Slow";
                    Description = "Slows the target.";
                    break;
                case SubType.Confusion:
                    Name = "Potion of Confusion";
                    Description = "Causes confusion";
                    break;
                case SubType.Love:
                    Name = "Love Potion";
                    Description = "A strong love liquid that will make you(?) fall in love.";
                    break;
                case SubType.Paralysis:
                    Name = "Potion of Paralysis";
                    Description = "Causes loss of movement";
                    break;
                case SubType.Silence:
                    Name = "Potion of Silence";
                    Description = "Used for peace and quiet";
                    break;
                case SubType.Vomit:
                    Name = "Vomit";
                    Description = "Eww";
                    break;
                case SubType.Weakness:
                    Name = "Potion of Weakness";
                    Description = "Incites painful visions of past traumas.";
                    break;
                case SubType.Curse:
                    Name = "Potion of Curse";
                    Description = "Filled with a strong curse.";
                    break;
            }
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

        [Button("Generate New Negative")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _PotionType = PotionType.Negative;
        }
    }
}