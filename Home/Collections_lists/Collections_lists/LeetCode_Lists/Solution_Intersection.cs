using System;
namespace Collections_lists.LeetCode_Lists
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            int[] res = new int[nums1.Length + nums2.Length];
            int counter = nums1.Length; int j = 0;
            for (int i = 0; i < counter; i++)
            {
                if (!nums2.Contains(nums1[i]))
                    res[j] = nums1[i];
                j++;

                if (i == nums1.Length - 1) { i = 0; counter = nums2.Length; }
                if (counter == nums2.Length)
                    if (!nums1.Contains(nums2[i]))
                        res[j] = nums1[i];
            }
            return res;

        }
    }
}

