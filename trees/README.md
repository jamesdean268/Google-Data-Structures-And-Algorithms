# Trees
Trees in computer science are like trees in the real world, the only difference is that in computer science it is visualized as upside-down with root on the top and branches originating from the root to the leaves of the tree. A Tree Data Structure is used for various real-world applications as it can show relation among various nodes using the parent-child hierarchy. Due to this it is also known as hierarchical data structure. It is widely used to simplify and fasten searching and sorting operations. It is considered to be one of the most powerful and advanced data structures.

Tree is a non-linear data structure. A tree can be represented using various primitive or user defined data types. To implement tree, we can make use of arrays, linked lists, classes or other types of data structures. It is a collection of nodes that are related with each other. 

Types of trees: https://www.thecrazyprogrammer.com/2019/09/types-of-trees-in-data-structure.html

Good overview of trees: https://www.youtube.com/watch?v=oSWTXtMglKE

## Binary Tree Introduction

A tree is a frequently-used data structure to simulate a hierarchical tree structure.

Each node of the tree will have a root value and a list of references to other nodes which are called child nodes. From graph view, a tree can also be defined as a directed acyclic graph which has N nodes and N-1 edges.

A Binary Tree is one of the most typical tree structure. As the name suggests, a binary tree is a tree data structure in which each node has at most two children, which are referred to as the left child and the right child.

## Traverse a Tree

### Pre-order Traversal
Pre-order traversal is to visit the root first. Then traverse the left subtree. Finally, traverse the right subtree. 

### In-order Traversal
In-order traversal is to traverse the left subtree first. Then visit the root. Finally, traverse the right subtree.

### Post-order Traversal
Post-order traversal is to traverse the left subtree first. Then traverse the right subtree. Finally, visit the root.

It is worth noting that when you delete nodes in a tree, deletion process will be in post-order. That is to say, when you delete a node, you will delete its left child and its right child before you delete the node itself.

Also, post-order is widely used in mathematical expressions. It is easier to write a program to parse a post-order expression.

