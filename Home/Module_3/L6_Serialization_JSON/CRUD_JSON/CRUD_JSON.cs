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
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                
                Console.WriteLine(" Choose the update option you want to do :" +
                                        "\n1.Create " +
                                        "\n2.Read " +
                                        "\n3.Update " +
                                        "\n4.Delete " +
                                        "\n5. Exit ! (or any key to finish)");
                int counter = 3;
                int? choice=0;
                while (counter != 0)
                {
                     choice = int.Parse(Console.ReadLine());
                    if (choice == null) { Console.WriteLine(" Nothing entered !!! \v Enter corresponding key to continue"); continue; }
                    
                    counter--;
                    if (counter == 0) Console.WriteLine(" You have tried 3 times !!!");

                }
                switch (choice)
                {
                    case 1:CreateJSON.CreatorJson();break;
                    case 2:ReadJSON.ReadJson();break;
                    case 3:UpdateJson.UpdaterJson();break;
                    case 4:DeleteJSON.DeleteJson();break;
                    case 5:isRun = false; break;

                    default: isRun = false; break;
                }

                //Console.Beep(3, 122);
                Thread.Sleep(3000);
                Console.Clear();
            }
            Console.WriteLine(" Thanks for using our service !!!");
        }
	}
}

