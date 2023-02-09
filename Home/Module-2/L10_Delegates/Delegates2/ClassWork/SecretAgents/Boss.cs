using System;
namespace Home.L10_Delegates.Delegates2.ClassWork.SecretAgents
{
	public class Boss
	{
		public string Name { get; private set; } = " Kotta Xo'jayin";
		public event EventHandler<EventHandler> BossOrder;
		public event EventHandler NextOrder;
		public void GiveOrder(ThirdPerson thirdPerson1)
		{
			NextOrder += thirdPerson1.Method1;
			NextOrder += thirdPerson1.Method2;
			NextOrder += thirdPerson1.Method3;
			Console.WriteLine(	" Boss gave an order");
			BossOrder.Invoke(this, NextOrder);
		}


		public Boss()
		{
		}
	}
}

