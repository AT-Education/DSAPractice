using System;
using System.Collections.Generic;

public class Solution1{
   public IList<IList<int>> ThreeSum(int[] nums)
   {
      IList<IList<int>> triplets = new List<IList<int>>();
      Array.Sort(nums);
      for(int i=0; i<nums.Length-2; i++)
      {
        int left = i+1;
        int right = nums.Length-1;
        while(left<right)
        {
                if (nums[i] + nums[left] + nums[right] == 0)
                { 
                    if (!triplets.Any(t => t[0] == nums[i] && t[1] == nums[left] && t[2] == nums[right]))
                        triplets.Add([nums[i], nums[left], nums[right]]);
                    left++;
                }
            else if(nums[i] + nums[left] + nums[right] < 0)
                left++;
            else
                right--;
        }
      }
      return triplets;
   }
}