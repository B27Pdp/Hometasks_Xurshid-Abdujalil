using System;
namespace Home.Module_3.L4_Files_Directory.Hometask
{
	public class Task3
	{
        //3. Berilgan fayl(ixtiyoriy formatdagi)dan
        //nusxa oluvchi dastur tuzing. (Oson)
        public static  void DoTask3()
        {
            DirectoryInfo directory=new("/ Users / jasons_xurshid / Desktop / Github_B27Group / Новая папка 2");
            FileSystemInfo fileSystemInfo;
            FileSystemInfo[] arrayFiles = directory.GetFileSystemInfos();
            Console.WriteLine("Elementni tanlang: ");
            int index1 = 0;
            foreach (var item in arrayFiles)
            {
                Console.WriteLine(index1+". "+item);
            }
            int fileAt = int.Parse(Console.ReadLine());

            fileSystemInfo = arrayFiles[fileAt];
            File.Copy(fileSystemInfo.Name,directory.FullName);
            Console.WriteLine(" File has been copied Successfully !");

            
            

        }

    }
}

