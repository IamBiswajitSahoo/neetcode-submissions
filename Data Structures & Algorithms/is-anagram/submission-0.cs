public class Solution {
    public bool IsAnagram(string s, string t) {

        // Sorting each string would be O(n log n).
        // We can do O(n) for time and space both.

        if (s.Length != t.Length)
            return false;

        // 1. Create a character frequency array to hold each character by their index and their frequency
        int[] charFrequency = new int[26];

        // 2. Loop over any string and increment the character index by 1 and also for the other string decrement it's character count by 1
        for (int i = 0; i < s.Length; i++)
        {
            charFrequency[s[i] - 'a']++;
            charFrequency[t[i] - 'a']--;
        }

        // 3. If the string contains anagrams, then the increment and decrement would zero themselves out
        return charFrequency.All(item => item == 0);
    }
}
