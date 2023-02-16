using System;
namespace Home.L10_Delegates.Delegates2.Homework
{
	public class CardDO
	{
			public static List<Card> cards = new();
		public static void DO()
		{
			Card UserCard1 = new(CardType.HUMO,    "Abdulatif",22223331);
			Card UserCard2 = new(CardType.UZCARD,  "Ulugbek",  22223332);
			Card UserCard3 = new(CardType.VISA,    "Xushid" ,  22223333);
			Card UserCard4 = new(CardType.UNIONPAY,"Jamshid",  22223334);
            cards.Add(UserCard1);
			cards.Add(UserCard2);
			cards.Add(UserCard3);
			cards.Add(UserCard4);
            //UserCard1.OnTransferNote += UserCard2.ReceiveMoney;
            //UserCard2.OnTransferNote += UserCard1.ReceiveMoney;

			int counter = 3;
			bool isMaxTimes = false;
            Console.Write(" Enter your User name : ");

            while (!isMaxTimes)
			{
				string? sendername = Console.ReadLine();
				if (sendername == "exit") {	  Console.WriteLine("Thank you !!!"); break;	}

				var user = cards.Find(x => x.Owner == sendername);
				
				if (user == null)
				{
					Console.WriteLine(" No such user with this username \v ");
					Console.Write(" Enter the correct username or 'exit' to exit : ");
				}
				else
				{
					while (counter!=0)
					{
						Console.Write(" Enter your ID number :");
						int IdNumber = int.Parse(Console.ReadLine());
						if (user.Id != IdNumber)
						{
							Console.WriteLine(" Username and ID doesnt match");
							counter--;
						}
						else
						{
							Menu(user);
							break;
						}
						if (counter == 0) { isMaxTimes = true; Console.WriteLine(" You have tried max times !!!"); }
						
					}
                }
				
			}

		}

		public static void Menu(Card User)
		{
			Console.WriteLine(" \t\t Main Menu : \n1.UsersList \n2.Transfer Money \n3.My Card info  \n0.Exit");
			int choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1: CardList();break;
				case 2:
					{
						Console.Write("Enter the card ID to transfer to : ");
						int toCardID= int.Parse(Console.ReadLine());
						var receiver=cards.Find(x => x.Id == toCardID);

						Console.Write("Enter the amount");
						int amount = int.Parse(Console.ReadLine());
						TransferMoney(User, receiver,amount);
					} ;break;
				case 3:  User.MyCardInfo();break;
				case 0: 
				default: break;
			}
		}

		public static void CardList()
		{
			Console.WriteLine(" Available cards :");
			foreach (var item in cards)
			{
				Console.WriteLine(item);
			}
		}

		private static void TransferMoney(Card sender,Card receiver,int amount)
		{
			sender.OnTransferNote += receiver.ReceiveMoney;
			sender.TransferMoney(receiver, amount);
			sender.OnTransferNote -= receiver.ReceiveMoney;
		}

       
    }
}

