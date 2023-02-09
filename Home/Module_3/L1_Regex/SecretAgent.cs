using System;
namespace Home.Module_3.L1_Regex
{
	public class SecretAgent
	{
		public event EventHandler<TaskDetails> OnTaskGiven;

		public string BossName { get; set; }
		public void GiveTask()
		{
			string sender = this.BossName;
			Console.Write(" Target name :");
			string targetName = Console.ReadLine();
			Console.Write(" Message : ");
			string message = Console.ReadLine();
			TaskDetails taskDetails = new()
			{
				TargetName = targetName,
				Message = message
			};
			OnTaskGiven.Invoke(sender, taskDetails);
		}

		public void GiveMoney(object sender,Money money)
		{
			Console.WriteLine(" Money of amount {0} transfered to {1}",money.Amount,((Spy)sender).Spyname);
		}
		public SecretAgent()
		{
		}
	}

	public class TaskDetails:EventArgs
	{
		public string TargetName { get; set; }
		public string Message { get; set; }
	}
}

