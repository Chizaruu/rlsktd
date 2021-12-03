namespace RLSKTD.General.ItemHelpers {
    /// <summary> The type of an item. </summary>
    public class Type {
        /// <summary> Enums of all item types. </summary>
        public enum TypeEnum {
            /// <summary> The item is a weapon type. </summary>
            Weapon,
            /// <summary> The item is a armor type. </summary>
            Armor,
            /// <summary> The item is a food type. </summary>
            Food,
            /// <summary> The item is a potion type. </summary>
            Potion,
            /// <summary> The item is a scroll type. </summary>
            Scroll,
            /// <summary> The item is a rod type. </summary>
            Rod,
            /// <summary> The item is a book type. </summary>
            Book,
            /// <summary> The item is a tool type. </summary>
            Tool,
            /// <summary> The item is a furniture type. </summary>
            Furniture,
            /// <summary> The item is a material type. </summary>
            Material,
            /// <summary> The item is misc type. </summary>
            Misc,
        }

        /// <summary> The type of the item. </summary>
        private TypeEnum typeEnum;

        public TypeEnum _TypeEnum { get => typeEnum; set => typeEnum = value; }

        /// <summary> Constructor for the item type. </summary>
        /// <param name="type"> The type of the item. </param>
        public Type(TypeEnum typeEnum) => this.typeEnum = typeEnum;
    }
}