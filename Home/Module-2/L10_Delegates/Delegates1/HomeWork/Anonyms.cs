using System;
namespace Home.L10_Delegates.HomeWork
{
	public partial class Anonyms
	{
		public delegate void Mydel();
		

		public  static void AnonymHome()
		{

			Mydel mydel = PrintHi;
			mydel.Invoke();
			Mydel mydel1 =(delegate ()
			{ Console.WriteLine("THIS IS ANONYM DELEGATE");});
			Mydel mydel2 = () => Console.WriteLine("This is Lambda Expression1");



		}
		
		public Anonyms()
		{
		}

		static void PrintHi()
		{
			Console.WriteLine(" Hi ,how are you doing !");
		}

	
	}

	public partial class Anonyms
	{
		public static void AnonymAction()
		{
			Action action = () => Console.WriteLine(" Hi this is anonymous action delegate !");
			action += PrintHi;
			action.Invoke();
		}



	}
}

