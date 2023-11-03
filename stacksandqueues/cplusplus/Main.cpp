#include <iostream>
#include <vector>
#include <queue>

using namespace std;
// -------------------------------------------
// Queue Implementation
// -------------------------------------------
class MyQueue {
    private:
        // store elements
        vector<int> data;       
        // a pointer to indicate the start position
        int p_start;            
    public:
        MyQueue() {p_start = 0;}
        /** Insert an element into the queue. Return true if the operation is successful. */
        bool enQueue(int x) {
            data.push_back(x);
            return true;
        }
        /** Delete an element from the queue. Return true if the operation is successful. */
        bool deQueue() {
            if (isEmpty()) {
                return false;
            }
            p_start++;
            return true;
        };
        /** Get the front item from the queue. */
        int Front() {
            return data[p_start];
        };
        /** Checks whether the queue is empty or not. */
        bool isEmpty()  {
            return p_start >= data.size();
        }
};

int main() {
    // ------------------------ Custom Queue ------------------
    MyQueue q;
    q.enQueue(5);
    q.enQueue(3);
    if (!q.isEmpty()) {
        cout << q.Front() << endl;
    }
    q.deQueue();
    if (!q.isEmpty()) {
        cout << q.Front() << endl;
    }
    q.deQueue();
    if (!q.isEmpty()) {
        cout << q.Front() << endl;
    }

    // --------------------- In-Built Queue --------------------
    // 1. Initialize a queue.
    queue<int> stdQ;
    // 2. Push new element.
    stdQ.push(5);
    stdQ.push(13);
    stdQ.push(8);
    stdQ.push(6);
    // 3. Check if queue is empty.
    if (stdQ.empty()) {
        cout << "Queue is empty!" << endl;
        return 0;
    }
    // 4. Pop an element.
    stdQ.pop();
    // 5. Get the first element.
    cout << "The first element is: " << stdQ.front() << endl;
    // 6. Get the last element.
    cout << "The last element is: " << stdQ.back() << endl;
    // 7. Get the size of the queue.
    cout << "The size is: " << stdQ.size() << endl;

}

