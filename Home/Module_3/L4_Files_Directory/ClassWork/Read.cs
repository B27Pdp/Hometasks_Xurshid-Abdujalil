using System;
namespace Home.Module_3.L4_Files_Directory.ClassWork
{
	public class Read
	{
		public static void ReadFile() {
			DirectoryInfo directory = new("/Users/jasons_xurshid/Desktop/Github_B27Group/Xurshid-Abdujalil/Home/Module_3/L4_Files_Directory/NewFoldercha/mynewFolder");
			List<Person> people = new();

			FileInfo dataFile = new(directory.FullName + "/textfile2.txt");
			using (StreamReader read = new StreamReader(dataFile.FullName))
			{ 
				while (true)
				{ 
				string? person=read.ReadLine();
					if (person == null) break;
				int startIndexName = person.IndexOf("Name :") + ("Name : ").Length;
				int startIndexPhone = person.IndexOf("Phone : ") + ("Phone : ").Length;
				int startIndexID = person.IndexOf("ID : ") + ("ID : ").Length;
					people.Add(new Person
					{
						Name = person.Substring(startIndexName, person.IndexOf(",") - startIndexName).Trim(),
						PhoneNumber = person.Substring(startIndexPhone, person.IndexOf(",",startIndexPhone) - startIndexPhone).Trim(),
						ID = Guid.Parse(person.Substring(person.IndexOf("ID : ")+("ID : ").Length,36).Trim())
					}) ;
				}
				people.ForEach(x => Console.WriteLine(x));

			}


		}
	}
}

