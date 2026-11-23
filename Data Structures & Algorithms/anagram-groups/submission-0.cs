public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        // Two Approaches
        // 1. group via sorting the keys but it would be O(n log k), n = num of strings in strs[] and k = avaerage length of the strings
        // 2. create an unique key for each string character in a int[26] array and stringify it to create a key, as array instances are reference types and cannot be checked for equality. O(n + k)

        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            string key = GenerateKey(str);

            if (groups.ContainsKey(key) is false)
                groups[key] = new List<string>();
            
            groups[key].Add(str);
        }

        return groups.Values.ToList();
    }

    public string GenerateKey(string str)
    {
        int[] key = new int[26];

        foreach(var c in str)
        {
            key[c - 'a']++;
        }

        return string.Join("#", key);
    }
}
