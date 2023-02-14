using System;
using Home.Module_3.L6_Seralization_JSON;

namespace Home.Module_3.L6_Serialization_JSON.CRUD_JSON
{
	public class ReadJSON
	{
		public static void ReadJson()
		{
			List<Account> accounts = new();

			accounts = Methods.GetAccounts();

			Console.WriteLine("Reading all items from Json file ... ");
			Console.WriteLine(" \v\t\t All data :");
			accounts.ForEach(x => Console.WriteLine(x));

		}
	}
}

