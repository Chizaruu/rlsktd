//To be moved to General/Helpers Folder later
namespace RLSKTD.General{
    public static class Support {
        public static UnityEngine.Color GetColourFromHex(string v)
        {
            UnityEngine.Color color;
            if (UnityEngine.ColorUtility.TryParseHtmlString(v, out color))
            {
                return color;
            } else
            {
                UnityEngine.Debug.Log("GetColourFromHex: Could not parse colour from string");
                return UnityEngine.Color.white;
            }
        }
    }
}
