#include <iostream>

using namespace std;

// Definition for a binary tree node.
struct TreeNode {
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode() : val(0), left(nullptr), right(nullptr) {}
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
    TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
};

// ------------------------------------------------------------------------------------
// Leetcode Question: Path Sum C++
// 
// Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.
//
// Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
// Output: true
//
// https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/537/
// ------------------------------------------------------------------------------------

// function to check if the given tree has a path
// that sums up to the given target sum
bool hasPathSum(TreeNode* root, int targetSum) {
    // base case
    if (root == nullptr) {
        return false;
    }

    // if the current node is a leaf node and
    // its value is equal to the target sum
    if (root->left == nullptr && root->right == nullptr && root->val == targetSum) {
        return true;
    }
    
    // recursively check the left and right subtrees
    return hasPathSum(root->left, targetSum - root->val) ||  hasPathSum(root->right, targetSum - root->val);
}

// Driver code
int main() {
    // create a tree
    TreeNode* root = new TreeNode(5);
    root->left = new TreeNode(4);
    root->right = new TreeNode(8);
    root->left->left = new TreeNode(11);
    root->right->left = new TreeNode(13);
    root->right->right = new TreeNode(4);
    root->left->left->left = new TreeNode(7);
    root->left->left->right = new TreeNode(2);
    root->right->right->right = new TreeNode(1);

    // target sum
    int targetSum = 22;

    // check if the tree has a path that sums up to
    // the given target sum
    if (hasPathSum(root, targetSum))
        cout << "Yes";
    else
        cout << "No";

    return 0;
}


