using System;
namespace Home.L10_Delegates.HomeWork
{
	public class Mathematics<T> where T:struct
	{
		
		public static void Sum(T a,T b)
		{	
			Console.WriteLine("{0} va {1} sonlarining yig'indisi = {2} ",a,b,(dynamic?)a+b);
		}

		public static void Substract(T a,T b)
		{
			Console.WriteLine("{0} va {1} sonlarining ayirmasi = {2} ",a,b, (dynamic?)a -b);
		}

		public static void Multiply(T a,T b)
		{
			Console.WriteLine("{0} va {1} sonlarining ko'paytmasi = {2} ",a,b, (dynamic?)a *b);
		}

		public static void Devide(T a,T b)
		{
			Console.WriteLine("{0} va {1} sonlarining bo'linmasi = {2} ",a,b, (dynamic?)a/b);
		}

       
        public Mathematics()
		{
		}
	}
}

