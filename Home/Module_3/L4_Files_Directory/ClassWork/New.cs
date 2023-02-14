using System;
namespace Home.Module_3.L4_Files_Directory.ClassWork
{
	public class New
	{
		public static void DoNew()
		{
			DirectoryInfo directory = new(Directory.GetCurrentDirectory());
			Console.WriteLine(directory);
			directory = directory.Parent?.Parent?.Parent;
			Console.WriteLine(directory);
			directory = directory.CreateSubdirectory("NewFoldercha");
			Console.WriteLine(directory);
			List<Person> people = new();
			for (int i = 0; i < 3; i++)
			{
			people.Add(
							new Person
							{
								ID = Guid.Parse(Guid.NewGuid().ToString("x")),
								Name = " Xolmat-" + i + 1,
								PhoneNumber = "99890100203" + i
							}
					  );
			}
			string filePath = directory.FullName + "/Myfiles.txt";
			//File.Create(filePath);   // created a file with filePath ;

			
			using (StreamWriter writer = File.CreateText(filePath))
			{
				people.ForEach(person =>writer.WriteLine(person));
			}

			List<Person> people1 = new();

			using (StreamReader reader = File.OpenText(filePath))
			{
				
				string person1 = reader.ReadLine();

                #region Name
                int startIndex = person1.IndexOf("Name : ")+ ("Name : ").Length;
				int endIndex = person1.IndexOf(',', startIndex);
				int propLength = endIndex - startIndex;
				
				string name = person1.Substring(startIndex, propLength).Trim();
                #endregion

                #region Phone
                int startIndex2 = person1.IndexOf("Phone : ") + ("Phone : ").Length;
                int endIndex2 = person1.IndexOf(',', startIndex2);
                int propLength2 = endIndex2 - startIndex2;
				
				string phoneNumber = person1.Substring(startIndex2, propLength2).Trim();
				
                #endregion

                #region ID
                int startIndex3 = person1.IndexOf("ID : ") + ("ID : ").Length;
                int endIndex3 = person1.IndexOf('•', startIndex3);
                int propLength3 = endIndex3 - startIndex3;

                Guid id=Guid.Parse(person1.Substring(startIndex3, propLength3).Trim());
				#endregion

				Person person = new() { Name = name, PhoneNumber = phoneNumber, ID = id };
				Console.WriteLine(person);
            }




        }

		public static void DoAll()
		{
			Console.WriteLine();
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public Guid ID { get; set; }

        public override string ToString()
        {
            return $" ••• Name : {Name} , Phone : {PhoneNumber} , ID : {ID}   ••• ";
        }
    }
}