# Stacks & Queues
## Introduction
We may access a random element by index in Array. However, we might want to restrict the processing order in some cases.
Two different processing orders can be used, First-in-First-out and Last-in-First-out and its two corresponding linear data structures, Queue and Stack.

## Queue
In a FIFO data structure, the first element added to the queue will be processed first.
The insert operation is also called enqueue and the new element is always added at the end of the queue. The delete operation is called dequeue. You are only allowed to remove the first element.

### Usage
One common application of Breadth-first Search (BFS) is to find the shortest path from the root node to the target node. In this article, we provide an example to explain how queue is applied in a BFS algorithm step by step.

## Stack
In a LIFO data structure, the newest element added to the queue will be processed first.

Different from the queue, the stack is a LIFO data structure. Typically, the insert operation is called push in a stack. Similar to the queue, a new element is always added at the end of the stack. However, the delete operation, pop, will always remove the last element which is opposite from the queue.

### Usage
Most popular languages provide built-in stack library so you don't have to reinvent the wheel. Besides initialization, we need to know how to use the two most important operations, pop and push. Also, you should be able to get the top element from the stack.

