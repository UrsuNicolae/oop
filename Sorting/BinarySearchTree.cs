namespace ConsoleApp1.Sorting
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(T value)
        {
            root = InsertRecursiv(root, value);
        }


        private TreeNode<T> InsertRecursiv(TreeNode<T> current, T value)
        {
            if (current == null)
            {
                return new TreeNode<T>(value);
            }

            if (value.CompareTo(current.Value) < 0)
            {
                current.Left = InsertRecursiv(current.Left, value);
            }
            else
            {
                current.Right = InsertRecursiv(current.Right, value);
            }
            return current;
        }

        public bool Search(T Value)
        {
            return SearchRecursive(root, Value);
        }

        private bool SearchRecursive(TreeNode<T> current, T value)
        {
            if (current == null)
            {
                return false;
            }

            if (value.CompareTo(current.Value) == 0)
            {
                return true;
            }
            
            if (value.CompareTo(current.Value) < 0)
            {
                return SearchRecursive(current.Left, value);
            }
            else
            {
                return SearchRecursive(current.Right, value);
            }
        }
    }

    class TreeNode<T>
    {
        public T Value { get; set; }

        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
