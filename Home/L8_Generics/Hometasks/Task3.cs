//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography;

//namespace L8_Generics.Hometasks
//{
//	public class Task3
//	{

//	}


//	public class TripleDictionary<T, U, V> where T : class
//										 where U : class, IPerson<int>
//										 where V : Person<T>
//	{
//		public T? Tprop1 { get; set; }
//		public U? Uprop2 { get; set; }
//		public V? Vprop3 { get; set; }
//		public TripleDictionary(T tProp1, U uProp2, V vProp3)
//		{
//			Dictionary<string, int> ad = new();
//			List<int> ints = new() { 1, 123, 234, 3, 0, 13 };
//			Tprop1 = tProp1;
//			Uprop2 = uProp2;
//			Vprop3 = vProp3;
//		}

//		static List<T> T_list;
//		static List<(U, V)> U_V_List;
//		public static List<TripleDictionary<T, U, V>> Add(TripleDictionary<T, U, V> Tdict)
//		{
//			T_list.Add(Tdict.Tprop1);
//			return null;
//		}


//		public static T OrderBy(T collection)
//		{
//			return collection;
//		}

//		public void OrderByDesc() { }
//	}

//}

//	public interface IPerson<TId>
//					where TId : struct
//	{ 
//		public TId Id { get; set; }
//		public byte Age { get; set; }
//		public string Name { get; set; }
//	}

//public class Person : IPerson<int>
//{
//	private int ID;
//	public int Id { get => ID; set => ID = value; }
//	public byte Age { get => 20; set => throw new NotImplementedException(); }
//	public string Name { get => "Jack"; set => throw new NotImplementedException(); }

//}


