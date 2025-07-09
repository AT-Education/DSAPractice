// See https://aka.ms/new-console-template for more information
using dsa_practice_csharp.educative.patterns.fastandslowpointers;
using dsa_practice_csharp.educative.patterns.twopointers;

Console.WriteLine("Hello, World!");

#region patterns.twopointers
//testThreeSum();

//testRemoveNthLastNode([1,2,3,4,5], 5);
#endregion

#region patterns.fastandslowpointers

testCircularArrayLoop([1, 3, -2, -4, 1]);

#endregion

#region sanity tests
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

    ListNode updatedHead = dsa_practice_csharp.educative.patterns.twopointers.Solution2.RemoveNthLastNode(head, n);
    while (updatedHead != null)
    {
        Console.Write(updatedHead.val + " --> ");
        updatedHead = updatedHead.next;
    }
}

static void testCircularArrayLoop(int[] nums)
{
    if (dsa_practice_csharp.educative.patterns.fastandslowpointers.Solution.CircularArrayLoop(nums))
        Console.WriteLine("Circular Array Loop exists");
    else
        Console.WriteLine("No Circular Array Loop");
}

static void testThreeSum()
{
    Solution1 solution = new Solution1();
    int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
    var result = dsa_practice_csharp.educative.patterns.twopointers.Solution1.ThreeSum(nums);
    foreach (var triplet in result)
    {
        Console.WriteLine($"[{string.Join(", ", triplet)}]");
    }
}

#endregion