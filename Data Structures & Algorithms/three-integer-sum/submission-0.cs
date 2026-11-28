public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // Pattern: Sort + One Fixed pointer + Two Pointers
        // best case: 0(n^2). Space: O(1)

        // 0. sort the array, otherwise two pointers will not work
        // 1. Start with an empty list
        // 2. Run the fixed pointer loop from 0, length - 2. -2 is for other pointers to cover
        // 3. In the loop initialize the left = i + 1, right = length - 1
        // 4. Early case return, would be to return if nums[i] > 0, as the array is sorted, > 0 mean no further items would add to 0, we can break out of the loop.
        // 5. Duplicate removal for fixed pointer, i > 0 and if nums[i] == nums[i-1], checking backwards is important, otherwise if we check the next element, we could loose a valid number to start with.
        // 6. Run loop until left < right,
        // 7. Calculate the sum, and if the sum is 0, add the result to the list and increment the pointers.
        //      7.a. Remove the duplicates for the pointers after the sum computation
        // 8. If the sum < 0, we do left++; and if the sum > 0, we decrease the right pointer, right--;
        // 9. Return the result list.

        var results = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0)
                break;

            // Fixed pointer duplicate skip
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            // Pointers initialization
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if      (sum < 0)   left ++;
                else if (sum > 0)   right --;
                else
                {
                    results.Add(new List<int>() {nums[i], nums[left], nums[right]});
                    left ++;
                    right --;

                    // Remove the duplicates for the two pointers
                    while (left < right && nums[left] == nums[left - 1])
                        left ++;
                    while (left < right && nums[right] == nums[right + 1])
                        right --;
                }
            }
        }

        return results;
    }
}
