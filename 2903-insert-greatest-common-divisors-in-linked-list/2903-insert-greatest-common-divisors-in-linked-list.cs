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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        
        if (head == null || head.next == null)
            return head;

        ListNode current = head;

        while (current != null && current.next != null)
        {
            int gcd = GCD(current.val, current.next.val);
            ListNode gcdNode = new ListNode(gcd);
            gcdNode.next = current.next;
            current.next = gcdNode;

            current = gcdNode.next;
        }
        return head;
    }
    
    private int GCD (int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

