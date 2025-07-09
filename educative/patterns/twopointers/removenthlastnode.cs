// Definition for a Linked List node
namespace dsa_practice_csharp.educative.patterns.twopointers
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        // Constructor
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class Solution2
    {
        public static ListNode RemoveNthLastNode(ListNode head, int n)
        {
            ListNode move2;
            ListNode move = move2 = head;
            int size = 0;
            while (move.next != null)
            {
                size++;
                move = move.next;
            }

            if (size <= n)
            {
                return head.next; // If n is larger than the size of the list, return the original list
            }

            for (int i = 0; i < size - n; i++)
            {
                move2 = move2.next;
            }
            move2.next = move2.next?.next;

            return head;
        }
    }
}