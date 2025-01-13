namespace SearchInABinarySearchTree
{
    /*
    You are given the root of a binary search tree (BST) and an integer val.
    Find the node in the BST that the node's value equals val and return the subtree rooted with that node.
    If such a node does not exist, return null.

    Input: root = [4,2,7,1,3], val = 2
    Output: [2,1,3]
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;

            if (root.val == val) 
                return root;
            else if (root.val < val)
                return SearchBST(root.right, val);
            else 
                return SearchBST(root.left, val);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
