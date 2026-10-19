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
    //iterative:
    // public ListNode ReverseList(ListNode head) {
    //     ListNode currNode = head;
    //     ListNode prevNode = null;

    //     while(currNode != null)
    //     {
    //         ListNode nextNode = currNode.next;
    //         currNode.next = prevNode;
    //         prevNode = currNode;
    //         currNode = nextNode;
    //     }
    //     return prevNode;
    // }
    //recursive:
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode newHead = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return newHead;
    }
}


