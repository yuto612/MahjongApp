using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MahjongApp.Tile
{
    public class Tile : MonoBehaviour
    {
        [SerializeField] private TileType tileType;
        [SerializeField] private TileNumType tileNumType;

        public TileType TileType => tileType;
        public TileNumType TileNumType => tileNumType;

        public Tile(TileType tileType, TileNumType tileNumType)
        {
            this.tileType = tileType;
            this.tileNumType = tileNumType;
        }
    }
}