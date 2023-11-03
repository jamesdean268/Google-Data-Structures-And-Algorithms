package stacksandqueues.java;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

class MyQueue {
    // store elements
    private List<Integer> data;         
    // a pointer to indicate the start position
    private int p_start;            
    public MyQueue() {
        data = new ArrayList<Integer>();
        p_start = 0;
    }
    /** Insert an element into the queue. Return true if the operation is successful. */
    public boolean enQueue(int x) {
        data.add(x);
        return true;
    };    
    /** Delete an element from the queue. Return true if the operation is successful. */
    public boolean deQueue() {
        if (isEmpty() == true) {
            return false;
        }
        p_start++;
        return true;
    }
    /** Get the front item from the queue. */
    public int Front() {
        return data.get(p_start);
    }
    /** Checks whether the queue is empty or not. */
    public boolean isEmpty() {
        return p_start >= data.size();
    }     
};

public class Main {

    // ------------ Custom Queue ----------------
    public static void main(String[] args) {
        MyQueue q = new MyQueue();
        q.enQueue(5);
        q.enQueue(3);
        if (q.isEmpty() == false) {
            System.out.println(q.Front());
        }
        q.deQueue();
        if (q.isEmpty() == false) {
            System.out.println(q.Front());
        }
        q.deQueue();
        if (q.isEmpty() == false) {
            System.out.println(q.Front());
        }

        // ------------- In-Built Queue ------------
        // 1. Initialize a queue.
        Queue<Integer> stdQ = new LinkedList();
        // 2. Get the first element - return null if queue is empty.
        System.out.println("The first element is: " + stdQ.peek());
        // 3. Push new element.
        stdQ.offer(5);
        stdQ.offer(13);
        stdQ.offer(8);
        stdQ.offer(6);
        // 4. Pop an element.
        stdQ.poll();
        // 5. Get the first element.
        System.out.println("The first element is: " + stdQ.peek());
        // 7. Get the size of the queue.
        System.out.println("The size is: " + stdQ.size());
    }

}
