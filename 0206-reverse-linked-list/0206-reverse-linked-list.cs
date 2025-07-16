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
    public ListNode ReverseList(ListNode head) {
        
        if (head == null)
            return null;
        
        ListNode node = head;
        List<int> nums = new List<int>();

        while (node != null)
        {
            nums.Add(node.val);
            node = node.next;
        }

        ListNode reversedHead = new ListNode(nums[nums.Count - 1]);
        ListNode newNode = reversedHead;

        for (int i = nums.Count - 2; i >= 0; --i)
        {
            newNode.next = new ListNode(nums[i]);
            newNode = newNode.next;
        }

        return reversedHead;
    }
}