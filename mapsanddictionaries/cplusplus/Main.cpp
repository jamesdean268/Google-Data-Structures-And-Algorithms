#include <iostream>
#include <unordered_set>                // 0. include the library
using namespace std;

// ------------------------------------------------------------------------------------
// Example function to find duplicates using HashSet
// ------------------------------------------------------------------------------------
bool findDuplicates(vector<int>& keys) {
    unordered_set<int> hashset;
    for (int key : keys) {
        if (hashset.count(key) > 0) {
            return true;
        }
        hashset.insert(key);
    }
    return false;
}

int main() {
    // ------------------------------------------------------------------------------------
    // HashSet Usage on LeetCode
    // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1130/
    // ------------------------------------------------------------------------------------
    // 1. initialize a hash set
    unordered_set<int> hashset;   
    // 2. insert a new key
    hashset.insert(3);
    hashset.insert(2);
    hashset.insert(1);
    // 3. delete a key
    hashset.erase(2);
    // 4. check if the key is in the hash set
    if (hashset.count(2) <= 0) {
        cout << "Key 2 is not in the hash set." << endl;
    }
    // 5. get the size of the hash set
    cout << "The size of hash set is: " << hashset.size() << endl; 
    // 6. iterate the hash set
    for (auto it = hashset.begin(); it != hashset.end(); ++it) {
        cout << (*it) << " ";
    }
    cout << "are in the hash set." << endl;
    // 7. clear the hash set
    hashset.clear();
    // 8. check if the hash set is empty
    if (hashset.empty()) {
        cout << "hash set is empty now!" << endl;
    }

    {
        // ------------------------------------ Duplicate Function Test ---------------------------
        vector<int> keysWithDuplicates = {1, 2, 3, 3, 4};
        vector<int> keysWithoutDuplicates = {1, 2, 3, 4};
        cout << "Should return true to identify a duplicate: " << findDuplicates(keysWithDuplicates) << endl;
        cout << "Should return false to identify no duplicates: " << findDuplicates(keysWithoutDuplicates) << endl;
        // ----------------------------------------------------------------------------------------
    }

}

