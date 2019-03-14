using System;
using System.Collections.Generic;
using System.Text;

namespace LevelOrderTraversalUsingQueue
{
    class BinaryTree
    {
        BInaryTreeNode root;

        public BinaryTree() { }
        public BinaryTree(BInaryTreeNode bInaryTreeNode) {
            root = bInaryTreeNode;
        }

        public void SetBinaryTreeRoot(BInaryTreeNode bInaryTreeNode) {
            root = bInaryTreeNode;
        }

        public BInaryTreeNode GetRoot() {
            return root;
        }

        public BInaryTreeNode Insert(BInaryTreeNode root, int data) {
            if (root == null) {
                root = new BInaryTreeNode(data);
                return root;
            }

            if (data < root.GetData()) {
                root.SetLeft(Insert(root.GetLeft(), data));
            }

            if (data > root.GetData()) {
                root.SetRight(Insert(root.GetRight(), data));
            }

            return root;
        }

        public void InorderTraversal(BInaryTreeNode bInaryTreeNode) {
            if (bInaryTreeNode == null) {
                return;
            }

            InorderTraversal(bInaryTreeNode.GetLeft());
            Console.Write(bInaryTreeNode.GetData()+" ");
            InorderTraversal(bInaryTreeNode.GetRight());
        }

        public void LevelOrderTraversal(BInaryTreeNode bInaryTreeNode) {
            if (bInaryTreeNode == null) {
                return;
            }

            Queue<BInaryTreeNode> queue = new Queue<BInaryTreeNode>();
            queue.Enqueue(bInaryTreeNode);

            while (queue.Count > 0) {
                BInaryTreeNode outValue = queue.Dequeue();
                if (outValue != null) {
                    Console.Write(outValue.GetData() + " ");


                    if (outValue.GetLeft() != null) {
                        queue.Enqueue(outValue.GetLeft());
                    }

                    if (outValue.GetRight() != null) {
                        queue.Enqueue(outValue.GetRight());
                    }
                }
            }
        }
    }
}
