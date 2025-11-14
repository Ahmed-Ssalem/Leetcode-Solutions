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
    public ListNode DeleteMiddle(ListNode head) {
        
        if (head.next == null)
            return null;

        ListNode slow = head;
        ListNode fast = head;
        ListNode prevSlow = null;

        while (fast != null && fast.next != null)
        {
            prevSlow = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prevSlow.next = slow.next;

        return head;

        
        // if (head.next == null)
        //     return null;

        // ListNode current = head;
        // int nodesCount = 0;

        // while (current != null)
        // {
        //     current = current.next;
        //     nodesCount++;
        // }

        // int middleIndx = nodesCount / 2;
        // int currentIndex = 0;
        // ListNode middleNode = head;

        // while (middleNode != null && currentIndex < middleIndx - 1)
        // {
        //     middleNode = middleNode.next;
        //     currentIndex++;
        // }

        // middleNode.next = middleNode.next.next;
        // return head; 
    }
}