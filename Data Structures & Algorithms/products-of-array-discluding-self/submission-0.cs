public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // 1. Create a results array of nums.Length to hold the products
        int[] results = new int[nums.Length];

        // 2. First intiialize a left_product and do a first pass on the array from left to right to compute all the left products. Omitting the left most element.
        int left_product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            results[i] = left_product; // For left-most element it would set it to 1.
            left_product *= nums[i];   // For right-most element it would set it to all prodocuts except the right-most element included, as the loop would discard the product after last element.
        }

        // 3. Then initialize a right_product and do the second pass from right to left to compute the right x left products. Including the precomputed left product of right-most item.
        int right_product = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            results[i] *= right_product; // Multiples 1 with the right-most element first, leaving it only as the previously computed left-product.
            right_product *= nums[i];
        }

        return results;

    }
}
