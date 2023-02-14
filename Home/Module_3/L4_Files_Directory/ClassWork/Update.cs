using System;
namespace Home.Module_3.L4_Files_Directory.ClassWork
{
	public class Update
	{
		public static void UpdateFile()
		{
            DirectoryInfo directory = new("/Users/jasons_xurshid/Desktop/Github_B27Group/Xurshid-Abdujalil/Home/Module_3/L4_Files_Directory/NewFoldercha/mynewFolder");
            List<Person> people = new();

            FileInfo dataFile = new(directory.FullName + "/textfile2.txt");
			Console.WriteLine(" To change your data ,please enter your name and phone number :");
			Console.Write(" Name : "); string? name = Console.ReadLine();
			Console.Write(" Phone number : "); string? phone = Console.ReadLine();

			List<string> userdata = new();
			using (StreamReader read = new StreamReader(dataFile.FullName))
			{ string line;
				while( (line=read.ReadLine())!=null)
				{ userdata.Add(line); }
			}
			

			if (userdata.Any(item=>item.Contains(name)&item.Contains(phone)))
			{		userdata.RemoveAll(item => item.Contains(name) & item.Contains(phone));	

				using (StreamWriter write = new(dataFile.FullName))
				{
					Console.WriteLine(" Which data you want to change : \n1.Only Name . \n2.Only phone  number. \n3.Both phone and name .\n Or press any number to cancel changing ");
					int choice = int.Parse(Console.ReadLine());
					switch (choice)
					{
						case 1:
							{
								Console.Write("New name :");
								name = Console.ReadLine(); break;
							}
						case 2:
							{
								Console.Write("New phone number : ");
								phone = Console.ReadLine(); break;
							}
						case 3:
							{
								Console.Write("New name : ");
								name = Console.ReadLine();
								Console.Write("New number : ");
                                phone = Console.ReadLine();
                                break;
							}

						default: Console.WriteLine(" Nothing changed !"); break;
					}
					userdata.Add((new Person { Name = name, PhoneNumber = phone, ID = Guid.NewGuid() }).ToString());
					userdata.ForEach(line => write.WriteLine(line));

					Console.WriteLine(" changes saved successfully !!! ");
				}
			}
			else Console.WriteLine(" User not found !!! ");

		}
	}
}

