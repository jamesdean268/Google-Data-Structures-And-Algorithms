# Linked Lists
Similar to the array, the linked list is also a linear data structure.
Each element in the linked list is actually a separate object while all the objects are linked together by the reference field in each element.
There are two types of linked list: singly linked list and doubly linked list. 

## Singly Linked List
Each node in a singly-linked list contains not only the value but also a reference field to link to the next node. By this way, the singly-linked list organizes all the nodes in a sequence.
In most cases, we will use the head node (the first node) to represent the whole list.

Unlike the array, we are not able to access a random element in a singly-linked list in constant time. If we want to get the ith element, we have to traverse from the head node one by one. It takes us O(N) time on average to visit an element by index, where N is the length of the linked list.

You might wonder why the linked list is useful though it has such a bad performance (compared to the array) in accessing data by index. Refer examples for the insert and delete operations that describe the benefit of the linked list.

### Add / Insert Operation
Unlike an array, we don’t need to move all elements past the inserted element. Therefore, you can insert a new node into a linked list in O(1) time complexity if you have a reference to prev, which is very efficient.

### Delete Operation
The space complexity is O(1) because we only need constant space to store our pointers.

