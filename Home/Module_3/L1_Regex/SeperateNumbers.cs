using System;
using System.Text.RegularExpressions;

namespace Home.Module_3.L1_Regex
{
	public class SeperateNumbers
	{ static void SeparateNumbers()
		{
			Console.Write(" Satrni kiriting :");
			string str = Console.ReadLine();
			string[] arr=Regex.Split(str, "\\d");
			str=arr.ToString();
			Console.WriteLine(str);
		}

		public SeperateNumbers()
		{
		}
	}
}

