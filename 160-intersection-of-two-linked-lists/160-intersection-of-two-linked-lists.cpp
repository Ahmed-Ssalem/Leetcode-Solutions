/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode *getIntersectionNode(ListNode *headA, ListNode *headB) {
        
        int n1 = 0, n2 = 0;
        ListNode* a = headA, *b = headB;
       
        while (a)
            n1++, a = a -> next;
        
        while (b)
            n2++, b = b -> next;
        
        a = headA, b = headB;
        
        while (a && n1 > n2)
            a = a -> next, n1--;
        
        while(b && n2 > n1)
            b = b -> next, n2--;
        while (a && b){
            if (a == b)
                return a;
            else
                a = a -> next, b = b -> next;
        }
        return NULL;

    }
};