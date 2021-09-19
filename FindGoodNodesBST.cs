/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int numGoodNodes = 0;
    public int GoodNodes(TreeNode root) {
        
        dfs(root, Int32.MinValue);
        return numGoodNodes;
    }
    
    private void dfs(TreeNode node, int maxSoFar) {
        if (maxSoFar <= node.val) {
            numGoodNodes++;
        }
        
        if (node.right != null) {
            dfs(node.right, Math.Max(node.val, maxSoFar));
        }

        if (node.left != null) {
            dfs(node.left, Math.Max(node.val, maxSoFar));
        }
    }
}