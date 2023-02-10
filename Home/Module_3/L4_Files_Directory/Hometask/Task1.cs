using System;
using System.IO;

namespace Home.Module_3.L4_Files_Directory.Hometask
{
	public class Task1
	{
		// Berilgan path ga mos papka ichida nimalar borligini aniqlaydigan method tuzing.
		//Method javob sifatida agar path ichida faqat papkalar bo'lsa "Papkalar bor" yozuvi,
		//faqat fayllar bo'lsa "Fayllar bor" yozuvi, papka va fayllar bor bo'lsa
		//"Papka va fayllar bor" yozuvi, aks holda "Papka bo'sh" yozuvi chiqsin. (Oson)
		  static Action<DirectoryInfo> OnDirectoryInfo; 
		public static void DoTask1()
		{
			string newFolerPath = @"/Users/jasons_xurshid/Desktop/Github_B27Group";
			newFolerPath += @"/Новая папка 2";
			DirectoryInfo NewFoler = new DirectoryInfo(newFolerPath);
            #region Attributes
            //Console.WriteLine("NewFoler.Attributes); :	" + NewFoler.Attributes);
            //Console.WriteLine("NewFoler.CreationTime); :	" + NewFoler.CreationTime);
            //Console.WriteLine("NewFoler.CreationTimeUtc); :		" + NewFoler.CreationTimeUtc);
            ////Console.WriteLine("NewFoler.EnumerateDirectories()); :	" +NewFoler.EnumerateDirectories());
            //Console.WriteLine("NewFoler.FullName); :	" + NewFoler.FullName);
            //Console.WriteLine("NewFoler.LastAccessTime); :	" + NewFoler.LastAccessTime);
            //Console.WriteLine("NewFoler.Root); :	" + NewFoler.Root);
            //Console.WriteLine("NewFoler.ToString()); :	" + NewFoler.ToString());
            //DirectoryInfo[] dirs = NewFoler.GetDirectories("*", SearchOption.TopDirectoryOnly);
            //Console.WriteLine(" Top dirs : ");
            //int a = 1;
            //foreach (var d in dirs)
            //{ Console.WriteLine(a + " : " + d.Name); a++; }
            #endregion
            Console.WriteLine(" \t\tBeginning to invoke ShowAll !!! \n\n\n");
			OnDirectoryInfo+= Task1.ShowAll;
			OnDirectoryInfo.Invoke(NewFoler);

		}

		public static void ShowAll(DirectoryInfo directory)
		{	bool isFileInfo = false;
			bool isDirectoryInfo = false;
			bool containsBoth = false;

			FileSystemInfo[] fileSystemInfo= directory.GetFileSystemInfos();
			foreach (FileSystemInfo item in fileSystemInfo)
			{
				if(item is FileInfo) { isFileInfo = true; }
				if(item is DirectoryInfo) { isDirectoryInfo = true; }
				if (isFileInfo && isDirectoryInfo) { containsBoth = true; break; }

			}
			if (containsBoth) Console.WriteLine(" Papka va fayllar ham bor !");
			else if (isFileInfo) Console.WriteLine(" Faqat fayllar bor !");
			else if (isDirectoryInfo) Console.WriteLine(" Faqat Papkalar bor !");
			else Console.WriteLine(" Bo'm bosh ekan !!! "); 
			
		}
	}
}

	


