﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilesOfMonkeyIsland.Algorithm
{
    class AStar : Algorithm
    {
        public AStar(TileWorld.TileWorld world)
            : base(world)
        {}
        
        // TO CHANGE 
        override protected float calculateHeuristic(Node node)
        {
            // Calculate the minimal distance walking horizontally / vertically and diagonally.
            float distanceX = Math.Abs(node.x - this.goalNode.x);
            float distanceY = Math.Abs(node.y - this.goalNode.y);
            float distance;

            if (distanceX >= distanceY)
            {
                distance = (distanceX - distanceY) + distanceY * 1.4f;
            }
            else
            {
                distance = (distanceY - distanceX) + distanceX * 1.4f;
            }

            // Return the heuristic.
            return node.cost + distance;
        }
    }
}
