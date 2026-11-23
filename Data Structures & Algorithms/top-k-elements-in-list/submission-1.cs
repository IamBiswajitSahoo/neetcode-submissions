public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Pattern - HashMap + BucketSort or PriorityQueue
        // 1. Hashmap to keep counts for each item in the array. Time - O(n), Space - O(d) d = distinct items
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
            freq[num] = freq.GetValueOrDefault(num, 0) + 1;

        // For Bucket Sort:
        // 2. Create an list<int> to hold each item by their frequencies as the respective index.
        // Length of the list to be nums + 1, so that we can go upto the length of the array, as an element can have frequency max to array lengtth
        // 3. Loop back to front on the array, and for each index, loop over it's list to add the elements into a result[k], k = target length
        // 4. Return the results array
        // var bucket = new List<int>[nums.Length + 1];
        // foreach (KeyValuePair<int, int> pair in freq)
        // {
        //     // Value = Frequency, Key = Num
        //     (bucket[pair.Value] ??= new List<int>()).Add(pair.Key);
        // }

        // var results = new List<int>(k);
        // for (int i = bucket.Length - 1; i >= 0; i--)
        // {
        //     if (bucket[i] is null)
        //         continue;

        //     foreach (var n in bucket[i])
        //     {
        //         results.Add(n);

        //         if (results.Count == k)
        //             return results.ToArray();
        //     }
        // }

        // return Array.Empty<int>();
            
        // For Priority Queue:
        // 5. Loop over the hashmap and add the items into a priority queue of length 2 with their frequency as the priority
        // 6. In the end return the priority queue items as an array
        var pq = new PriorityQueue<int, int>();
        foreach (KeyValuePair<int, int> pair in freq)
        {
            pq.Enqueue(pair.Key, pair.Value);

            if (pq.Count > k)
                pq.Dequeue();
        }

        return pq.UnorderedItems.Select(item => item.Element).ToArray();
    }
}
