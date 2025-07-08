// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Solution1 solution = new Solution1();
// int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
// var result = solution.ThreeSum(nums);
// foreach (var triplet in result)
// {
//     Console.WriteLine($"[{string.Join(", ", triplet)}]");
// }

//testRemoveNthLastNode([1,2,3,4,5], 2);
testRemoveNthLastNode([1,2,3,4,5], 5);

static void testRemoveNthLastNode(int[] arr, int n)
{
    ListNode head = null;
    ListNode current = null;

    foreach (var value in arr)
    {
        if (head == null)
        {
            head = new ListNode(value);
            current = head;
        }
        else
        {
            current.next = new ListNode(value);
            current = current.next;
        }
    }

    ListNode updatedHead = Solution.RemoveNthLastNode(head, n);
    while (updatedHead != null)
    {
        Console.Write(updatedHead.val + " --> ");
        updatedHead = updatedHead.next;
    }
}
