using System;
namespace Home.Module_3.L6_Serialization_JSON.CRUD_JSON
{
	public class CRUD_JSON
	{
		public static void CRUD_JSONRunner()
		{
            bool isRun = true;
            
            while (isRun)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                
                Console.WriteLine(" Choose the update option you want to do :" +
                                        "\n1.Create " +
                                        "\n2.Read " +
                                        "\n3.Update " +
                                        "\n4.Delete " +
                                        "\n5. Exit ! (or any key to finish)");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:CreateJSON.CreatorJson();break;
                    case 2:ReadJSON.ReadJson();break;
                    case 3:UpdateJson.UpdaterJson();break;
                    case 4:DeleteJSON.DeleteJson();break;
                    case 5:isRun = false; break;

                    default:  break;
                }

                Console.Beep(3, 12);
                Console.Clear();
            }
            Console.WriteLine(" Thanks for using our service !!!");
        }
	}
}

