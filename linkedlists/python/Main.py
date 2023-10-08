# Definition for singly-linked list.
class SinglyLinkedListNode:
    def __init__(self, value):
        self.value = value
        self.next = None

class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:
    def __init__(self):
        self.head = None

    def append(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
        else:
            current = self.head
            while current.next is not None:
                current = current.next
            current.next = new_node

    def print_list(self):
        current = self.head
        while current is not None:
            print(current.data)
            current = current.next

class Main:
    def Main():
        # ---- Custome LinkedList Class
        # Create a new linked list.
        linked_list = LinkedList()

        # Create a new Linked List
        llist = LinkedList()

        # Append some data to the Linked List
        llist.append(1)
        llist.append(2)
        llist.append(3)
        llist.append(4)

        # Print the Linked List
        llist.print_list()

        # ----- In-Built Functionality -----
        from collections import deque
        # Create a new deque
        queue = deque()

        # Append some data to the deque
        queue.append(1)
        queue.append(2)
        queue.append(3)

        # Print the deque
        print(queue)

        # Popleft the data from the deque
        popped_data = queue.popleft()

        # Print the popped data
        print(popped_data)

if __name__ == '__main__':
    Main.Main()
