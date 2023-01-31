
namespace L9_Iterator
{
	public class EmptyClass
	{
		public static int a = 1;
		public static  string MyProperty { get; set; }
		public EmptyClass(string name)
		{
		}
		public static void CHangeSt()
		{ a = int.Parse(Console.ReadLine()); }

		static EmptyClass()
		{
			a = 31;
			Console.WriteLine(" a= 31");
		}
	}
	class MyClass : EmptyClass
	{
		public MyClass(string name) : base(name)
		{

		}

		
		public static void STR()
		{
			MyClass my = new MyClass("Asdf");

		MyClass my2 = new("a1122sd");
			MyClass.a = 12;
			MyClass.MyProperty = "ASd";
		}

		
	}
}

