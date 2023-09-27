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
    // https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1105/
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

}