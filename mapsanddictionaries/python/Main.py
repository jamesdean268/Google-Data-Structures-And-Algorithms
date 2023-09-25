
class Main:
    # ------------------------------------------------------------------------------------
    # Example function to find duplicates using HashSet
    # ------------------------------------------------------------------------------------
    def findDuplicates(keys) -> bool:
        hashset = set() 
        for key in keys:
            if (key in hashset):
                return True
            hashset.add(key)
        return False

    def Main(self):
        # ------------------------------------------------------------------------------------
        # HashSet Usage on LeetCode
        # https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1130/
        # ------------------------------------------------------------------------------------
        # 1. initialize the hash set
        hashset = set() 
        # 2. add a new key
        hashset.add(3)
        hashset.add(2)
        hashset.add(1)
        # 3. remove a key
        hashset.remove(2)
        # 4. check if the key is in the hash set
        if (2 not in hashset):
            print("Key 2 is not in the hash set.")
        # 5. get the size of the hash set
        print("Size of hashset is:", len(hashset)) 
        # 6. iterate the hash set
        for x in hashset:
            print(x, end=" ")
        print("are in the hash set.")
        # 7. clear the hash set
        hashset.clear()                         
        print("Size of hashset:", len(hashset))
        # ------------------------------------------------------------------------------------

        # ------------------------------------ Duplicate Function Test ---------------------------
        keysWithDuplicates = [1, 2, 3, 3, 4]
        keysWithoutDuplicates = [1, 2, 3, 4]
        print("Should return true to identify a duplicate: " + str(self.findDuplicates(keysWithDuplicates)))
        print("Should return false to identify no duplicates: " + str(self.findDuplicates(keysWithoutDuplicates)))
        # ----------------------------------------------------------------------------------------


if __name__ == '__main__':
    Main.Main(Main)
