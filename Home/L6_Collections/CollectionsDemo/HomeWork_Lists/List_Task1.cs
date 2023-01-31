using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsDemo.Homework_Lists
{
	public class List_Task1
	{
        public List_Task1()
        {
        }

        public static void Do()
        {
            List<int> nums = new List<int>()
            {12, 3, 34, 56, 11, 32, 45, 11, 43};
            //[12, 3, 34, 56, 11, 32, 45, 11, 43]

            List<int> evennums = new();
            nums.ForEach(x => { if (x % 2 == 0) evennums.Add(x); });
            int max = evennums.Max();
            Console.WriteLine($" Maximum even number is {max}");
        }
	}

	
}

