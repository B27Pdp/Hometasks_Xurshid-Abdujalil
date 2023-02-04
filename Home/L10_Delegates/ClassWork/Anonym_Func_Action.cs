using System;
namespace Home.L10_Delegates.ClassWork
{
	public class Anonym_Func_Action
	{
		public static void Function()
		{
			Func<string> func = MyVoid2;
			Func<int> func1 = () =>
			{
				Console.WriteLine("this is function with no parametr");
				return 2;
			};
			
				Func<int, string> myFunc = integer => { return "ASd"; };
			Func<int, string, (string, int)> myfunc2 = (phone, name) =>
			{
				var T = (name: name, phone: phone);
				return T;
			};
			Action asd ;

		}

		public static string MyVoid2()
		{
			Console.WriteLine(" This is my Void !");
			return " MyVoid returned";

        }
		public Anonym_Func_Action()
		{
		}
	}
}

