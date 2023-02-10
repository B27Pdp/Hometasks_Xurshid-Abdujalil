using System;
namespace Home.Module_3.L4_Files_Directory.Hometask
{
	public class Task4
    {   //Ikkita matnli fayl  ichidagilarni birlashtirib
		//uchunchi faylga yozadigan dastur tuzing
        public static void DoTask4()
		{
            DirectoryInfo directory = new("/ Users / jasons_xurshid / Desktop / Github_B27Group / Новая папка 2");
            FileInfo[] arrayFiles = directory.GetFiles();
            
            int index1 = 0;
            foreach (var item in arrayFiles)
            {
                Console.WriteLine(index1 + ". " + item);
            }
            Console.WriteLine("1 -fileni  tanlang: ");
            int file1At = int.Parse(Console.ReadLine());

            Console.WriteLine("1 -fileni  tanlang: ");
            int file2At = int.Parse(Console.ReadLine());

            string fileInfo1;
            string fileInfo2;
            FileInfo fileInfo3=new("MynewFile");
             fileInfo1=File.ReadAllLines(arrayFiles[file1At].FullName).ToString();
             fileInfo2=File.ReadAllLines(arrayFiles[file2At].FullName).ToString();
            File.WriteAllText(fileInfo3.FullName,fileInfo1+fileInfo2);


        }
	}
}

