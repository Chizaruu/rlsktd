using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RLSKTD.Map;

namespace RLSKTD.Map.Generator.Dungeon
{
    /// <summary> Dungeon generator drunken step. </summary>
    public class DrunkenStep : MapGenerator
    {   
        /// <summary> Generate map using drunken step algorithm using 
        protected override void GenerateMap()
        {
            SetUpWalls();

            int totalArea = width * height;
            int desiredFloorTiles = Random.Range(0, totalArea);
            int currentFloorTiles = 0;
            int randomX = Random.Range(0, width);
            int randomY = Random.Range(0, height);

            Vector3Int stepPos = new Vector3Int(randomX, randomY, 0);

            MapManager.instance.obstacleMap.SetTile(stepPos, null);
            MapManager.instance.floorMap.SetTile(stepPos, floorTiles[Random.Range(0, floorTiles.Length)]);
            MapManager.instance.obstacleMap.SetTile(new Vector3Int(stepPos.x, stepPos.y + 1, 0), wallTiles[Random.Range(0, wallTiles.Length)]);

            while(currentFloorTiles < desiredFloorTiles) 
            {
                int randomDirection = Random.Range(0, 4);
                switch(randomDirection)
                {
                    case 0:
                        stepPos.x++;
                        break;
                    case 1:
                        stepPos.x--;
                        break;
                    case 2:
                        stepPos.y++;
                        break;
                    case 3:
                        stepPos.y--;
                        break;
                }

                if(stepPos.x < 0 || stepPos.x >= width || stepPos.y < 0 || stepPos.y >= height)
                {
                    continue;
                }

                if(MapManager.instance.obstacleMap.GetTile(stepPos) != null)
                {
                    continue;
                }

                MapManager.instance.obstacleMap.SetTile(stepPos, null);
                MapManager.instance.floorMap.SetTile(stepPos, floorTiles[Random.Range(0, floorTiles.Length)]);
                MapManager.instance.obstacleMap.SetTile(new Vector3Int(stepPos.x, stepPos.y + 1, 0), wallTiles[Random.Range(0, wallTiles.Length)]);

                currentFloorTiles++;
            }

        }

        private void SetUpWalls()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        MapManager.instance.obstacleMap.SetTile(new Vector3Int(x, y, 0), wallTiles[Random.Range(0, wallTiles.Length)]);
                    }
                    else
                    {
                        MapManager.instance.obstacleMap.SetTile(new Vector3Int(x, y, 0), null);
                    }
                }
            }
        }
    }
}
