package mapsanddictionaries.java;

import java.util.HashSet;
import java.util.List;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Set;

public class Main {
    public static void main(String[] args) throws Exception {

        // ------------------------------------------------------------------------------------
        // HashSet Usage on LeetCode
        // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1130/
        // ------------------------------------------------------------------------------------
        // 1. initialize the hash set
        Set<Integer> hashSet = new HashSet<>();     
        // 2. add a new key
        hashSet.add(3);
        hashSet.add(2);
        hashSet.add(1);
        // 3. remove the key
        hashSet.remove(2);        
        // 4. check if the key is in the hash set
        if (!hashSet.contains(2)) {
            System.out.println("Key 2 is not in the hash set.");
        }
        // 5. get the size of the hash set
        System.out.println("The size of has set is: " + hashSet.size());     
        // 6. iterate the hash set
        for (Integer i : hashSet) {
            System.out.print(i + " ");
        }
        System.out.println("are in the hash set.");
        // 7. clear the hash set
        hashSet.clear();
        // 8. check if the hash set is empty
        if (hashSet.isEmpty()) {
            System.out.println("hash set is empty now!");
        }
        // ------------------------------------------------------------------------------------

        {
            // ------------------------------------ Duplicate Function Test ---------------------------
            Integer[] arrayWithDuplicates = {1, 2, 3, 3, 4};
            List<Integer> keysWithDuplicates = Arrays.asList(arrayWithDuplicates);
            Integer[] arrayWithoutDuplicates = {1, 2, 3, 4};
            List<Integer> keysWithoutDuplicates = Arrays.asList(arrayWithoutDuplicates);
            System.out.println("Should return true to identify a duplicate: " + findDuplicates(keysWithDuplicates));
            System.out.println("Should return false to identify no duplicates: " + findDuplicates(keysWithoutDuplicates));
            // ----------------------------------------------------------------------------------------
        }

        // ----- START: HashSet Design Interactive Activity on LeetCode -----
        {
            MyHashSet hashSetObj = new MyHashSet();
            hashSetObj.add(1);
            hashSetObj.add(2);
            hashSetObj.remove(2);
            System.out.println(hashSetObj.contains(2)); // Should print: false
        }
        // ----- END: HashSet Design Interactive Activity on LeetCode -----

        // ----- START: HashSet Design Interactive Activity on LeetCode -----
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.put(1, 1); // The map is now [[1,1]]
            myHashMap.put(2, 2); // The map is now [[1,1], [2,2]]
            System.out.println(myHashMap.get(1));    // return 1, The map is now [[1,1], [2,2]]
            System.out.println(myHashMap.get(3));    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
            myHashMap.put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
            System.out.println(myHashMap.get(2));    // return 1, The map is now [[1,1], [2,1]]
            myHashMap.remove(2); // remove the mapping for 2, The map is now [[1,1]]
            System.out.println(myHashMap.get(2));    // return -1 (i.e., not found), The map is now [[1,1]]
        }
        // ----- END: HashSet Design Interactive Activity on LeetCode -----

    }

    // ------------------------------------------------------------------------------------
    // Example function to find duplicates using HashSet
    // ------------------------------------------------------------------------------------
    static boolean findDuplicates(List<Integer> keys) {
        Set<Integer> hashset = new HashSet<>();
        for (Integer key : keys) {
            if (hashset.contains(key)) {
                return true;
            }
            hashset.add(key);
        }
        return false;
    }

}





// ------------------------------------------------------------------------------------
// Design HashSet Interactive Activity on LeetCode
// https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1139/
// ------------------------------------------------------------------------------------
class MyHashSet {

    // Store local hashset integer array and size
    private int[] hashSet;
    private int size;
    
    // Initialise an empty integer array and 0 size
    public MyHashSet() {
        size = 0;
        hashSet = new int[0];
    }
    
    // Add new element to the array (and resize if needed)
    public void add(int key) {
        
        // Guard clause to do nothing if the key already exists
        if (contains(key)){
            return;
        }
        
        // Set up variables for the new and old sizes
        int oldSize = size;
        int newSize = size + 1;
        
        // Create new integer array of new size
        int[] tempHashSet = new int[newSize];
        
        // Guard clause to just add an element if it is currently a null array
        if (hashSet.length < 1){
            tempHashSet[0] = key;
            hashSet = tempHashSet;
            size = newSize;
            return;
        }
        
        // Otherwise add the new key to the end
        for (int i = 0; i < oldSize; i++){
            tempHashSet[i] = hashSet[i];
        }
        tempHashSet[oldSize] = key;
        
        // Assign the new hashSet and set the new size
        hashSet = tempHashSet;
        size = newSize;
        
    }
    
    public void remove(int key) {
        
        // Guard clause to return early if hashset is null
        if (hashSet.length < 1){
            return;
        }
        
        // Guard clause to not do anything else if it doesn't contain the key
        if (!contains(key)){
            return;
        }
        
        // Set up variables for the new and old sizes
        int oldSize = size;
        int newSize = size - 1;
        
        // Create new integer array of new size
        int[] tempHashSet = new int[newSize];
        
        int j = 0;
        for(int i = 0; i < oldSize; i++){
            if (hashSet[i] != key){
                tempHashSet[j] = hashSet[i];
                j = j + 1;
            }
        }
        
        // Assign the new hashSet and set the new size
        hashSet = tempHashSet;
        size = newSize;
    }
    
    public boolean contains(int key) {
        
        // Guard clause to return false if hashset is null
        if (hashSet.length < 1){
            return false;
        }
        
        // Loop through array and return true if key is found
        for (int i = 0; i < size; i++){
            if (hashSet[i] == key){
                return true;
            }
        }
        return false;
        
    }
}
// ------------------------------------------------------------------------------------


// ------------------------------------------------------------------------------------
// Design HashMap Interactive Activity on LeetCode
// https://leetcode.com/explore/learn/card/hash-table/182/practical-applications/1140/
// ------------------------------------------------------------------------------------
class MyHashMap {

    // Store local hashset integer array and size
    private int[][] hashMap;
    private int size;

    // Initialise to empty array
    public MyHashMap() {
        hashMap = new int[0][0];
        size = 0;
    }
    
    public void put(int key, int value) {       
        // Set up variables for the new and old sizes
        int oldSize = size;
        int newSize = size + 1;
        
        // Create new integer array of new size
        int[][] tempHashMap = new int[newSize][2];
        
        // Guard clause to just add an element if it is currently a null array
        if (hashMap.length < 1){
            tempHashMap[0][0] = key;
            tempHashMap[0][1] = value;
            hashMap = tempHashMap;
            size = newSize;
            return;
        }

        // Update the element if it is found
        int keyIdx = contains(key);
        if (keyIdx > -1){
            hashMap[keyIdx][1] = value;
            return;
        }
        
        // Otherwise add the new key to the end
        for (int i = 0; i < oldSize; i++){
            tempHashMap[i][0] = hashMap[i][0];
            tempHashMap[i][1] = hashMap[i][1];
        }
        tempHashMap[oldSize][0] = key;
        tempHashMap[oldSize][1] = value;
        
        // Assign the new hashSet and set the new size
        hashMap = tempHashMap;
        size = newSize;
    }
    
    public int get(int key) {
        int keyIdx = contains(key);
        if (keyIdx == -1){
            return -1;
        }
        return hashMap[keyIdx][1];
    }
    
    public void remove(int key) {
        // Guard clause to return early if hashset is null
        if (hashMap.length < 1){
            return;
        }
        
        // Guard clause to not do anything else if it doesn't contain the key
        if (contains(key) == -1){
            return;
        }
        
        // Set up variables for the new and old sizes
        int oldSize = size;
        int newSize = size - 1;
        
        // Create new integer array of new size
        int[][] tempHashSet = new int[newSize][2];
        
        int j = 0;
        for(int i = 0; i < oldSize; i++){
            if (hashMap[i][0] != key){
                tempHashSet[j][0] = hashMap[i][0];
                tempHashSet[j][1] = hashMap[i][1];
                j = j + 1;
            }
        }
        
        // Assign the new hashSet and set the new size
        hashMap = tempHashSet;
        size = newSize;
    }

    // Contains returns an int with either the index of the key, or -1 if not found
    private int contains(int key){
        // Guard clause to return false if hashset is null
        if (hashMap.length < 1){
            return -1;
        }
        
        // Loop through array and return true if key is found
        for (int i = 0; i < size; i++){
            if (hashMap[i][0] == key){
                return i;
            }
        }
        return -1;
    }
}
// ------------------------------------------------------------------------------------
