using System;
using System.Text.RegularExpressions;

namespace Home.Module_3.LeetCode
{
	public class LeetcCode389_Find_the_Difference
	{
		public static void DoLeetCode389()
		{
			string s = Console.ReadLine();
			string t = s;
			
			char[] arr1 = s.ToArray<char>(); Array.Sort(arr1);
			char[] arr2 = t.ToArray<char>(); Array.Sort(arr2);
			char a = arr2[0] ;
			int l = arr2.Length;
            for (int i = 0; i <l; i++)
			{
				if (arr1[i] != arr2[i]) { a = arr2[i]; break; }
				else if (i == l-2) { a = arr2[i + 1]; break; }
			}
			Console.WriteLine(a) ;
			
		
			
		}
		public LeetcCode389_Find_the_Difference()
		{
		}
	}
}

