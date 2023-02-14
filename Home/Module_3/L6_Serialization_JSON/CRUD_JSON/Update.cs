using System;
using Home.Module_3.L6_Seralization_JSON;

namespace Home.Module_3.L6_Serialization_JSON.CRUD_JSON
{
	public class UpdateJson
	{
		public static void UpdaterJson()
		{
            string Database_path = Methods.GetDirectory_L6Serialization() + "/database.json";

            List<Account> accounts = new();
            accounts = Methods.GetAccounts();
            if (accounts == null) accounts = new();
            while (true)
            {
                Console.WriteLine("Enter your Login ID : ");

                int ID = int.Parse(Console.ReadLine());
                bool IDExist = accounts.Any(ac => ac.ID == ID);
                string newName="";
                if (!IDExist)
                { Console.WriteLine(" No Account found with this ID [{0}] !!! ", ID); continue; }
                else
                {
                    Console.WriteLine(" Choose the update option you want to do :" +
                        "\n1.Update name." +
                        "\n2.Update ID" +
                        "\n3. Press any key to Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("New name : "); newName = Console.ReadLine(); break;

                            }
                        case 2:
                            {
                                Console.WriteLine("You cannot change your ID !)"); break;
                            }
                        default: Console.WriteLine(" Thanks for using ! "); break;
                    }
                    accounts.ForEach(x =>
                    { if (x.ID == ID) x.Username = newName; });

                    Console.WriteLine(" Your profile data has been changed successfully !");

                    break;
                }
                Methods.SerializeALL(accounts, Database_path);
                Console.WriteLine(" Updated successfully !");
            }

        }
    }
}

