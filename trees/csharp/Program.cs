class Program
{

    // Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    static void Main(string[] args)
    {
        {
            // ------------------------------------ Traversal Function Test -----------------------
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            // ----- PreOrder -----
            IList<int> preOrder = PreorderTraversal(root);
            Console.Write("[");
            foreach (int i in preOrder) {
                Console.Write(i + ", ");
            }
            Console.WriteLine("]");

            // ----- InOrder -----
            IList<int> inOrder = InorderTraversal(root);
            Console.Write("[");
            foreach (int i in inOrder) {
                Console.Write(i + ", ");
            }
            Console.WriteLine("]");

            // ----- PostOrder -----
            IList<int> postOrder = PostorderTraversal(root);
            Console.Write("[");
            foreach (int i in postOrder) {
                Console.Write(i + ", ");
            }
            Console.WriteLine("]");
        }

        {
            // ------------------------------------ Traversal Function Test -----------------------
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(8);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            Console.WriteLine(MaxDepth(root));
        }

        {
            // ------------------------------------ IsSymmetric Function Test -----------------------
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            Console.WriteLine(IsSymmetric(root));
        }

    }

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Binary Tree Preorder Traversal
    // 
    // Given the root of a binary tree, return the preorder traversal of its nodes' values.
    // Root, Left, Right
    //
    // Input: root = [1,null,2,3]
    // Output: [1,2,3]
    //
    // https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/928/
    // ------------------------------------------------------------------------------------
    static IList<int> PreorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        if (root == null) return list;
        // Add Root
        list.Add(root.val);
        // Recursively traverse left tree
        if (root.left != null) {
            IList<int> leftList = PreorderTraversal(root.left);
            foreach (int i in leftList) {
                list.Add(i);
            }
        }
        // Recursively traverse right tree
        if (root.right != null) {
            IList<int> rightList = PreorderTraversal(root.right);
            foreach (int i in rightList) {
                list.Add(i);
            }
        }
        return (IList<int>) list;
    }

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Binary Tree Inorder Traversal
    // 
    // Given the root of a binary tree, return the inorder traversal of its nodes' values.
    // Left, Root, Right
    //
    // Input: root = [1,null,2,3]
    // Output: [1,3,2]
    //
    // https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/929/
    // ------------------------------------------------------------------------------------
    static IList<int> InorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        if (root == null) return list;
        // Recursively traverse left tree
        if (root.left != null) {
            IList<int> leftList = InorderTraversal(root.left);
            foreach (int i in leftList) {
                list.Add(i);
            }
        }
        // Add Root
        list.Add(root.val);
        // Recursively traverse right tree
        if (root.right != null) {
            IList<int> rightList = InorderTraversal(root.right);
            foreach (int i in rightList) {
                list.Add(i);
            }
        }
        return (IList<int>) list;
    }
    // ------------------------------------------------------------------------------------
    // Leetcode Question: Binary Tree Postorder Traversal
    // 
    // Given the root of a binary tree, return the postorder traversal of its nodes' values.
    // Left, Right, Root
    //
    // Input: root = [1,null,2,3]
    // Output: [3,2,1]
    //
    // https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/930/
    // ------------------------------------------------------------------------------------
    static IList<int> PostorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        if (root == null) return list;
        // Recursively traverse left tree
        if (root.left != null) {
            IList<int> leftList = PostorderTraversal(root.left);
            foreach (int i in leftList) {
                list.Add(i);
            }
        }
        // Recursively traverse right tree
        if (root.right != null) {
            IList<int> rightList = PostorderTraversal(root.right);
            foreach (int i in rightList) {
                list.Add(i);
            }
        }
        // Add Root
        list.Add(root.val);
        return (IList<int>) list;
    }

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Maximum Depth of Binary Tree
    // 
    // Given the root of a binary tree, return its maximum depth.
    // A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    //
    // Input: root = [3,9,20,null,null,15,7]
    // Output: 3
    //
    // https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/535/
    // ------------------------------------------------------------------------------------
    static int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0;                                   // return 0 for null node
        }
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        return Math.Max(leftDepth, rightDepth) + 1;   // return depth of the subtree rooted at root
    }

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Maximum Depth of Binary Tree
    // 
    // Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
    //
    // Input: root = [1,2,2,3,4,4,3]
    // Output: true
    //
    // https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/536/
    // ------------------------------------------------------------------------------------
    static bool IsSymmetric(TreeNode root) {
        // ----- Pseudo-code -----
        // Iteratively traverse tree to build up a list of lists for each level
        // For each list, check if the first value equals the last value, and iteratively step inwards
        // Return false if there is a mis-match, if everything passes, return true at the end.
        return false;
    }

}