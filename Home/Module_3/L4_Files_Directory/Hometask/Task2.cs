using System;
namespace Home.Module_3.L4_Files_Directory.Hometask
{
	public class Task2
    {
		//2. Berilgan matnli fayl ichida nechta qator
		//borligini topuvchi dastur tuzing. (Oson)

		public static void DoTask2()
		{
			DirectoryInfo directory1 = new("/Users/jasons_xurshid/Desktop/Github_B27Group/Новая папка 2");
			FileInfo[] file1 = directory1.GetFiles("*.txt");
			
			int linesNum = (File.ReadAllLines(file1[0].ToString())).Count();
			
			Console.WriteLine("lines ="+linesNum);
		}
		public static void MyStream()
		{

		}
	}
}


