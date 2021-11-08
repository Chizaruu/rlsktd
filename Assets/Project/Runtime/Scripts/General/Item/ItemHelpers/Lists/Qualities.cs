using System.Collections.Generic;

namespace RLSKTD.General.ItemHelper
{
    /// <summary> Quality of an item. </summary>
    sealed class Qualities
    {
        /// <summary> List of qualities. </summary>
        private List<string> quality = new List<string>()
        {
            "Inferior", "Basic", "Superior"
        };

        public List<string> Quality { get => quality; } // Getter for list of qualities.
    }
}