using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.PotionSubcategories
{
    [System.Serializable]
    public class Positive : Potion
    {
        public enum SubType{
            CureMinorWounds, CureMajorWounds, CureCriticalWounds, Hero,
            Defender, Healer, Strength, Resistance, Speed, RestoreBody,
            RestoreSpirit, Potential
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

        public Positive(){
            _PotionType = PotionType.Positive;
        }

        public Positive(SubType subType){
            _SubType = subType;
            _PotionType = PotionType.Positive;
        }

        private void SetNameAndDescription()
        {
            switch(subType){
                case SubType.CureMinorWounds:
                    Name = "Potion of Cure Minor Wounds";
                    Description = "A small potion that will cure minor wounds.";
                    break;
                case SubType.CureMajorWounds:
                    Name = "Potion of Cure Major Wounds";
                    Description = "A large potion that will cure major wounds.";
                    break;
                case SubType.CureCriticalWounds:
                    Name = "Potion of Cure Critical Wounds";
                    Description = "A large potion that will cure critical wounds.";
                    break;
                case SubType.Hero:
                    Name = "Potion of Hero";
                    Description = "A potion that will increase strength. Cures confusion and fear.";
                    break;
                case SubType.Defender:
                    Name = "Potion of Defender";
                    Description = "A potion that will increase defense.";
                    break;
                case SubType.Healer:
                    Name = "Potion of Healer";
                    Description = "A potion that will cure major wounds. Cures most negative effects.";
                    break;
                case SubType.Strength:
                    Name = "Potion of Strength";
                    Description = "A potion that will allow you to carry more Baseweight.";
                    break;
                case SubType.Resistance:
                    Name = "Potion of Resistance";
                    Description = "A potion that will increase resistance.";
                    break;
                case SubType.Speed:
                    Name = "Potion of Speed";
                    Description = "A potion that will increase speed.";
                    break;
                case SubType.RestoreBody:
                    Name = "Potion of Restore Body";
                    Description = "A potion that will restore the body.";
                    break;
                case SubType.RestoreSpirit:
                    Name = "Potion of Restore Spirit";
                    Description = "A potion that will restore the spirit.";
                    break;
                case SubType.Potential:
                    Name = "Potion of Potential";
                    Description = "A potion that will increase potential.";
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

        [Button("Generate New Positive")]
        public void Generate(){
            _SubType = (SubType)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(SubType)).Length);
            _PotionType = PotionType.Positive;
        }
    }
}