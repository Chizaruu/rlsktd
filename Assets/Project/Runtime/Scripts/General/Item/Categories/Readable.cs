using RLSKTD.General.ItemHelpers.SoftMaterials;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories
{
    [System.Serializable]
    public class Readable : Item
    {
        public enum ReadableType{
            Scroll, Book
        }

        public enum Difficulty{
            Easy, Medium, Hard
        }

        [OdinSerialize, UnityEngine.HideInInspector]private ReadableType readableType;

        [OdinSerialize, UnityEngine.HideInInspector]private Difficulty difficulty;

        [OdinSerialize, UnityEngine.HideInInspector]private float baseWeight;

        [OdinSerialize, UnityEngine.HideInInspector]private int stackAmount = 1;

        [OdinSerialize, UnityEngine.HideInInspector]private Effect effect = null;
        
        /// <summary> Used to get and set potionType, also sets _Type and _Material </summary>
        [ShowInInspector, ReadOnly]public ReadableType _ReadableType
        {
            get => readableType; set
            {
                readableType = value;

                _Type = Type.Readable;
                _Material = new Common(Common.Material.Paper);
            }
        }

        [ShowInInspector, ReadOnly]public Difficulty _Difficulty { get => difficulty; set => difficulty = value; }

        [ShowInInspector, ReadOnly]public float BaseWeight
        {
            get => baseWeight; set
            {
                baseWeight = value;

                Weight = baseWeight;
            }
        }
        
        [ShowInInspector, ReadOnly]public int StackAmount
        {
            get => stackAmount; set
            {
                if(value > 0 ){
                    stackAmount = value;
                } else {
                    stackAmount = 1;
                }

                Weight = baseWeight * stackAmount;
            }
        }

        [ShowInInspector, ReadOnly]public Effect _Effect { get => effect; set => effect = value; }
    }
}