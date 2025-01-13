namespace Leaf_SimilarTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool AreLeavesSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> leafSequence1 = GetLeafSequence(root1);
            List<int> leafSequence2 = GetLeafSequence(root2);
            return leafSequence1.SequenceEqual(leafSequence2);
        }

        private List<int> GetLeafSequence(TreeNode root)
        {
            if(root == null)
            {
                return new List<int>();
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            List<int> leafValues = new List<int>();
            while (queue.Count > 0)
            {
                TreeNode currentNode = queue.Dequeue();
                if (currentNode.left == null && currentNode.right == null)
                {
                    leafValues.Add(currentNode.val);
                }
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
            return leafValues;
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
