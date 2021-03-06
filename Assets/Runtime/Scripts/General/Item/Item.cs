using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace RLSKTD.General{
    /// <summary> Base class for all items. </summary>
    /// <remarks> This class is used to define the base properties of all items. </remarks>
    [System.Serializable]
    public class Item {
        /// <summary> The quality of an item. </summary>
        /// <remarks> 
        /// Quality will affect the performance of the item.
        /// Example: 
        ///     Food = increased satiety, mood, etc 
        ///     Weapon = increased damage, durability, etc
        ///     Armor = increased defense, durability, etc
        ///</remarks>
        public enum Quality {
            /// <summary> The item is of inferior quality. </summary>
            Inferior,
            /// <summary> The item is of normal quality. </summary>
            Normal,
            /// <summary> The item is of superior quality. </summary>
            Superior,
            /// <summary> The item is of exceptional quality. </summary>
            Exceptional,
            /// <summary> The item is of unique quality. </summary>
            Unique,
            /// <summary> The item is of legendary quality. </summary>
            Legendary
        }

        /// <summary> Enums of all item types. </summary>
        public enum Type {
            /// <summary> The item is a weapon. </summary>
            Weapon,
            /// <summary> The item is an armor piece. </summary>
            Armor,
            /// <summary> The item is food. </summary>
            Food,
            /// <summary> The item is a potion. </summary>
            Potion,
            /// <summary> The item is readable. </summary>
            Readable,
            /// <summary> The item is a tool. </summary>
            Tool,
            /// <summary> The item is furniture. </summary>
            Furniture,
            /// <summary> The item is a material. </summary>
            Material,
            /// <summary> The item is miscellaneous. </summary>
            Miscellaneous
        }

        /// <summary> The name of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private string name;
        /// <summary> The description of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private string description;
        /// <summary> The material of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private ItemHelpers.Material material;
        /// <summary> The quality of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private Quality quality;
        /// <summary> The type of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private Type type;
        /// <summary> The weight of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private float weight;
        /// <summary> The identify clarification of the item. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private bool isIdentified;
        /// <summary> The item's value. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private int value;
        /// <summary> The item's color. </summary>
        [OdinSerialize, UnityEngine.HideInInspector]private UnityEngine.Color color;

        [ShowInInspector]public string Name { get => name; set => name = value; }
        [ShowInInspector]public string Description { get => description; set => description = value; }
        [ShowInInspector]public bool IsIdentified { get => isIdentified; set => isIdentified = value; }
        [ShowInInspector]public ItemHelpers.Material _Material
        {
            get => material; set
            {
                material = value;
                Weight = value.Weight;
                Color = value.Color;
            }
        }
        [ShowInInspector, ReadOnly]public Quality _Quality { get => quality; set => quality = value; }
        [ShowInInspector, ReadOnly]public Type _Type { get => type; set => type = value; }
        [ShowInInspector, ReadOnly]public float Weight { get => weight; set => weight = value; }
        [ShowInInspector, ReadOnly]public int Value { get => value; set => this.value = value; }
        [ShowInInspector, ReadOnly]public UnityEngine.Color Color { get => color; set => color = value; }

        /// <summary> Blank constructor for the Item class. </summary>
        public Item(){}

        /// <summary> Constructor for the Item class with material parameter. </summary>
        public Item(ItemHelpers.Material material){
            _Material = material;
            _Type = Type.Material;
            _Quality = Quality.Normal;
            IsIdentified = true; //Set to true by default
            Name = material.Name;
            Description = material.Description;
        }

        public void GenerateName(string item){
            //Generate name using the quality, material and item parameter
            Name = _Quality.ToString() + " " + _Material.Name + " " + item;

            //TODO: Add more name generation options
        }

        public void GenerateDescription(){
            //TODO: Generate description
        }

        public void GenerateQuality(){
            _Quality = (Quality)UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(Quality)).Length); //TODO: Generate quality based on meaningful rules
        }

        public void GenerateValue(){
            Value = UnityEngine.Random.Range(0, 100); //TODO: Generate value based on meaningful rules
        }
    }
}