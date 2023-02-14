using System;
using Home.Module_3.L6_Seralization_JSON;

namespace Home.Module_3.L6_Serialization_JSON.CRUD_JSON;

public class DeleteJSON
{
    public static void DeleteJson()
    {
        string Database_path = Methods.GetDirectory_L6Serialization() + "/database.json";

        List<Account> accounts = new();
        accounts = Methods.GetAccounts();
        if (accounts == null) accounts = new();

        while (true)
        {
            Console.WriteLine("Enter your Login ID : ");

            int? ID = int.Parse(Console.ReadLine());
            bool IDExist = accounts.Any(ac => ac.ID == ID);

            if (!IDExist)
            { Console.WriteLine(" No Account found with this ID [{0}] !!! ", ID); continue; }
            else
            {
                Console.Write("Enter your name :");
                string? name = Console.ReadLine();
                if (name == null) { Console.WriteLine("you didnt enter anything !"); break; }
                accounts.ForEach(x =>
                {
                    if (x.ID == ID & x.Username == name) accounts.Remove(x);
                });
                Console.WriteLine(" Your account has been deleted successfully !!!");
                Methods.SerializeALL(accounts, Database_path);
                break;
            }
            
        }
    }
}
