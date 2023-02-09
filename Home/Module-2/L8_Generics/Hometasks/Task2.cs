using System;
namespace L8_Generics.Hometasks
{
	public class Task2
	{
        public static T GetLastElement<T>(T[] array)
        {
            return array[array.Length - 1];
        }

    }
}

