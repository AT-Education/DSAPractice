namespace dsa_practice_csharp.educative.patterns.fastandslowpointers
{
   public class Solution
   {
      public static bool CircularArrayLoop(int[] nums)
      {
         for (int i = 0; i < nums.Length; i++)
            if (detectCycle(nums, i))
               return true;
         return false;
      }

      private static bool detectCycle(int[] nums, int index)
      {
         int slow = index, fast = index;

         do
         {
            slow  = traverse(nums, slow);
            fast = traverse(nums, traverse(nums, fast));

            if (slow == -1 || fast == -1 || slow >= nums.Length || fast >= nums.Length)
               return false;

         } while (slow != fast);

         return true;
      }
      private static int traverse(int[] nums, int index) => nums[index];
   } 
}