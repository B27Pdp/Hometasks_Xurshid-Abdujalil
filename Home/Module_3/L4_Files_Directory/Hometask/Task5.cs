using System;
using System.Linq;

namespace Home.Module_3.L4_Files_Directory.Hometask
{
	public class Task5
	{
        //Berilgan papka ichidagi file va papkalarni nomida
		//qidirilayotgan matn bor bo’lgan fayl va papkalarni
		//ekranga chiqazish dasturini tuzing. Bunda berilgan
		//papka ichida papkalar bor bo’lsa ularni ichidan ham
		//qidirish kerak (Rekursiyadan foydalaniladi). (Qiyin)
        public static void DoTask5()
		{
          string newFolerPath = @"/Users/jasons_xurshid/Desktop/Github_B27Group/Новая папка 2";

            DirectoryInfo NewFoler = new DirectoryInfo(newFolerPath);

			Console.Write(" Matnni kiriting : ");
			string find = Console.ReadLine();

            List<FileSystemInfo> AllFilesList =
					NewFoler.GetFileSystemInfos($"*{find}*", SearchOption.AllDirectories).ToList();
			
			Console.WriteLine($" Nomida ushbu {find} matni bor bo'lgan barcha fayllar va Papkalar : ");
			AllFilesList.ForEach(x => Console.WriteLine("   " + x + " "));

        }
	}
}

