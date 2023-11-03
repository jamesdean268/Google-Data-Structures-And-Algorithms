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

        // ------------------- In-built queue implementation ------------=
        // Provide an example usage for the in-built Queue functionality

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

    }
}