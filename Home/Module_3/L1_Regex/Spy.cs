using System;
namespace Home.Module_3.L1_Regex
{
	public class Spy
	{
		public event EventHandler<Money> OnTaskDone;
		public string Spyname { get; init; } = "Spy007";

		public void DoTheTask(object? sender,TaskDetails taskDetails)
		{
			Console.WriteLine("Sender : "+sender+ "\nTarget name : "+taskDetails.TargetName+"\tMessage : "+taskDetails.Message);
			Console.WriteLine(" Given task has successfully completed !");

			Console.Write("Enter the amount :");
			long amount = long.Parse(Console.ReadLine());
			Money money = new() { Amount = amount };

			OnTaskDone += TakeMoney;
			OnTaskDone.Invoke(this,money );
			//OnTaskDone -= TakeMoney;

		}

		public void TakeMoney(object sender,Money money)
		{
			Console.WriteLine(" Money Transferred : {0}\t to : {1} ({2})", money.Amount,money.SpyCard, ((Spy)sender).Spyname);			
		}
		
	
	}
	public class Money:EventArgs
	{
		public string SpyCard { get; set; } = "8600770088996633";

        public long Amount { get; set; }
	}
}

