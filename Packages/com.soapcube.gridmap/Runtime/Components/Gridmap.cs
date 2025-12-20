using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Gridmap
{
    public class Gridmap : Component
    {
        private readonly Vector3Int chunkSize = new(16, 16, 16);

        private List<MeshChunk> chunks = new List<MeshChunk>();

        public void PlaceTileAtPoint(MeshTileBase tile, Vector3Int point)
        {

        }
    }
}
