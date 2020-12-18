using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TilesOfMonkeyIsland.TileWorld;

namespace TilesOfMonkeyIsland.Algorithm
{
    class BFS : Algorithm
    {
        public BFS(TileWorld.TileWorld world)
            : base(world)
        { }

        override protected float calculateHeuristic(Node node)
        {
            // Calculate the minimal distance walking horizontally / vertically and diagonally.
            float distance = (float)Math.Sqrt(Math.Pow(node.x - goalNode.x, 2) + Math.Pow(node.y - goalNode.y, 2));

            // Return the heuristic.
            return distance;
        }
    }
}
