using System;
namespace Home.L10_Delegates.Delegates2.ClassWork
{
	public class Publisher
	{
        private string? name;
        public string? Name
        {
            get => name;
            init
            {
                if (value == null) Console.WriteLine("Name cannot be null !!! ");
                else name = value;
            }
        }

        public Publisher(string name)
		{
			Name = name;
		}

        public delegate void PublisherDel(object sender, string smsMessage);
		public event PublisherDel? OnClickSendSMS;
		

        public List<(object?, string)> ReceivedMessages = new();
        public  void SendSMS(string smsMessage)
		{
			smsMessage ??= "No text";
			OnClickSendSMS?.Invoke(name, smsMessage);
            Console.WriteLine("\t\t Message sent Successfully !\t");
			Console.WriteLine(" Message :{0} ;\nSent from :{1}",smsMessage,(name));
			ReceivedMessages.Add((name, smsMessage));
		}

        public void OnClickGetSMS(object sender, string smsMessage)
        {
            ReceivedMessages.Add((sender, smsMessage));
        }

        public void ShowAllMessages()
        {
            Console.WriteLine("All messages :");
            foreach (var item in ReceivedMessages)
            { Console.WriteLine(item); }
        }
    }
}

