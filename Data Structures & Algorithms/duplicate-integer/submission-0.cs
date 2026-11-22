public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        // 1. Create a hashset to hold the distinct keys. Space - O(d), d = distinct nums
        var numSet = new HashSet<int>();

        // 2. Loop over the nums
        // Check if the num already exist in the hashset, 
        //  if not, add it to the hashset
        //  if so return true
        // If all elements are distinct return false.
        // Time - O(n), query - O(1)
        foreach(int num in nums)
        {
            if (numSet.Contains(num))
                return true;

            numSet.Add(num);
        }

        // All elementes are distinct
        return false;
    }
}