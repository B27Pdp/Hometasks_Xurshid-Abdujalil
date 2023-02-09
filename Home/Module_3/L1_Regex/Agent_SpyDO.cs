using System;
namespace Home.Module_3.L1_Regex
{
	public class Agent_SpyDO
	{	
		public static void DO()
		{
		 SecretAgent Agent = new() { BossName = "Jordan" };
		 Spy Spy = new() { Spyname = "Spy0001" };
			Spy.OnTaskDone += Agent.GiveMoney;
			Agent.OnTaskGiven += Spy.DoTheTask;

			Agent.GiveTask();
		}
	}
}

