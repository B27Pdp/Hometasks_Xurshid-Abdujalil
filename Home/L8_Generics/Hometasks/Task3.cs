using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace L8_Generics.Hometasks
{
	public class Task3
	{

	}


	public class TripleDictionary<T,U,V> where T :class
										 where U :class,IPerson<int>
										 where V :Person
	{
		public T myprop1 { get; set; }
		public U myprop2 { get; set; }
		public V myprop3 { get; set; }
		public TripleDictionary()
		{
			
		}

		//public static List<T> OrderBy(TripleDictionary<T,U,V> tripleDictionary)
		//{
  //          List < T > list= new();
		//	for (int i = 0;i<number ; i++)
		//	{
		//		list.AddRange(tripleDictionary[T]);
		//	}
  //          return list;
		//}
		public void OrderBy() { }
		public void OrderByDesc() { }

		public void PrintElements()
		{ Console.WriteLine("Something here"); }
	}

	public interface IPerson<TId>
					where TId : unmanaged
	{ 
		public TId Id { get; set; }
		public byte Age { get; set; }
		public string Name { get; set; }
	}

    public class Person : IPerson<int>
    { private int ID;
        int IPerson<int>.Id { get => 1122; set=>ID=value; }
        byte IPerson<int>.Age { get => 20; set => throw new NotImplementedException(); }
        string IPerson<int>.Name { get => "Jack"; set => throw new NotImplementedException(); }
    }
}

