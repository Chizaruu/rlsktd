using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Sirenix.OdinInspector;

namespace RLSKTD.Map
{
    /// <summary> Manages the map. </summary>
    public class MapManager : SerializedMonoBehaviour
    {
        public static MapManager instance; // The instance of the map manager.

        public Grid grid; // The grid of the map.
        public Tilemap floorMap; // The floor map of the map.
        public Tilemap obstacleMap; // The obstacle map of the map.
        public Tilemap fogMap; // The fog map of the map.

        public Dictionary<Vector3, WorldTile> floorTiles = new Dictionary<Vector3, WorldTile>(); // The floor tiles of the map.8
        public Dictionary<Vector3, WorldTile> obstacleTiles = new Dictionary<Vector3, WorldTile>(); // The obstacle tiles of the map.
        public Dictionary<Vector3, WorldTile> fogTiles = new Dictionary<Vector3, WorldTile>(); // The fog tiles of the map.

        /// <summary> Awake is called when the script instance is being loaded. </summary>
        private void Awake()
        {
            if (instance == null) //If instance is not assigned
            {
                instance = this; //Assign instance to this
            }
            else //else no need for this gameobject!
            {
                Destroy(gameObject); //Destroy this gameobject
            }
        } 

        /// <summary> Initializes the map manager. </summary>
        private void Start()
        {
            SetUpMapTiles(fogMap, fogTiles); // Sets up the fog tiles.
            SetUpMapTiles(floorMap, floorTiles); // Sets up the floor tiles.
            SetUpMapTiles(obstacleMap, obstacleTiles); // Sets up the obstacle tiles.
        } 

        /// <summary> Sets up the map tiles. </summary>
        private void SetUpMapTiles(Tilemap map, Dictionary<Vector3, WorldTile> tiles)
        {
            // Gets the tiles.
            foreach (Vector3Int pos in map.cellBounds.allPositionsWithin)
            {
                var lPos = new Vector3Int(pos.x, pos.y, pos.z); // Gets the local position.
    
                if (!map.HasTile(lPos)) continue; // If the tile doesn't exist, continue.

                // Gets the tile.
                WorldTile tile = new WorldTile()
                {
                    localPlace = lPos, // Sets the local place.
                    gridLocation = map.CellToWorld(lPos), // Sets the grid location.
                    tileBase = map.GetTile(lPos).name, // Sets the tile base.
                    color = map.GetColor(lPos), // Sets the color.
                };
                
                tiles.Add(tile.gridLocation, tile); // Adds the tile to the fog tiles.
            }
            
        }
    }
}