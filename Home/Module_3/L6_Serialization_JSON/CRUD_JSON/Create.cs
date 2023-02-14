using System;
using System.Text.Json;
using Home.Module_3.L6_Seralization_JSON;
using Newtonsoft.Json;

namespace Home.Module_3.L6_Serialization_JSON.CRUD_JSON
{
	public class CreateJSON
	{
		public static void CreatorJson()
		{
            string Database_path = Methods.GetDirectory_L6Serialization()+"/database.json";
            
            List<Account> accounts = new();
            Account newAccount=new();

            accounts = Methods.GetAccounts();
            if (accounts == null) accounts = new();
            
            while (true)
            {
                Console.Write("Create your Login ID : ");

                int ID = int.Parse(Console.ReadLine());
                bool IDExist = accounts.Any(ac => ac.ID == ID);
                if (IDExist) Console.WriteLine(" Account with this ID [{0}] already exists!!! ", ID);
            else
                {
                    Console.Write(" Enter your name :");
                    string? userName = Console.ReadLine();
                    newAccount = new() { ID = ID, Username = userName, balance = 1500 };
                    Console.WriteLine("Your account has been created successfully  ");
                    Console.WriteLine("Account info :"+newAccount);
                    accounts.Add(newAccount);
                    break;
                }
            }
           
            Methods.SerializeALL(accounts, Database_path);

        }
     
    }
}

