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
    public ListNode MergeKLists(ListNode[] lists) {

        if (lists.Length == 0)
            return null;
        
        for(int interval = 1; interval < lists.Length; interval *= 2)
        {
            for(int i = 0;i < lists.Length-interval; i += 2*interval)
            {
                lists[i] = Merge2SortedLists(lists[i], lists[i+interval]);
            }
        }
        return lists[0];
    }
    public ListNode Merge2SortedLists(ListNode head1, ListNode head2)
    {
        ListNode dummyHead = new ListNode();
        ListNode tail = dummyHead;
        while(head1 != null && head2 != null)
        {
            if(head1.val <= head2.val)
            {
                tail.next = head1;
                head1 = head1.next;
            }
            else
            {
                tail.next = head2;
                head2 = head2.next;
            }
            tail = tail.next;
        }

        tail.next = head1 ?? head2;

        return dummyHead.next; 
    }
}
