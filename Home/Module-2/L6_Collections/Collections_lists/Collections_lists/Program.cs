using System.Collections;
using System.Diagnostics.Metrics;
using Collections_lists;

namespace Program
{
    public class Program
    {
        public static void Main_L6(string[] args)
        {
            Queue values1 = new();
            Queue values2 = new();
           int[] array = { 1,12,3,4,5,5,5};
            values1.Clear();
            values1.Clone();
            Console.WriteLine(values1.Contains("Art"));
            values1.Enqueue(123);
            
            Console.WriteLine(values1.Peek());
            values1.Dequeue();
            values1.Enqueue(123);
            values1.Enqueue(" Dsd");
            Console.WriteLine(values1.Peek());
            values1.Enqueue('a');
            Console.WriteLine(values1.Peek());
            values1.CopyTo(array, 0);
            Console.WriteLine(values1);
            Stack stack = new();
            Stack<int> ints = new();
            ints.CopyTo(array, 1);
            MyStack myStack = new();
            MyQueue myQueue = new();
            
        }
    }

    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        { int[] res = new int[nums1.Length+nums2.Length];
            //int counter = nums1.Length;int j = 0;
            //for (int i = 0; i < counter; i++)
            //{
            //    if (!nums2.Contains(nums1[i]))
            //        res[j] = nums1[i];
            //    j++;

            //    if (i == nums1.Length - 1){ i = 0; counter = nums2.Length; }
            //    if(counter==nums2.Length)
            //        if (!nums1.Contains(nums2[i]))
            //            res[j] = nums1[i];
            //}
            res = (int[])nums2.Intersect(nums1);
            res = (int[])nums1.Intersect(nums2);
            return res;

        }
    }



}