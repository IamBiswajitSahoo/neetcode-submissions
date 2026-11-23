public class Solution {

    public string Encode(IList<string> strs) {
        
        // 1. String builder to merge everything as a singke sting
        StringBuilder strBuilder = new StringBuilder();

        // 2. Loop over all the strings and append to the string builder
        foreach (var str in strs)
        {
            // Encoding format is [length of string][-][string]
            strBuilder.Append(str.Length);
            strBuilder.Append("-");
            strBuilder.Append(str);
        }

        // 3. Materialize to the string
        return strBuilder.ToString();

    }

    public List<string> Decode(string s) 
    {
        // List to hold all the decoded strings
        var decodedStings = new List<string>();

        // 1. We use two pointers i and j to keep track of the decoding
        int i = 0;
        
        // 2. We loop through the complete encoded string.
        // 5-hello3-cat3-dog5-world
        while (i < s.Length)
        {
            int j = i;

            // 3. We increase j until we find the first "-" delimeter
            while (s[j] != '-')
                j++;

            // 4. Once we found the j'th index for "-" we can compute the length of the current string.
            // j-i is required to normalize the value to start again from 0. For example if i = 7, and j = 9, we cannot use Substring(7, 9), which would take the 9 characters from index 7, instead if we normalize by 9-7, we get 2, so we do Substring(7, 2), to give us the right characters as length. Then int.Parse("7") => 7 as Integer.
            int length = int.Parse(s.Substring(i, j - i)); 

            // 5. Now with the j's position (delimeter) and length, we can extract the string. As the string start right after the "-" delimeter, j+1 gives the correct index to begin.
            string str = s.Substring(j+1, length);
            decodedStings.Add(str);

            // 6. Now we need to move the i' to start of the next string's encoded length.
            i = j + 1 + length;
        }

        // 7. Return the list of decoded strings
        return decodedStings;
    }
}
