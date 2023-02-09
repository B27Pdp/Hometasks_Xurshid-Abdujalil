using System;
namespace Home.L10_Delegates.HomeWork
{
	public class TupleMaxMin
	{
		public delegate (int,int) MyTuple(List<int> list);

		List<int> numbers = new() { 12,34,156,12,0,170,111,-120};

		public List<int> List
		{
			get => numbers;
			set => numbers = value;
		}


		public static (int,int) GetMaxMin(List<int> ints)
		{ 
			
			return (ints.Max(), ints.Min());
		}

		public TupleMaxMin()
		{
		}
	}
}

