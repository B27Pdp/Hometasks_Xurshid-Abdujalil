using System;
namespace CollectionsDemo
{
	public class List_Task2
	{
       

        public List_Task2()
        {

        }
        public static void Do()
        {
            List<int> nums = new List<int>();

            Console.Write(" Nechta element kiritmoqchisiz ?\n Number :");
            int element_nums = int.Parse(Console.ReadLine());

            for (int i = 0; i < element_nums; i++)
            { nums.Add(int.Parse(Console.ReadLine())); }
        }


	}
}

