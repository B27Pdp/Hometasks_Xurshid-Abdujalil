using System;
using Home.Module_3.L6_Seralization_JSON;
using Newtonsoft.Json;

namespace Home.Module_3.L6_Serialization_JSON.CRUD_JSON
{
	public static class Methods
	{
		public static string GetDirectory_L6Serialization()
		  {
			return   (new DirectoryInfo(Directory.GetCurrentDirectory())
			  .Parent?.Parent?.Parent?.FullName + "/Module_3/L6_Serialization_JSON"); 
		  }

		public static List<Account> GetAccounts()
		{  string JsonFilePath= GetDirectory_L6Serialization() + "/database.json";
			List<Account>? accounts = new();

			using (StreamReader reader = new StreamReader(JsonFilePath))
			{ string JsonString=reader.ReadToEnd();
				accounts = JsonConvert.DeserializeObject<List<Account>>(JsonString);
			}
			return accounts;
        }

        public static void SerializeALL(List<Account> accounts, string path)
        {
            using (StreamWriter write = new StreamWriter(path))
            {
                string list = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                write.WriteLine(list);
            }
        }
    }
}

