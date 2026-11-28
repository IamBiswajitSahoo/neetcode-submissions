/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // Pattern: Fast and Slow Two pointers
        
        ListNode start = new ListNode(0, head);
        var slow = start;
        var fast = start;

        // INcremenebt the the fast by the n places
        for (int i = 0; i < n ; i++)
            fast = fast.next;
        
        // Loop until the fast.next != null and increment both the pointers
        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;

            // At the end the fast would be at end of the list
            // And slow would be exactly fast - n - 1 place we need to remove the item from.
        }

        // Remove the node
        slow.next = slow.next.next;

        return start.next; // .next to return the head and not the dummy value we added
    }
}
