using System;
namespace Home.L10_Delegates.Delegates2.Homework
{
	public class Card
	{
		public event EventHandler<EventArgs> OnTransferfrom;
		public delegate void TransferNotification(Card card, int amount);
		public event TransferNotification OnTransferNote;
		public int Id;
		public string Owner;
		public int Balance { get; set; } = 0;
		public CardType Type;
		public Currency currency;

		public Card(CardType type,string owner,int id)
		{ 
			Type = type;
            currency = type == CardType.UZCARD | type == CardType.HUMO? Currency.Sum: currency = Currency.Dollar;
		}


		List<(int, string, int)> Transactions = new();
		public void TransferMoney(Card card,int amount)
		{ 
			try
			{ 
				if (!((card.Type == CardType.UZCARD | card.Type == CardType.HUMO) &&
					(Type == CardType.UZCARD || Type == CardType.HUMO)))
				{ throw (new Exception(" Card types dont match !")); }
				if (amount > Balance) throw (new Exception(" Not enought money on your balance !"));
				Balance -= amount;
				OnTransferNote.Invoke(this, amount);

			}
			catch(Exception ex)
			{
				Console.WriteLine(" Cought Exception ! ");
			}
		}
		public void ReceiveMoney(Card card,int amount)
		{
			Transactions.Add((card.Id, card.Owner, amount));
			card.Balance += amount;
		}

		public void TransactionHistory()
		{
			foreach (var item in Transactions)
			{
				Console.WriteLine(item);
			}
		}

	}
}

