using System.Collections;
using System.Collections.Generic;
using MahjongApp.Tile;
using UnityEngine;

namespace MahjongApp.View
{
    public class ViewPresenter : MonoBehaviour
    {
        [SerializeField] private TileBuilder tileBuilder = null;

        // Start is called before the first frame update
        void Start()
        {
            // �e�X�g�R�[�h
            var list = new List<Tile.Tile>()
            {
                new Tile.Tile(TileType.Man, TileNumType.Nine),


            };

            tileBuilder.Build(list);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}