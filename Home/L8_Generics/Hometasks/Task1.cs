using System;
namespace L8_Generics.Hometasks
{
	public class Task1
	{

        public static void PrintDictionary<T, K>(Dictionary<T, K> dc)
        {
            foreach (var item in dc)
            {
                Console.WriteLine("Key : {0} , Value : {1}", item.Key, item.Value);
            }
        }

    }
}

