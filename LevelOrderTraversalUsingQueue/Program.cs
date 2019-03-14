using System;

namespace LevelOrderTraversalUsingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Level order traversal using Queue!");
            Console.WriteLine("----------------------------------");

            BinaryTree tree = GetBinaryTreeFromInput();
            Console.WriteLine("Printing inorder traversal-----------");
            tree.InorderTraversal(tree.GetRoot());
            Console.WriteLine();

            Console.WriteLine("Printing Level order traversal");
            tree.LevelOrderTraversal(tree.GetRoot());
            Console.WriteLine();

            Console.ReadLine();
        }

        private static BinaryTree GetBinaryTreeFromInput() {
            BinaryTree binaryTree = null;

            Console.WriteLine("Enter the number of nodes in the Binary tree");
            try
            {
                int numberNodes = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the values of the nodes" +
                    " separated by space");
                binaryTree = new BinaryTree();
                String[] elements = Console.ReadLine().Split(' ');
                for (int i = 0; i < numberNodes; i++)
                {
                    binaryTree.SetBinaryTreeRoot(binaryTree.Insert(binaryTree.GetRoot(),
                        int.Parse(elements[i])));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Thrown exception is " + exception.Message);
            }

            return binaryTree;
        }
    }
}
