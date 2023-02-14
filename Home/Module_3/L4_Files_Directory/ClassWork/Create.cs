using System;
using System.Linq;

namespace Home.Module_3.L4_Files_Directory.ClassWork
{
	public class Create
	{

		public static void CreateFile()
		{
			DirectoryInfo? fileDirectory = new(Directory.GetCurrentDirectory());
			fileDirectory = fileDirectory.Parent?.Parent?.Parent;
			fileDirectory = new(fileDirectory.FullName + "/Module_3/L4_Files_Directory/NewFoldercha/mynewFolder");
			Directory.CreateDirectory(fileDirectory.FullName);

			string filePath = fileDirectory.FullName + "/textfile2.txt";
			Console.WriteLine(filePath);
			List<Person> peoples = new();
			using (StreamWriter writer = File.AppendText(filePath))
			{
				try
				{
					Console.Write(" Your name :");
					string name = Console.ReadLine();

					Console.Write(" Phone number :");
					string phone = Console.ReadLine();
					
					peoples.Add(new Person
					{
						ID = Guid.NewGuid(),
						Name = name,
						PhoneNumber = phone
					});
				}
				catch (Exception ex)
				{
					Console.WriteLine(" Wrong input : "+ex.Message);
				}
				peoples.ForEach(x => writer.WriteLine(x));
			
			}

			//List<DirectoryInfo> dirs = fileDirectory.GetDirectories("*", SearchOption.TopDirectoryOnly).ToList();
			//Console.WriteLine(" The number of directories ="+dirs.Count);
			//	dirs.ForEach(x => Console.WriteLine(x));
			
			
		
		}
	}
}

