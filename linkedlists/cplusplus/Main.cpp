#include <iostream>
#include <list>
using namespace std;

// Definition for singly-linked list.
struct SinglyListNode {
    int val;
    SinglyListNode *next;
    SinglyListNode(int x) : val(x), next(NULL) {}
};

int main()
{
    // Create a new linked list.
    list<int> linked_list;

    // Add some elements to the linked list.
    linked_list.push_back(1);
    linked_list.push_back(2);
    linked_list.push_back(3);

    // Print the elements of the linked list.
    for (int element : linked_list) {
    cout << element << " ";
    }
    cout << endl;

    // Remove the first element from the linked list.
    linked_list.pop_front();

    // Print the elements of the linked list again.
    for (int element : linked_list) {
    cout << element << " ";
    }
    cout << endl;
}