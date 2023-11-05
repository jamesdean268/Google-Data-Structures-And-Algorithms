class Program
{

    class MyQueue {
        // store elements
        private List<int> data;         
        // a pointer to indicate the start position
        private int p_start;            
        public MyQueue() {
            data = new List<int>();
            p_start = 0;
        }
        /** Insert an element into the queue. Return true if the operation is successful. */
        public bool enQueue(int x) {
            data.Add(x);
            return true;
        }
        /** Delete an element from the queue. Return true if the operation is successful. */
        public bool deQueue() {
            if (isEmpty() == true) {
                return false;
            }
            p_start++;
            return true;
        }
        /** Get the front item from the queue. */
        public int Front() {
            return data[p_start];
        }
        /** Checks whether the queue is empty or not. */
        public bool isEmpty() {
            return p_start >= data.Count;
        }     
    };

    static void Main(string[] args)
    {
        // ------------------ Custom Queue implementation ------------
        MyQueue q = new MyQueue();
        q.enQueue(5);
        q.enQueue(3);
        if (q.isEmpty() == false) {
            Console.WriteLine(q.Front());
        }
        q.deQueue();
        if (q.isEmpty() == false) {
            Console.WriteLine(q.Front());
        }
        q.deQueue();
        if (q.isEmpty() == false) {
            Console.WriteLine(q.Front());
        }

        // ------------------- In-built queue implementation ------------

        // Create a new queue.
        Queue<string> queue = new Queue<string>();

        // Add some items to the queue.
        queue.Enqueue("Item 1");
        queue.Enqueue("Item 2");
        queue.Enqueue("Item 3");

        // Print the items in the queue.
        foreach (string itemInQueue in queue)
        {
            Console.WriteLine(itemInQueue);
        }

        // Remove the first item from the queue.
        string item = queue.Dequeue();

        // Print the item that was removed.
        Console.WriteLine("The item that was removed is: " + item);

        // Check if the queue is empty.
        if (queue.Count == 0)
        {
            Console.WriteLine("The queue is empty.");
        }
        else
        {
            Console.WriteLine("The queue is not empty.");
        }

        // ------------------- In-built Stack implementation ------------
        // 1. Initialize a stack.
        Stack<int> s = new Stack<int>();
        // 2. Push new element.
        s.Push(5);
        s.Push(13);
        s.Push(8);
        s.Push(6);
        // 3. Check if stack is empty.
        if (s.Count == 0) {
            Console.WriteLine("Stack is empty!");
            return;
        }
        // 4. Pop an element.
        s.Pop();
        // 5. Get the top element.
        Console.WriteLine("The top element is: " + s.Peek());
        // 6. Get the size of the stack.
        Console.WriteLine("The size is: " + s.Count);


        {
            // ----------------------------- Number of Islands Test --------------------------
            char[] row1 = {'1','1','0','0','0'};
            char[] row2 = {'1','1','0','0','0'};
            char[] row3 = {'0','0','1','0','0'};
            char[] row4 = {'0','0','0','1','1'};
            char[][] grid = {row1, row2, row3, row4};
            Console.WriteLine("The number of islands in the grid is: " + NumIslands(grid));
        }

    }

    // ------------------------------------------------------------------------------------
    // Leetcode Question: Number of Islands
    // 
    // Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
    // An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.
    //
    // Input: grid = [
    //   ["1","1","0","0","0"],
    //   ["1","1","0","0","0"],
    //   ["0","0","1","0","0"],
    //   ["0","0","0","1","1"]
    // ]
    // Output: 3
    //
    // https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1374/

    static int NumIslands(char[][] grid) {
        return 1;
    }
}
