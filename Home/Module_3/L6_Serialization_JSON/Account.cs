using System;
using Newtonsoft.Json;
using System.Text.Json;
namespace Home.Module_3.L6_Seralization_JSON
{
	public class Account
	{
		
		public int ID { get; set; }
		public string Username { get; set; }
		public int balance { get; set; }

        public override string ToString()
        {
            return $"ID: {ID},Username:{Username} ,Balance: {balance}";
        }
      
        public  void Add(Account account)
        {

        }
        public  void AddAccounts(List<Account> accounts)
        {

        }
    }
}

