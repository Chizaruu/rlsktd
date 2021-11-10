using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.Tilemaps;

namespace RLSKTD.Map.Generator
{
    /// <summary> Parent class for all map generators </summary>
    public class MapGenerator : SerializedMonoBehaviour
    {
        /// <summary> The map's width </summary>
        [SerializeField] protected int width = 31;
        /// <summary> The map's height </summary>
        [SerializeField] protected int height = 21;
        /// <summary> The map's seed </summary>
        [SerializeField] protected int seed = 0;

        /// <summary> The map's floor tiles </summary>
        [SerializeField] protected Tile[] floorTiles;
        /// <summary> The map's wall tiles </summary>
        /// <remarks> The wall tiles are used for the outer walls of the map </remarks>
        [SerializeField] protected Tile[] wallTiles;

        /// <summary> Returns the map's width </summary>
        public int Width { get { return width; } } 
        /// <summary> Returns the map's height </summary>
        public int Height { get { return height; } }
        /// <summary> Returns the map's seed </summary>
        public int Seed { get { return seed; } }

        /// <summary> Initializes the map generator </summary>
        private void Start() => GenerateMap();

        /// <summary> Generates the map </summary>
        protected virtual void GenerateMap() {}

        /// <summary> Generate map seed </summary>
        /// <returns> The generated seed </returns>
        /// <param name="seed"> The seed to generate </param>
        protected int GenerateSeed(int seed)
        {
            if (seed == 0)
            {
                seed = Random.Range(0, int.MaxValue);
            }
            return seed;
        }
    }
}

