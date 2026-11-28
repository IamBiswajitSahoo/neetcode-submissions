public class Solution {
    public bool IsPalindrome(string s) {
        // Pattern: Opposite Two pointers
        // 1. Create pointer at start and end
        // 2. Run while loop until left < right
        // 3. Update the pointers if they are non-alphanumerics
        // 4. Return false if at any positions the characters are not same
        // 5. Return true in the end
        
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && char.IsLetterOrDigit(s[left]) is false)
                left++;

            while (left < right && char.IsLetterOrDigit(s[right]) is false)
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;

    }
}
