using System;
using System.Collections.Generic;
using System.Text;

namespace LevelOrderTraversalUsingQueue
{
    class BInaryTreeNode
    {
        int data;
        BInaryTreeNode left;
        BInaryTreeNode right;

        public BInaryTreeNode() { }

        public BInaryTreeNode(int data) {
            this.data = data;
        }

        public int GetData() {
            return data;
        }

        public BInaryTreeNode GetLeft() {
            return left;
        }

        public BInaryTreeNode GetRight() {
            return right;
        }

        public void SetLeft(BInaryTreeNode bInaryTreeNode) {
            left = bInaryTreeNode;
        }

        public void SetRight(BInaryTreeNode bInaryTreeNode) {
            right = bInaryTreeNode;
        }

        public void SetData(int data) {
            this.data = data;
        }
    }
}
