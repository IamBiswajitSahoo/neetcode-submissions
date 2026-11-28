public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Pattern: Two Pointers
        // 1. Start with left = 0, right = length - 1
        // 2. run the loop until left < right, as the index 1 < index 2
        // 3. compute the sum
        // 4. if the sum = target, return the numbers in a new array (each array has only 1 valid solution).
        // 5. If the sum < target, we increase left ++; otherwise we decrease right --;

        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum < target)
                left ++;
            else if (sum > target)
                right --;
            else
            {
                return new int[2] { left + 1, right + 1 };
            }
        }

        return Array.Empty<int>();
    }
}
