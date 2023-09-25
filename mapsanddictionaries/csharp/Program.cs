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

    }

    // ------------------------------------------------------------------------------------
    // Example function to find duplicates using HashSet
    // ------------------------------------------------------------------------------------
    static bool FindDuplicates(List<int> keys) {
        HashSet<int> hashset = new HashSet<int>();
        foreach (int key in keys) {
            if (hashset.Contains(key)) {
                return true;
            }
            hashset.Add(key);
        }
        return false;
    }

}