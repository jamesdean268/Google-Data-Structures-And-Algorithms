package linkedlists.java;

import java.util.LinkedList;

public class Main {
    public static void main(String[] args) throws Exception {
        // --------------------------------------------------------------------------------
        // Example LinkedList usage in C#
        // -------------------------------------------------------------------------------- 
        // Create a new linked list.
        LinkedList<Integer> linkedList = new LinkedList<>();

        // Add some elements to the linked list.
        linkedList.add(1);
        linkedList.add(2);
        linkedList.add(3);

        // Print the elements of the linked list.
        for (Integer element : linkedList) {
            System.out.println(element);
        }

        // Remove the first element from the linked list.
        linkedList.removeFirst();

        // Print the elements of the linked list again.
        for (Integer element : linkedList) {
            System.out.println(element);
        }

        // Insert a new element at the beginning of the linked list.
        linkedList.addFirst(0);

        // Remove the element at the end of the linked list.
        linkedList.removeLast();

        // Copy the linked list to a new linked list.
        LinkedList<Integer> newLinkedList = new LinkedList<>(linkedList);

        // Print the elements of the new linked list.
        for (Integer element : newLinkedList) {
        System.out.println(element);
        }


    }

    // Definition for singly-linked list.
    public class SinglyListNode {
        int val;
        SinglyListNode next;
        SinglyListNode(int x) { val = x; }
    }

}
