using System.Runtime.InteropServices;

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


        {
            // ------------------------------------ HasCycle Function Test -----------------------
            ListNode head = new ListNode(3);
            head.next = new ListNode(2);
            head.next.next = new ListNode(0);
            head.next.next.next = new ListNode(-4);
            head.next.next.next.next = head.next;
            Console.WriteLine(HasCycle(head));
        }

        {
            // ------------------------------------ DetectCycle Function Test -----------------------
            ListNode head = new ListNode(3);
            head.next = new ListNode(2);
            head.next.next = new ListNode(0);
            head.next.next.next = new ListNode(-4);
            head.next.next.next.next = head.next;
            Console.WriteLine(DetectCycle(head).val);
        }


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

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Linked List Cycle. 
    // 
    // Given head, the head of a linked list, determine if the linked list has a cycle in it.
    // There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. 
    // Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
    // Return true if there is a cycle in the linked list. Otherwise, return false.
    //
    // Input: head = [3,2,0,-4], pos = 1
    // Output: true
    // Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
    //
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) {
    *         val = x;
    *         next = null;
    *     }
    * }
    */
    //
    // https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1212/
    // ------------------------------------------------------------------------------------

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
            next = null;
        }
    }

    static bool HasCycle(ListNode head) {
        // Return false if head is null
        if (head == null) {
            return false;
        }
        // Use a fast runner and a slow runner, and see if they end up with the same object at any point
        ListNode fastRunner = head;
        ListNode slowRunner = head;
        while(true){
            // If the fast runner reaches a null for the next object, then return false.
            fastRunner = fastRunner.next;
            if (fastRunner == null){
                return false;
            }
            // Increment fastRunner again so that it keeps doing two jumps
            fastRunner = fastRunner.next;
            if (fastRunner == null){
                return false;
            }
            // Increment the slow runner
            slowRunner = slowRunner.next;

            // If the slow runner equals the fast runner, we have a loop
            if (fastRunner.Equals(slowRunner)){
                return true;
            }
        }
        
    }

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Linked List Cycle II. 
    // 
    // Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.
    //
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) {
    *         val = x;
    *         next = null;
    *     }
    * }
    */
    //
    // https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1214/
    // ------------------------------------------------------------------------------------
    static ListNode DetectCycle(ListNode head) {
        HashSet<ListNode> cycleNodes = new HashSet<ListNode>();
        // Return false if head is null
        if (head == null) {
            return null;
        }
        // Use a fast runner and a slow runner, and see if they end up with the same object at any point
        ListNode fastRunner = head;
        ListNode slowRunner = head;
        cycleNodes.Add(slowRunner);
        while(true){
            // If the fast runner reaches a null for the next object, then return false.
            fastRunner = fastRunner.next;
            if (fastRunner == null){
                return null;
            }
            // Increment fastRunner again so that it keeps doing two jumps
            fastRunner = fastRunner.next;
            if (fastRunner == null){
                return null;
            }
            // Increment the slow runner
            slowRunner = slowRunner.next;
            if (cycleNodes.Contains(slowRunner)){
                return slowRunner;
            }
            cycleNodes.Add(slowRunner);

        }

    }

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Linked List Cycle II. 
    // 
    // Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. 
    // If the two linked lists have no intersection at all, return null.
    //
    // https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1215/
    // ------------------------------------------------------------------------------------
    static ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> intersectionListA = new HashSet<ListNode>();
        ListNode iteratorA = headA;
        ListNode iteratorB = headB;
        while (iteratorA != null) {
            intersectionListA.Add(iteratorA);
            iteratorA = iteratorA.next;
        }
        while (iteratorB != null) {
            if (intersectionListA.Contains(iteratorB)){
                return iteratorB;
            }
            iteratorB = iteratorB.next;
        }
        return null;

    }
}