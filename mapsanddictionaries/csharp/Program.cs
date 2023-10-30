using System.Collections;
using System.Globalization;

class ProgramhashMapObj
{
    static void Main(string[] args)
    {
        // ------------------------------------------------------------------------------------
        // HashSet Usage on LeetCode
        // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1130/
        // ------------------------------------------------------------------------------------
        // 1. initialize the hash set
        HashSet<int> hashSet = new HashSet<int>();     
        // 2. add a new key
        hashSet.Add(3);
        hashSet.Add(2);
        hashSet.Add(1);
        // 3. remove the key
        hashSet.Remove(2);        
        // 4. check if the key is in the hash set
        if (!hashSet.Contains(2)) {
            Console.WriteLine("Key 2 is not in the hash set.");
        }
        // 5. get the size of the hash set
        Console.WriteLine("The size of has set is: " + hashSet.Count);     
        // 6. iterate the hash set
        foreach (int i in hashSet) {
            Console.Write(i + " ");
        }
        Console.WriteLine("are in the hash set.");
        // 7. clear the hash set
        hashSet.Clear();
        // 8. check if the hash set is empty
        if (!hashSet.Any()) {
            Console.WriteLine("hash set is empty now!");
        }
        // ------------------------------------------------------------------------------------

        // ------------------------------------------------------------------------------------
        // HashMap Usage on LeetCode
        // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1129/
        // ------------------------------------------------------------------------------------
        // 1. initialize a hash map (dictionary in C#)
        Dictionary<int, int> hashmap = new Dictionary<int, int>();
        // 2. insert a new (key, value) pair
        hashmap.TryAdd(0, 0);
        hashmap.TryAdd(2, 3);
        // 3. insert a new (key, value) pair or update the value of existed key
        hashmap.Add(1, 1);
        hashmap[1] = 2;
        // 4. get the value of specific key
        Console.WriteLine("The value of key 1 is: " + hashmap[1]);
        // 5. delete a key
        hashmap.Remove(2);
        // 6. check if a key is in the hash map
        if (!hashmap.ContainsKey(2)) {
            Console.WriteLine("Key 2 is not in the hash map.");
        }
        // 7. get the size of the hash map
        Console.WriteLine("The size of hash map is: " + hashmap.Count);
        // 8. iterate the hash map
        foreach (KeyValuePair<int, int> entry in hashmap) {
            Console.Write("(" + entry.Key + "," + entry.Value + ") ");
        }
        Console.WriteLine("are in the hash map.");
        // 9. clear the hash map
        hashmap.Clear();
        // 10. check if the hash map is empty
        if (!hashmap.Any()) {
            Console.WriteLine("hash map is empty now!");
        }

        {
            // ------------------------------------ Duplicate Function Test ---------------------------
            List<int> keysWithDuplicates = new List<int> {1, 2, 3, 3, 4};
            List<int> keysWithoutDuplicates = new List<int> {1, 2, 3, 4};
            Console.WriteLine("Should return true to identify a duplicate: " + FindDuplicates(keysWithDuplicates));
            Console.WriteLine("Should return false to identify no duplicates: " + FindDuplicates(keysWithoutDuplicates));
            // ----------------------------------------------------------------------------------------
        }

        {
            // ------------------------------------ Single Number Function Test -----------------------
            int[] nums = {4,1,2,1,2};
            Console.WriteLine(SingleNumber(nums));

            // ----------------------------------------------------------------------------------------
        }

        {
            // ------------------------------------ Intersection Function Test -----------------------
            int[] nums1 = {4,9,5};
            int[] nums2 = {9,4,9,8,4};
            int[] intersect = Intersection(nums1, nums2);
            string outString = "";
            foreach (int i in intersect) {
                outString += i + " ";
            }
            Console.WriteLine(outString);
            // ----------------------------------------------------------------------------------------
        }

        {
            // ------------------------------------ IsHappy Function Test -----------------------
            int n = 19;
            Console.WriteLine(IsHappy(n));
            // ----------------------------------------------------------------------------------------
        }

        {
            // ------------------------------------ TwoSum Function Test -----------------------
            int[] nums = {3,2,4};
            int target = 6;
            int[] twoSumOutput = TwoSum(nums, target);
            string outString = "";
            foreach (int i in twoSumOutput) {
                outString += i + " ";
            }
            Console.WriteLine(outString);
            // ----------------------------------------------------------------------------------------
        }

        {
            // ------------------------------------ IsIsomorphic Function Test -----------------------
            string s = "paper";
            string t = "title";
            bool isIsomorphicOutput = IsIsomorphic(s, t);
            Console.WriteLine(s + " and " + t + " are isomorphic: " + isIsomorphicOutput);
            // ----------------------------------------------------------------------------------------
        }



        {   
            // ------------------------------------ IsIsomorphic Function Test -----------------------
            string[] list1 = {"happy","sad","good"};
            string[] list2 = {"sad","happy","good"};
            string[] findRestaurantOutput = FindRestaurant(list1, list2);
            string outString = "";
            foreach (string i in findRestaurantOutput) {
                outString += i + " ";
            }
            Console.WriteLine(outString);
            // ----------------------------------------------------------------------------------------
        }

        {   
            // ------------------------------------ FirstUniqueChar Function Test -----------------------
            string s = "dddccdbba";
            Console.WriteLine(FirstUniqChar(s));
            // ----------------------------------------------------------------------------------------
        }

        {   
            // ------------------------------------ Intersect Function Test -----------------------
            int[] nums1 = {1,2,2,1};
            int[] nums2 = {2,2};
            int[] intersectOutput = Intersect(nums1, nums2);
            string outString = "";
            foreach (int i in intersectOutput) {
                outString += i + " ";
            }
            Console.WriteLine(outString);
            // ----------------------------------------------------------------------------------------
        }

        {   
            // ------------------------------------ ContainsNearbyDuplicate Function Test -----------------------
            int[] nums = {1,2,3,1};
            int k = 3;
            Console.WriteLine(ContainsNearbyDuplicate(nums, k));
            // ----------------------------------------------------------------------------------------
        }

        {   
            // ------------------------------------ GroupAnagrams Function Test -----------------------
            string[] strs = {"eat","tea","tan","ate","nat","bat"};
            IList<IList<string>> groupAnagramsOutput = GroupAnagrams(strs);
            foreach (IList<string> listStrs in groupAnagramsOutput){
                foreach (string str in listStrs){
                    Console.Write(str + ", ");
                }
                Console.Write(" / ");
            }
            Console.WriteLine();
            // ----------------------------------------------------------------------------------------
        }

        {
            // ------------------------------------ IsValidSudoku Function Test -----------------------
            char[] row1 = new char[] {'5','3','.','.','7','.','.','.','.'};
            char[] row2 = new char[] {'6','.','.','1','9','5','.','.','.'};
            char[] row3 = new char[] {'.','9','8','.','.','.','.','6','.'};
            char[] row4 = new char[] {'8','.','.','.','6','.','.','.','3'};
            char[] row5 = new char[] {'4','.','.','8','.','3','.','.','1'};
            char[] row6 = new char[] {'7','.','.','.','2','.','.','.','6'};
            char[] row7 = new char[] {'.','6','.','.','.','.','2','8','.'};
            char[] row8 = new char[] {'.','.','.','4','1','9','.','.','5'};
            char[] row9 = new char[] {'.','.','.','.','8','.','.','7','9'};

            char[][] board = new char[][]{row1, row2, row3, row4, row5, row6, row7, row8, row9};
            Console.WriteLine(IsValidSudoku(board));
        }

    }

    // ------------------------------------------------------------------------------------
    // Example function to find duplicates using HashSet
    // ------------------------------------------------------------------------------------
    static bool FindDuplicates(List<int> keys) {
        HashSet<int> hashSet = new HashSet<int>();
        foreach (int key in keys) {
            if (hashSet.Contains(key)) {
                return true;
            }
            hashSet.Add(key);
        }
        return false;
    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    // Input: nums = [4,1,2,1,2] // Output: 4
    // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1176/
    // ------------------------------------------------------------------------------------
    static int SingleNumber(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>();
        foreach (int num in nums)
        {
            if (hashSet.Contains(num)){
                hashSet.Remove(num);
            } else {
                hashSet.Add(num);
            }
        }
        return hashSet.First();
    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: Given two integer arrays nums1 and nums2, return an array of their intersection. 
    // Each element in the result must be unique and you may return the result in any order.
    // Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
    // Output: [9,4]
    // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1105/
    // ------------------------------------------------------------------------------------

    static int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> hashSet1 = new HashSet<int>(nums1);
        HashSet<int> hashSet2 = new HashSet<int>(nums2);
        System.Collections.Generic.IEnumerable<int> intersect = hashSet1.Intersect(hashSet2);
        return intersect.ToArray();
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
    static bool IsHappy(int n) {
        // check if 1 already, if so, return true
        if (n == 1) return true;

        // Convert to a string
        string strN = n.ToString();

        // Create empty hashSet
        HashSet<int> hashSet = new HashSet<int>();

        // Loop until convergence or an endless cycle
        while(true){
            // Split the int into its components, square, and add
            int squareSum = 0;
            foreach (char digit in strN){
                int intDigit = Convert.ToInt32(digit.ToString());
                squareSum += intDigit * intDigit;
            }

            // Check for convergence for one
            if (squareSum == 1) return true;          

            // Check for endless loop (i.e. if hashset contains a number, we have looped)
            if (hashSet.Contains(squareSum)) return false;

            // If it is a new number and not one, add it to the hashset, and set it as the new StrN
            hashSet.Add(squareSum);
            strN = squareSum.ToString();
        }

    }


    // ------------------------------------------------------------------------------------
    // Leetcode question: 
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.
    //
    // Input: nums = [2,7,11,15], target = 9
    // Output: [0,1]
    //
    // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1105/
    // ------------------------------------------------------------------------------------
    static int[] TwoSum(int[] nums, int target) {
        // Create the Dictionary
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        int[] outArray = {0, 1};

        // Loop through and add values to indices in the hashmap
        for (int i = 0; i < nums.Length; i++) {
            
            // If out number is in the hashmap, it means we have found the target, return
            if (hashMap.ContainsValue(nums[i])){
                int key = hashMap.Keys.FirstOrDefault(k => hashMap[k] == nums[i]);
                outArray[0] = key;
                outArray[1] = i;
                return outArray;
            }

            // If not, add the result to the hashmap for checking next time
            hashMap[i] = target - nums[i];

        }

        return outArray;
        
    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: 
    // Given two strings s and t, determine if they are isomorphic.
    // Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    // All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
    //
    // Input: s = "paper", t = "title"
    // Output: true
    //
    // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1117/
    // ------------------------------------------------------------------------------------
    static bool IsIsomorphic(string s, string t) {
        // Pseudo-code
        // Add s as key and t as value to a dictionary
        // The key value pair should always be the same, if not, return false
        Dictionary<char, char> hashMapS = new Dictionary<char, char>();
        Dictionary<char, char> hashMapT = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++){
            if (hashMapS.ContainsKey(s[i])){
                if (hashMapS[s[i]] != t[i]){
                    return false;
                }
            }
            if (hashMapT.ContainsKey(t[i])){
                if (hashMapT[t[i]] != s[i]){
                    return false;
                }
            }
            hashMapS[s[i]] = t[i];
            hashMapT[t[i]] = s[i];
        }
        return true;
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
    static string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> list1Dict = list1.ToDictionary(listItem => listItem, listItem => Array.IndexOf(list1, listItem));
        Dictionary<string, int> list2Dict = list2.ToDictionary(listItem => listItem, listItem => Array.IndexOf(list2, listItem));

        // Intersect the two dictionaries by key and sum the values.
        Dictionary<string, int> listIntersection = new Dictionary<string, int>();
        foreach (string key in list1Dict.Keys)
        {
            if (list2Dict.ContainsKey(key))
            {
                listIntersection.Add(key, list1Dict[key] + list2Dict[key]);
            }
        }

        // Get the minimum of the indices
        int minValue = listIntersection.Values.Min();
        
        // Output the string array
        List<string> outString = new List<string>();
        foreach (KeyValuePair<string, int> item in listIntersection){
            if (item.Value == minValue){
                outString.Add(item.Key);
            }
        }
        return outString.ToArray();
    }

    // ------------------------------------------------------------------------------------
    // Leetcode example: 
    // Aggregate by key example: Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.
    //
    // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1119/
    // ------------------------------------------------------------------------------------

    int AggregateByKey_hashmap(List<int> keys) {
        // Replace Type and InfoType with actual type of your key and value
        Dictionary<int, int> hashmap = new Dictionary<int, int>();
        foreach (int key in keys) {
            if (hashmap.ContainsKey(key)) {
                hashmap[key] = hashmap[key] + key;
            } 
        }
        return hashmap[0];
    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: 
    // Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1
    //
    // Input: s = "loveleetcode"
    // Output: 2
    //
    // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1120/
    // ------------------------------------------------------------------------------------
    static int FirstUniqChar(string s) {
        Dictionary<char, int> hashMap = new Dictionary<char, int>();
        int i = 0;
        foreach (char c in s) {
            i = i + 1;
            if (hashMap.ContainsKey(c)) {
                hashMap[c] = -1;
                continue;
            }
            hashMap.Add(c, i - 1);
        }
        foreach (int idx in hashMap.Values){
            if (idx != -1){
                return idx;
            }
        }
        return -1;
    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: 
    // Given two integer arrays nums1 and nums2, return an array of their intersection. 
    // Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
    //
    // Input: nums1 = [1,2,2,1], nums2 = [2,2]
    // Output: [2,2]
    //
    // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1178/
    // ------------------------------------------------------------------------------------
    static int[] Intersect(int[] nums1, int[] nums2) {
        // Create HashSets of each to find the intersection first
        HashSet<int> hashSet1 = new HashSet<int>(nums1);
        HashSet<int> hashSet2 = new HashSet<int>(nums2);
        System.Collections.Generic.IEnumerable<int> intersect = hashSet1.Intersect(hashSet2);
        HashSet<int> hashSetIntersect = intersect.ToHashSet();

        // Create Dictionaries
        Dictionary<int, int> nums1Counts = new Dictionary<int, int>();
        Dictionary<int, int> nums2Counts = new Dictionary<int, int>();
        Dictionary<int, int> combinedCounts = new Dictionary<int, int>();

        // Add Counts to nums1
        foreach (int i in nums1) {
            if (nums1Counts.ContainsKey(i)) {
                nums1Counts[i] = nums1Counts[i] + 1;
                continue;
            }
            nums1Counts.Add(i, 1);
        }

        // Add Counts to nums2
        foreach (int i in nums2) {
            if (nums2Counts.ContainsKey(i)) {
                nums2Counts[i] = nums2Counts[i] + 1;
                continue;
            }
            nums2Counts.Add(i, 1);
        }

        // Add min value to new dictionary for the combined counts (and take the minimum)
        foreach (int key in hashSetIntersect){
            if (nums1Counts.ContainsKey(key) && nums2Counts.ContainsKey(key)) {
                combinedCounts[key] = Math.Min(nums1Counts[key], nums2Counts[key]);
            }
        }

        List<int> outList = new List<int>();
        // Create an array with the number of duplicated values in it
        foreach (KeyValuePair<int, int> combedCount in combinedCounts){
            for (int i = 0; i < combedCount.Value; i++){
                outList.Add(combedCount.Key);
            }
        }

        // Return the output array
        return outList.ToArray();

    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: Contains Duplicate II
    // Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
    //
    // Input: nums = [1,2,3,1], k = 3
    // Output: true
    //
    // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1121/
    // ------------------------------------------------------------------------------------
    static bool ContainsNearbyDuplicate(int[] nums, int k) {
        // Set up dictionary with num as the key, and the lastSeenIndex of the number
        Dictionary<int, int> nearbyNums = new Dictionary<int, int>();
        int i = -1;
        int dist = k + 1;
        // Loop through nums
        foreach (int num in nums){
            i = i + 1;
            // If we have seen the number before, set the lastSeenIndex to the new index, and calculate abs(i - j)
            if (nearbyNums.ContainsKey(num)){
                // Calculate abs(i - j) and check if less than or equal to k
                dist = Math.Abs(i - nearbyNums[num]);
                if (dist <= k){
                    return true;
                }
            }
            // Set the value to the last seen index
            nearbyNums[num] = i;
        }
        return false;
    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: Group Anagrams
    // Given an array of strings strs, group the anagrams together. You can return the answer in any order.
    // An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    //
    // Input: strs = ["eat","tea","tan","ate","nat","bat"]
    // Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    //
    // https://leetcode.com/explore/learn/card/hash-table/184/comparison-with-other-data-structures/1124/
    // ------------------------------------------------------------------------------------
    static IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> stringArraysDict = new Dictionary<string, List<string>>();
        foreach (string str in strs){
            // Create char array and sort to create dictionary key
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            // If the sorted string already exists, add to the existing IList<String>
            if (stringArraysDict.ContainsKey(sortedString)){
                stringArraysDict[sortedString].Add(str);
                continue;
            }
            stringArraysDict.Add(sortedString, new List<string>(){str});
        }
        IList<IList<string>> outListStrings = new List<IList<string>>();
        foreach (List<string> list in stringArraysDict.Values){
            outListStrings.Add((IList<string>)list);
        }
        return outListStrings;
    }

    // ------------------------------------------------------------------------------------
    // Leetcode question: Valid Sudoku
    // Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
    // Each row must contain the digits 1-9 without repetition.
    // Each column must contain the digits 1-9 without repetition.
    // Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
    // Note:
    // A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    // Only the filled cells need to be validated according to the mentioned rules.
    //
    // Input: board = 
    // [["5","3",".",".","7",".",".",".","."]
    // ,["6",".",".","1","9","5",".",".","."]
    // ,[".","9","8",".",".",".",".","6","."]
    // ,["8",".",".",".","6",".",".",".","3"]
    // ,["4",".",".","8",".","3",".",".","1"]
    // ,["7",".",".",".","2",".",".",".","6"]
    // ,[".","6",".",".",".",".","2","8","."]
    // ,[".",".",".","4","1","9",".",".","5"]
    // ,[".",".",".",".","8",".",".","7","9"]]
    // Output: true
    //
    // https://leetcode.com/explore/learn/card/hash-table/185/hash_table_design_the_key/1126/
    // ------------------------------------------------------------------------------------
    static bool IsValidSudoku(char[][] board) {
        // Create a dictionary object full of hashsets to check for duplicates
        Dictionary<string, List<char>> boardCheck = new Dictionary<string, List<char>>();
        string keyRow = "";
        string keyCol = "";
        string keyBox = "";
        char currentVal = '.';
        // Loop through board (only once)
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                // Get the current value, if ".", skip
                currentVal = board[i][j];
                if (currentVal == '.') continue;
                // Set dictionary keys for the actual value
                keyRow = "row" + i;
                keyCol = "col" + j;
                keyBox = "box" + BoxId(i, j);
                // TryAdd the keys to the dictionary
                boardCheck.TryAdd(keyRow, new List<char>());
                boardCheck.TryAdd(keyCol, new List<char>());
                boardCheck.TryAdd(keyBox, new List<char>());
                // Check if there is a duplicate value in the dictionary id, if so, not a valid board
                if (boardCheck[keyRow].Contains(currentVal) || boardCheck[keyCol].Contains(currentVal) || boardCheck[keyBox].Contains(currentVal)){
                    return false;
                }
                // Add the value to each of the dictionary hashsets
                boardCheck[keyRow].Add(currentVal);
                boardCheck[keyCol].Add(currentVal);
                boardCheck[keyBox].Add(currentVal);
            }
        }
        // If nothing is invalid, then everything must be valid, return true
        return true;
    }

    static public int BoxId(int i, int j) {
        if (i < 3){
            if (j < 3){
                return 1;
            } else if (j < 6) {
                return 2;
            } else {
                return 3;
            }
        } else if (i < 6) {
            if (j < 3){
                return 4;
            } else if (j < 6) {
                return 5;
            } else {
                return 6;
            }
        } else {
            if (j < 3){
                return 7;
            } else if (j < 6) {
                return 8;
            } else {
                return 9;
            }
        }
    }

}