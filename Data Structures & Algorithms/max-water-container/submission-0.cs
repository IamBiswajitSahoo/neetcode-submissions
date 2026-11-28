public class Solution {
    public int MaxArea(int[] heights) {
        // Pattern: opposite Two Poinnters + Area of a rectangle
        // Target is to find maximum heights with the most width to form the max area
        // Pointers should update to maximise the shorter height
        // Area: min(height[i], height[j]) x (j - i) (where i < j).

        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int height = Math.Min(heights[left], heights[right]);
            int width = right - left; // right > left
            int area = height * width;
            maxArea = Math.Max(area, maxArea); // Update the maximum area

            // 1. If the height at the left pointer is shorter, increase the left pointer
            if (heights[left] < heights[right])
                left ++;

            // 2. Else, if the heights are equal or the height at the right pointer is short, we decrease the right pointer. For equal heights either pointer move to work.
            else
                right --;
        }

        return maxArea;
    }
}
