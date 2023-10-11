# Linked Lists
Similar to the array, the linked list is also a linear data structure.
Each element in the linked list is actually a separate object while all the objects are linked together by the reference field in each element.
There are two types of linked list: singly linked list and doubly linked list. 

## Singly Linked List
Each node in a singly-linked list contains not only the value but also a reference field to link to the next node. By this way, the singly-linked list organizes all the nodes in a sequence.
In most cases, we will use the head node (the first node) to represent the whole list.

Unlike the array, we are not able to access a random element in a singly-linked list in constant time. If we want to get the ith element, we have to traverse from the head node one by one. It takes us O(N) time on average to visit an element by index, where N is the length of the linked list.

You might wonder why the linked list is useful though it has such a bad performance (compared to the array) in accessing data by index. Refer examples for the insert and delete operations that describe the benefit of the linked list.

## Doubly Linked List
The doubly linked list works in a similar way but has one more reference field which is known as the "prev" field. With this extra field, you are able to know the previous node of the current node.

# Comparison

Singly and Doubly linked lists are similar in many operations:

Both of them are not able to access the data at a random position in constant time.
Both of them can add a new node after given node or at the beginning of the list in O(1) time.
Both of them can delete the first node in O(1) time.
But it is a little different to delete a given node (including the last node).

In a singly linked list, it is not able to get the previous node of a given node so we have to spend O(N) time to find out the previous node before deleting the given node.
In a doubly-linked list, it will be much easier because we can get the previous node with the "prev" reference field. So we can delete a given node in O(1) time.

## Comparison with Arrays
If you need to add or delete a node frequently, a linked list could be a good choice.
If you need to access an element by index often, an array might be a better choice than a linked list.
