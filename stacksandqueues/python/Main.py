
class Main:
    def Main():
        import queue
        # --------------- In-built implementation -------------
        queue = queue.Queue()

        # Add elements to the queue.
        queue.put(1)
        queue.put(2)
        queue.put(3)

        # Remove elements from the queue.
        element = queue.get()
        print(element)

        element = queue.get()
        print(element)

        element = queue.get()
        print(element)

# ---------------- Custom implementation ----------------
class Queue:
    def __init__(self):
        self.items = []

    def enqueue(self, item):
        self.items.append(item)

    def dequeue(self):
        if self.is_empty():
            raise IndexError("Queue is empty")
        return self.items.pop(0)

    def is_empty(self):
        return len(self.items) == 0

if __name__ == '__main__':
    Main.Main()
