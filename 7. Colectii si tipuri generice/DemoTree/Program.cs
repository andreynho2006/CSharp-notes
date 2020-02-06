using System;

namespace DemoTree
{
    // definitia tipului nod
    class TreeNode
    {
        private int value;
        private TreeNode left, right;

        public TreeNode( int value, TreeNode left, TreeNode right)
        {
            Value = value;
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
                left = value;
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
                right = value;
            }
        }

        public static void Main(string[] args)
        {
        

        }
    }
}
