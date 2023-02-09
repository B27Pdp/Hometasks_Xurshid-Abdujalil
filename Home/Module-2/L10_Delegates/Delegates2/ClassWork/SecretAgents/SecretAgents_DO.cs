using System;
namespace Home.L10_Delegates.Delegates2.ClassWork.SecretAgents
{
	public class SecretAgents_DO
	{
		public static void Do()
		{
			Boss BigBoss = new();
			Assasins assasins1 = new();
			ThirdPerson thirdPerson = new();
			BigBoss.BossOrder += assasins1.DeliverOrder;
			BigBoss.GiveOrder(thirdPerson);
		}
		public SecretAgents_DO()
		{
		}
	}
}

