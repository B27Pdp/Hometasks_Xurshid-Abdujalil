using System;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Home.Module_3.L6_Seralization_JSON
{
	public class JsonExampleClass
	{
		public static void Run()
		{
			/*Account account = new() { ID = 1111, Username = "Name1", balance = 1000 };
			List<Account> accounts = new();

			string AccountsJson = JsonConvert.SerializeObject(account, Formatting.Indented);

			string filePath = Directory.GetCurrentDirectory();
			DirectoryInfo dirIn = new DirectoryInfo(filePath).Parent.Parent.Parent;
			string path = dirIn.FullName + "/Module_3/L6_Serialization_JSON/jsonFile.json";

			using (StreamWriter write = new(path))
			{
				write.Write(AccountsJson);
			}



			Account account1 = JsonConvert.DeserializeObject<Account>(AccountsJson);
			Console.WriteLine("ID:" + account1.ID);
			*/


		}
	}
}

