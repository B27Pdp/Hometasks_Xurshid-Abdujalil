using System;
namespace Home.L10_Delegates.Delegates2.Homework
{
	public class CardDO
	{
			public static List<Card> cards = new();
		public static void DO()
		{
			Card UserCard1 = new(CardType.HUMO,    "Abdulatif",57071921);
			Card UserCard2 = new(CardType.UZCARD,  "Ulugbek",  57071922);
			Card UserCard3 = new(CardType.VISA,    "Xushid",   57071923);
			Card UserCard4 = new(CardType.UNIONPAY,"Jamshid",  57071924);
            cards.Add(UserCard1);   cards.Add(UserCard2);
			cards.Add(UserCard3);   cards.Add(UserCard4); 
            UserCard1.OnTransferNote += UserCard2.ReceiveMoney;

			while (true)
			{
				Console.Write(" Enter your User name : ");
				string? sendername = Console.ReadLine();
				var user = cards.Find(x => x.Owner == sendername);
				if (user == null) Console.WriteLine(" No such username "); continue;
				
			}

		}
		public static void Menu()
		{
			Console.WriteLine(" \t\t Main Menu : \n1.UsersList \n2.Transfer Money \n0.Exit");
			int choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1: CardDO.CardList();break;
				case 2: CardDO.CardList();break;
				default:
					break;
			}
		}

		public static void CardList()
		{
			foreach (var item in cards)
			{
				Console.WriteLine(item);
			}
		}

	}
}

