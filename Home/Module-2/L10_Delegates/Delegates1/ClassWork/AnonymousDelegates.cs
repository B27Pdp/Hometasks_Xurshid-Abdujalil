using System;
namespace Home.L10_Delegates.ClassWork
{
	public class AnonymousDelegates
	{
		public delegate bool SmsServicePointer(int phone);
		public delegate bool AnonymousDel();
		public delegate void AnonymousDelAll(AnonymousDel del1,SmsServicePointer del2);
	    public static AnonymousDel del1 = Run;
        public static SmsServicePointer del2 = Run2;


        public static void AnonymMain()
		{
			AnonymousDel del = (delegate ()
			{ Console.WriteLine("this is anon");return true; });
			del.Invoke();
		del1.Invoke();
			del2.Invoke(905046484);
	
		}
		public static bool Run()
		{
			SmsServicePointer smsServicePointer = new SmsServicePointer(delegate (int phone)  //	1	 //
			{
				Console.WriteLine("This is anonymous method");
				return true;
			});
			// we can just write the body of the function with delegate without defining method's name
			// That's why is anonymous delegate !
			bool res=smsServicePointer(905046484);
			if (res) Console.WriteLine("Message sent to {0} ",smsServicePointer.Target); 

			SmsServicePointer  smsServicePointer2 = (phone) =>
			{ Console.WriteLine("This is anonymous with labda expression!"); return true; };

			res=smsServicePointer2(979295577);
			Console.WriteLine();

			SmsServicePointer smsServicePointer3 = Run2;
			smsServicePointer3(905046484);  return true;
        }

		public static bool Run2(int number)
		{
			Console.WriteLine("This is regular method");
			if (number == 905046484) { Console.WriteLine("You found my phone!"); return true; }
				else  {Console.WriteLine("  This is not my phone "); return false; }
		}





	}
}

