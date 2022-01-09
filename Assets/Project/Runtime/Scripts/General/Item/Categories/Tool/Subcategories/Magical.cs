using System;
using RLSKTD.General.ItemHelpers;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General.ItemCategories.ToolSubcategories
{
    [System.Serializable]
    public class Magical : Tool
    {
        public enum SubType{
            Wand, Rod, Staff
        }

        [OdinSerialize, UnityEngine.HideInInspector]private SubType subType;

        [OdinSerialize, UnityEngine.HideInInspector]private Effect effect;
        
        [ShowInInspector]public SubType _SubType
        {
            get => subType; set
            {
                subType = value;
                
                SetNameAndDescription();
                SetWeight();
            }
        }

        [ShowInInspector]public Effect _Effect { get => effect; set => effect = value; }

        public Magical(){
            _ToolType = ToolType.Magical;
        }

        public Magical(SubType subType, Material material){
            _SubType = subType;
            _ToolType = ToolType.Magical;
        }

        private void SetNameAndDescription()
        {
            Name = subType.ToString();

            switch (subType)
            {
                case SubType.Wand:
                    Description = "A magical wand";
                    break;
                case SubType.Rod:
                    Description = "A magical rod";
                    break;
                case SubType.Staff: 
                    Description = "A magical staff";
                    break;
                default:
                    Description = "A magical tool";
                    break;
            }
        }

        private void SetWeight()
        {
            switch (subType)
            {
                case SubType.Wand:
                    Weight = 0.2f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Rod:
                    Weight = 0.25f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                case SubType.Staff:
                    Weight = 2.2f + (float)Math.Round(_Material.Weight/3, 1);
                    break;
                default:
                    Weight = 1f;
                    break;
            }
        }
    }
}