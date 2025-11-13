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
    public ListNode MiddleNode(ListNode head) {

        // ListNode current = head;
        // int nodesCount = 0;

        // while (current != null)
        // {
        //     current = current.next;
        //     nodesCount++;
        // }

        // int middleIndx = nodesCount / 2 ;
        // ListNode middleNode = head;

        // for (int i = 0; i < middleIndx; ++i)
        //     middleNode = middleNode.next;
        


        ListNode slow = head;
        ListNode fast = head;
        
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return slow;
    }
}