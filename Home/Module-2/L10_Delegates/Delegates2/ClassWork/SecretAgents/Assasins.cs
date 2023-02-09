using System;
namespace Home.L10_Delegates.Delegates2.ClassWork.SecretAgents
{
	public class Assasins
	{

		public void DeliverOrder(object? sender,EventHandler eventHandler)
		{
			Console.WriteLine(	" Assasin has completed the task !");
			eventHandler.Invoke(sender, new EventArgs()); 
		}
		public Assasins()
		{
		}
	}
}

