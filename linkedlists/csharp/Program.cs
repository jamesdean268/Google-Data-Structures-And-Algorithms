class Program
{
    static void Main(string[] args)
    {
        // --------------------------------------------------------------------------------
        // Example LinkedList usage in C#
        // --------------------------------------------------------------------------------
        // Create a new linked list.
        LinkedList<int> linkedList = new LinkedList<int>();

        // Add some elements to the linked list.
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        // Print the elements of the linked list.
        foreach (int element in linkedList)
        {
            Console.WriteLine(element);
        }

        // Remove the first element from the linked list.
        linkedList.RemoveFirst();

        // Print the elements of the linked list again.
        foreach (int element in linkedList)
        {
            Console.WriteLine(element);
        }

        // Insert a new element at the beginning of the linked list.
        linkedList.AddFirst(0);

        // Remove the element at the end of the linked list.
        linkedList.RemoveLast();

        // Find the first occurrence of the element 2 in the linked list.
        LinkedListNode<int> node = linkedList.Find(2);

        // Reverse the order of the linked list.
        linkedList.Reverse();

        // Copy the linked list to a new linked list.
        LinkedList<int> newLinkedList = new LinkedList<int>(linkedList);

        // Print the elements of the new linked list.
        foreach (int element in newLinkedList)
        {
            Console.WriteLine(element);
        }


        // --------------------------------------------------------------------------------
        // Execution of MyLinkedList example
        // --------------------------------------------------------------------------------
        MyLinkedList myLinkedList = new MyLinkedList();
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
        Console.WriteLine(myLinkedList.Get(1));              // return 2
        myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
        Console.WriteLine(myLinkedList.Get(1));              // return 3

        // --------------------------------------------------------------------------------
        // Execution of MyLinkedList example
        // --------------------------------------------------------------------------------
        MyLinkedList linkedListTheSecond = new MyLinkedList();
        linkedListTheSecond.AddAtHead(7);
        linkedListTheSecond.AddAtHead(2);
        linkedListTheSecond.AddAtHead(1);
        linkedListTheSecond.AddAtIndex(3,0);
        linkedListTheSecond.DeleteAtIndex(2);
        linkedListTheSecond.AddAtHead(6);
        linkedListTheSecond.AddAtTail(4);
        Console.WriteLine(linkedListTheSecond.Get(4));
        linkedListTheSecond.AddAtHead(4);
        linkedListTheSecond.AddAtIndex(5,0);
        linkedListTheSecond.AddAtHead(6);

    }

    // Definition for singly-linked list.
    public class SinglyListNode {
        int val;
        SinglyListNode? next;
        SinglyListNode(int x) { val = x; next = null;}
    }

    // ------------------------------------------------------------------------------------
    // Leetcode Action: Design Linked List. 
    // 
    // Implement the MyLinkedList class:
    // MyLinkedList() Initializes the MyLinkedList object.
    // int get(int index) Get the value of the indexth node in the linked list. If the index is invalid, return -1.
    // void addAtHead(int val) Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
    // void addAtTail(int val) Append a node of value val as the last element of the linked list.
    // void addAtIndex(int index, int val) Add a node of value val before the indexth node in the linked list. If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, the node will not be inserted.
    // void deleteAtIndex(int index) Delete the indexth node in the linked list, if the index is valid.
    //
    // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1105/
    // ------------------------------------------------------------------------------------

    public class MyLinkedList {

        private Node? head;
        private int size;

        public MyLinkedList() {
            this.head = null;
            this.size = 0;
        }

        private class Node {
            public int val;
            public Node? next;

            public Node(int val) {
                this.val = val;
                this.next = null;
            }
        }

        public int Get(int index) {
            if (index < 0 || index >= size) {
                return -1;
            }

            Node curr = head;
            for (int i = 0; i < index; i++) {
                curr = curr.next;
            }

            return curr.val;
        }

        public void AddAtHead(int val) {
            Node newNode = new Node(val);
            newNode.next = head;
            head = newNode;
            size++;
        }

        public void AddAtTail(int val) {
            Node newNode = new Node(val);
            if (head == null) {
                head = newNode;
            } else {
                Node curr = head;
                while (curr.next != null) {
                    curr = curr.next;
                }
                curr.next = newNode;
            }
            size++;
        }

        public void AddAtIndex(int index, int val) {
            if (index < 0 || index > size) {
                return;
            }

            if (index == 0) {
                AddAtHead(val);
            } else {
                Node newNode = new Node(val);
                Node curr = head;
                for (int i = 0; i < index - 1; i++) {
                    curr = curr.next;
                }
                newNode.next = curr.next;
                curr.next = newNode;
                size++;
            }
        }

        public void DeleteAtIndex(int index) {
            if (index < 0 || index >= size) {
                return;
            }

            if (index == 0) {
                head = head.next;
            } else {
                Node curr = head;
                for (int i = 0; i < index - 1; i++) {
                    curr = curr.next;
                }
                curr.next = curr.next.next;
            }
            size--;
        }


    }

}