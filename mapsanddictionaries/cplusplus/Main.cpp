#include <iostream>
#include <unordered_set>                // 0. include the library
#include <unordered_map>                // 0. include the library
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




// ------------------------------------------------------------------------------------
// Leetcode question: 
// Write an algorithm to determine if a number n is happy.
// A happy number is a number defined by the following process:
// Starting with any positive integer, replace the number by the sum of the squares of its digits.
// Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
// Those numbers for which this process ends in 1 are happy.
// Return true if n is a happy number, and false if not.
//
// Input: n = 19
// Output: true
//
// https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1131/
// ------------------------------------------------------------------------------------
bool isHappy(int n) {
    return true;
    // check if 1 already, if so, return true
    // if (n == 1) return true;

    // // Convert to a string
    // string strN = n.ToString();

    // // Create empty hashSet
    // HashSet<int> hashSet = new HashSet<int>();

    // // Loop until convergence or an endless cycle
    // while(true){
    //     // Split the int into its components, square, and add
    //     int squareSum = 0;
    //     foreach (char digit in strN){
    //         int intDigit = Convert.ToInt32(digit.ToString());
    //         squareSum += intDigit * intDigit;
    //     }

    //     // Check for convergence for one
    //     if (squareSum == 1) return true;          

    //     // Check for endless loop (i.e. if hashset contains a number, we have looped)
    //     if (hashSet.Contains(squareSum)) return false;

    //     // If it is a new number and not one, add it to the hashset, and set it as the new StrN
    //     hashSet.Add(squareSum);
    //     strN = squareSum.ToString();
    //}
}

// ------------------------------------------------------------------------------------
// Leetcode question: 
// Given two arrays of strings list1 and list2, find the common strings with the least index sum.
// A common string is a string that appeared in both list1 and list2.
// A common string with the least index sum is a common string such that if it appeared at list1[i] and list2[j] then i + j should be the minimum value among all the other common strings.
// Return all the common strings with the least index sum. Return the answer in any order.
//
// Input: list1 = ["happy","sad","good"], list2 = ["sad","happy","good"]
// Output: ["sad","happy"]
//
// https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1177/
// ------------------------------------------------------------------------------------
vector<string> findRestaurant(vector<string>& list1, vector<string>& list2) {
    
    //Dictionary<string, int> list1Dict = list1.ToDictionary(listItem => listItem, listItem => Array.IndexOf(list1, listItem));
    //Dictionary<string, int> list2Dict = list2.ToDictionary(listItem => listItem, listItem => Array.IndexOf(list2, listItem));
    
    unordered_map<string, int> list1Dict;
    unordered_map<string, int> list2Dict;
    for (int i = 0; i < list1.size(); i++){
        list1Dict.insert(make_pair(list1[i], i));
    }
    for (int i = 0; i < list2.size(); i++){
        list2Dict.insert(make_pair(list2[i], i));
    }

    // Intersect the two dictionaries by key and sum the values.
    //Dictionary<string, int> listIntersection = new Dictionary<string, int>();
    unordered_map<string, int> listIntersection;


    // foreach (string key in list1Dict.Keys)
    // {
    //     if (list2Dict.ContainsKey(key))
    //     {
    //         listIntersection.Add(key, list1Dict[key] + list2Dict[key]);
    //     }
    // }
    for (const auto& pairEntry : list1Dict) {
        unordered_map<string, int>::iterator it = list2Dict.find(pairEntry.first);
        if (it != list2Dict.end()) {
            // The key is in the map, so add up the indices
            listIntersection.insert(make_pair(pairEntry.first, list1Dict[pairEntry.first] + list2Dict[pairEntry.first]));
        }
    }

    // Get the minimum of the indices
    // int minValue = listIntersection.Values.Min();
    
    // Get the minimum value in the map
    int minValue = 2147483647; // Max integer value

    // Iterate over the values in the unordered_map and keep track of the smallest value.
    for (const auto& pairEntry : listIntersection) {
        if (pairEntry.second < minValue) {
            minValue = pairEntry.second;
        }
    }

    // // Output the string array
    // List<string> outString = new List<string>();
    // foreach (KeyValuePair<string, int> item in listIntersection){
    //     if (item.Value == minValue){
    //         outString.Add(item.Key);
    //     }
    // }
    // return outString.ToArray();
    vector<string> outVector;
    for (const auto& pairEntry : listIntersection) {
        if (pairEntry.second == minValue) {
            outVector.push_back(pairEntry.first);
        }
    }    
    return outVector;

}

int main() {

    {
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
        // ------------------------------------------------------------------------------------

        // ------------------------------------------------------------------------------------
        // HashMap Usage on LeetCode
        // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1129/
        // ------------------------------------------------------------------------------------
        // 1. initialize a hash map
        unordered_map<int, int> hashmap;
        // 2. insert a new (key, value) pair
        hashmap.insert(make_pair(0, 0));
        hashmap.insert(make_pair(2, 3));
        // 3. insert a new (key, value) pair or update the value of existed key
        hashmap[1] = 1;
        hashmap[1] = 2;
        // 4. get the value of a specific key
        cout << "The value of key 1 is: " << hashmap[1] << endl;
        // 5. delete a key
        hashmap.erase(2);
        // 6. check if a key is in the hash map
        if (hashmap.count(2) <= 0) {
            cout << "Key 2 is not in the hash map." << endl;
        }
        // 7. get the size of the hash map
        cout << "the size of hash map is: " << hashmap.size() << endl; 
        // 8. iterate the hash map
        for (auto it = hashmap.begin(); it != hashmap.end(); ++it) {
            cout << "(" << it->first << "," << it->second << ") ";
        }
        cout << "are in the hash map." << endl;
        // 9. clear the hash map
        hashmap.clear();
        // 10. check if the hash map is empty
        if (hashmap.empty()) {
            cout << "hash map is empty now!" << endl;
        }
    }

    // ------------------------------------------------------------------------------------

    {
        // ------------------------------------ Duplicate Function Test ---------------------------
        vector<int> keysWithDuplicates = {1, 2, 3, 3, 4};
        vector<int> keysWithoutDuplicates = {1, 2, 3, 4};
        cout << "Should return true to identify a duplicate: " << findDuplicates(keysWithDuplicates) << endl;
        cout << "Should return false to identify no duplicates: " << findDuplicates(keysWithoutDuplicates) << endl;
        // ----------------------------------------------------------------------------------------
    }

    {
        // ------------------------------------ isHappy Function Test ---------------------------
        int n = 19;
        cout << "The integer: " << n << " is happy?: " << isHappy(n) << endl;
        // ----------------------------------------------------------------------------------------
    }

    {
        // ------------------------------------ findRestaurant Function Test ---------------------------
        vector<string> list1 = {"happy","sad","good", "bad"};
        vector<string> list2 = {"sad","happy","good"};
        vector<string> restaurants = findRestaurant(list1, list2);
        for (int i = 0; i < restaurants.size(); i++){
            cout << restaurants[i] << ", ";
        }
        cout << endl;
        // ----------------------------------------------------------------------------------------
    }

}

