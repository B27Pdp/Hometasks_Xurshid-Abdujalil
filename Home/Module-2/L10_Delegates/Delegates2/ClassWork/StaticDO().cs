using System;
namespace Home.L10_Delegates.Delegates2.ClassWork
{
    public class StaticDO__
    {
        public static void DO()
        {
            var users = new
            {
                name1 = "Tashkent",
                name2 = "Samarkand",
                name3 = "Sattelite Echo",
                name4 = "Sattelite Vozdux"
            };
            List<string> userList = new()
            {
                "Tashkent",
                "Samarkand",
                "Sattelite Echo",
                "Sattelite Vozdux"
            };
            List<Publisher> objList = new();
            Publisher Earth1 = new(users.name1); objList.Add(Earth1);
            Publisher Earth2 = new(users.name2); objList.Add(Earth2);
            Publisher Sattelite1 = new(users.name3); objList.Add(Sattelite1);
            Publisher Sattelite2 = new(users.name3); objList.Add(Sattelite2);

            Earth1.OnClickSendSMS += Sattelite1.OnClickGetSMS;
            Console.WriteLine(" Available users :  \n1.{0} ,\n2.{1} ,\n3.{2} ,\n4.{3} "
                , users.name1, users.name2, users.name3, users.name4);

            while (true)
            {
                Console.Write(" Enter your user name :");
                bool isNotUser = true;
                string? username = "";
                while (isNotUser)
                {
                    username = Console.ReadLine();

                    if (username == null)
                    {
                        Console.WriteLine(" Username can't be null !!! \v Enter the correct user name :");
                        continue;
                    }
                    if (userList.Contains(username))
                    { isNotUser = false; }
                    else
                    {
                        Console.WriteLine("Username not found !!!");
                        Console.Write("Want to add a new user ? Press 1 if yes :");
                        byte? confirm = byte.Parse(Console.ReadLine());
                        if (confirm == 1)
                        {
                            Console.WriteLine("Enter the user's name");
                            username = Console.ReadLine();
                            userList.Add(username);
                            Publisher NewEarth = new(username);
                            objList.Add(NewEarth);
                        }
                    }
                }

                while (true)
                {
                    Console.WriteLine(" Choose whom to send a message : ");
                    foreach (var item in userList)
                    {
                        if (item == username) continue;
                        Console.WriteLine(userList.IndexOf(item) + "." + item);
                    }

                    byte receiverIndex=0;

                        try
                        {
                            receiverIndex = byte.Parse(Console.ReadLine());
                            //if (Exception.Equals == null) break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(" Wrong input ,Enter the correct format !");
                        }
                        finally 
                            { }
                    

                    byte userIndex = (byte)userList.IndexOf(username);
                    string receiverName = userList[receiverIndex];
                    objList[userIndex].OnClickSendSMS += objList[receiverIndex].OnClickGetSMS;
                    while (true)
                    {
                        Console.WriteLine(" Enter the text : ");
                        string? message = Console.ReadLine();
                        objList[userIndex].SendSMS(message);

                        Console.WriteLine("Wanna send another message ?\n Type yes to send another message ,or type anything to stop :");
                        string a1 = Console.ReadLine();
                        if (a1 == "Yes") continue;
                        else break;
                    }
                    Console.WriteLine(" Want to send a message to any other user  ? \n Type yes to send a message ," +
                        "\n or type anything to stop :");
                        string a2 = Console.ReadLine();
                    Console.Clear();
                        if (a2 == "Yes") continue;
                        else break;
                }
                Console.WriteLine(" Thanks ! ! ! \n\t Bye - Bye !");
            }

            object? FindUser(string username)
            {
                if (username == Earth1.Name) return Earth1;
                if (username == Earth2.Name) return Earth2;
                if (username == Sattelite1.Name) return Sattelite1;
                if (username == Sattelite2.Name) return Sattelite2;
                else return null;
            }




        }


    }
}

