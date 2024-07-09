using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MahjongApp.Tile
{
    public class TileBuilder : MonoBehaviour
    {
        [SerializeField] private List<Tile> tilePrefabs = null;

        public List<Tile> Build(List<Tile> tiles)
        {
            var tileList = new List<Tile>();

            foreach (var tile in tiles)
            {
                var t = GenerateTile(tile.TileType, tile.TileNumType);
                tileList.Add(t);
            }
            return tileList;
        }

        public Tile GenerateTile(TileType type , TileNumType numType)
        {
            var tileTile = tilePrefabs.FirstOrDefault(x => x.TileType == type && x.TileNumType == numType);
            var prefab = Instantiate(tileTile, Vector3.zero,Quaternion.identity);
            return prefab;
        }
    }
}