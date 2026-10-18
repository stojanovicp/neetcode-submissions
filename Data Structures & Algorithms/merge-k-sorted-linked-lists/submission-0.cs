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
        if(lists.Length == 0) return null;

        return MergeRange(lists, 0, lists.Length - 1);
    }
    private ListNode MergeRange(ListNode[] lists, int left, int right)
    {
        if(left==right) return lists[left];

        int mid = (left + right) / 2;
        ListNode L = MergeRange(lists, left, mid);
        ListNode R = MergeRange(lists, mid+1, right);

        return MergeTwoLists(L,R);
    }
    private ListNode MergeTwoLists(ListNode A, ListNode B)
    {
        ListNode first = new ListNode();
        ListNode cur = first;
        while(A != null && B != null)
        {
            if(A.val<=B.val)
            {
                cur.next = A;
                cur = cur.next;
                A = A.next;
            }
            else
            { 
                cur.next = B;
                cur = cur.next;
                B = B.next;
            }
        }
        cur.next = A ?? B;
        return first.next;
    }
}
