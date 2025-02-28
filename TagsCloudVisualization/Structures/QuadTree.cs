﻿using System.Drawing;
using ResultOf;

namespace TagsCloudVisualization.Structures
{
    public class QuadTree
    {
        private readonly Rectangle canvas;
        protected readonly QuadTreeNode root;

        public QuadTree(Rectangle canvas)
        {
            this.canvas = canvas;
            root = new QuadTreeNode(this.canvas);
        }

        public Result<None> Insert(Rectangle item)
        {
            return root.Insert(item);
        }

        public bool IntersectsWith(Rectangle area)
        {
            return root.IntersectsWith(area);
        }
    }
}