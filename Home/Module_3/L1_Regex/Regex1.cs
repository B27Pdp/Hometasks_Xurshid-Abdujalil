using System;
using System.Text.RegularExpressions;

namespace Home.Module_3.L1_Regex
{
	public class Regex1
	{
		public static void RegexDo()
		{


			//Agent_SpyDO.DO();
			//while (true)
			//{
			Console.Write(" Enter email :");
			string? str = Console.ReadLine();
				Console.WriteLine(Regex.IsMatch(str, @"[a-zA-Z\d_.]+[^.]@[a-z].[a-z]"));

			//	//Console.WriteLine(Regex.IsMatch(str, @"[^abc]"));
			//	//[^abc] faqat shulardan iborat bolsa false ,boshqa birorta bolsa true;

			//	//Console.WriteLine(Regex.IsMatch(str, "[abc]"));
			//}
		}
		public Regex1()
		{
		}
	}
}

