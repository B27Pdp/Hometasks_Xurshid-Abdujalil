using System;
namespace Home.L10_Delegates.Delegates2.ClassWork.SecretAgents
{
	public class ThirdPerson
	{
		public void Method1( object? sender,EventArgs eventArgs)
		{
			Console.WriteLine("  It is Method 1");
		}

		public void Method2(object? sender, EventArgs eventArgs)
		{
			Console.WriteLine("  It is Method 2");
		}

		public void Method3(object? sender,EventArgs eventArgs )
		{
			Console.WriteLine("  It is Method 3");
		}

		public void Method4(object? sender,EventArgs eventArgs )
		{
			Console.WriteLine("  It is Method 4");
		}
		
	}
}

