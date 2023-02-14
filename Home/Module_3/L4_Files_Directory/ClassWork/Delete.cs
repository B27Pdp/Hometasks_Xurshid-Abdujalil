using System;
namespace Home.Module_3.L4_Files_Directory.ClassWork
{
	public class Delete
	{
		public static void Deletefile()
		{
            DirectoryInfo directory = new("/Users/jasons_xurshid/Desktop/Github_B27Group/Xurshid-Abdujalil/Home/Module_3/L4_Files_Directory/NewFoldercha/mynewFolder");
            List<Person> people = new();

            FileInfo dataFile = new(directory.FullName + "/textfile2.txt");
            Console.WriteLine(" To delete your data ,please enter your name and phone number :");
            Console.Write(" Name : "); string? name = Console.ReadLine();
            Console.Write(" Phone number : "); string? phone = Console.ReadLine();

            List<string> userdata = new();
            using (StreamReader read = new StreamReader(dataFile.FullName))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                { userdata.Add(line); }
            }
            List<int> lineNum = new();
            for (int i = 0; i < userdata.Count(); i++)
            {
                if (userdata[i].Contains(name) & userdata[i].Contains(phone)) lineNum.Add(i);
            }

                if (lineNum.Count >= 1)
                {
                    userdata.RemoveAll(item => item.Contains(name) & item.Contains(phone));
                Console.WriteLine(" Your data has been removed successfully !");
                }

            else Console.WriteLine(" No user found with this name and number ");

        }

	}
}

