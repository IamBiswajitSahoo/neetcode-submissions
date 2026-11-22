public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var numsByIndices = new Dictionary<int, int>();

        // Loop and check if the complement exists
        for (int i = 0; i < nums.Length; i++)
        {
            // nums[i] + nums[j] = target,
            // nums[j] = target - nums[i]
            int complement = target - nums[i];
            if (numsByIndices.TryGetValue(complement, out int index))
                return new int[2] { index, i };

            numsByIndices[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
