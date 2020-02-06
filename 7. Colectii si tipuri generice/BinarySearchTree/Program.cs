using System;
namespace DemoTree
{
    class TreeNode
    {
        private int value;
        private TreeNode left, right;

        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            Value = val;
            Left = left;
            Right = right;
        }
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public TreeNode Left
        {
            get
            {
                return left;
            }
            set
            {
                this.left = value;
            }
        }

        public TreeNode Right
        {
            get
            {
                return right;
            }
            set
            {
                this.right = value;
            }
        }
    }
}

namespace BinarySearchTree
{
    using System.Collections.Generic;
    using DemoTree;
    class BinarySearchTree
    {
        private TreeNode root = null;

        #region Add values to the tree
        /// <summary>
        /// Add values to the tree
        /// </summary>
        /// <param name="value">A collection of values to be added, submitted as params array</param>
        public void AddValues(params int[] values)
        {
            foreach(int value in values)
            {
                add(value);
            }
        }
        #endregion

        #region in-order traversal
        ///<summary>
        /// Performs an inorder traversal of the tree
        /// </summary>
        /// <returns>A sequence of values, following the in-order traversal strategy</returns>
        public IEnumerable<int> InOrder()
        {
            return inOrder(root);
        }
        #endregion

        #region Private helper methods
        ///<summary>
        /// Do the in-order traversal
        /// </summary>
        /// <param name="="node">The node</param>
        /// <returns>A sequence of values, following the in-order traversal strategy</returns>
        private IEnumerable<int> inOrder(TreeNode node)
        {
            if(node.Left != null)
            {
                foreach(int value in inOrder(node.Left))
                {
                    yield return value;
                }
            }
            yield return node.Value;
            if(node.Right != null)
            {
                foreach(int value in inOrder(node.Right))
                {
                    yield return value;
                }
            }
        }

        ///<summary>
        /// Adds the specified value to the binary search tree
        /// </summary>
        /// <param name="="value">The value to be added.</param>
        private void add(int value)
        {
            if(root == null)
            {
                root = new TreeNode(value, null, null);
                return;
            }
            TreeNode current = root;
            while(true)
            {
                if(value < current.Value)
                {
                    if(current.Left == null)
                    {
                        current.Left = new TreeNode(value, null, null);
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else // value >= current.Value
                {
                    if(current.Right == null)
                    {
                        current.Right = new TreeNode(value, null, null);
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }
        #endregion
    }
    class Program
    {
        static void Main()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.AddValues(1, 2, -3, -2);
            foreach(int x in tree.InOrder())
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
