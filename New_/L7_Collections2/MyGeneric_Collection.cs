using System;
namespace L7_Collections2
{
	public class MyGeneric_Collection<T,K,U> where T :unmanaged
											 where K: new()
											 where U: class
	{
		public MyGeneric_Collection()
		{
		}


	}


	public class StudentDetails
	{
		public string name;
		public int age;
		public StudentDetails(string name = "DefaultName")
		{
			this.name = name;
		}
		public static void Print_StudentDetails(StudentDetails student)
		{
			Console.WriteLine($"name :{student.name} , age :{student.age} ");
		}
	}
	public interface IMyID
	{
		public StudentDetails ID  { get; set; }
	}
	public struct Group
	{

	}
}

