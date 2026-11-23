public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Pattern: HashSet + sequence counting
        // 1. intialize the hashset with the nums for O(1) query
        var numSet = new HashSet<int>();
        foreach (var num in nums)
            numSet.Add(num);

        // 2. We consider a element as a sequence beginning, if the element - 1 do not exist in the hashset.
        // 3. Then for each element + 1, we increment the next sequence expected and the seqCount until the sequence is not found.
        // 4. We store the seqCount into a longestCount, if it is more than the previous recorded longestCount.
        int longestSeqCount = 0;
        foreach (var num in nums)
        {
            if (numSet.Contains(num - 1) is false)
            {
                int curr = num;
                int seqCount = 1;

                // Start counting until the curr + 1 is not found in the set
                while (numSet.Contains(curr + 1))
                {
                    curr++;
                    seqCount++;
                }

                // Store the longest count
                longestSeqCount = Math.Max(seqCount, longestSeqCount);
            }
        }
        
        // 5. Return the longestCount.
        return longestSeqCount;
    }
}
