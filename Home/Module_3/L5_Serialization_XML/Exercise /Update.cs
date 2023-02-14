using System;
namespace Home.Module_3.L5_Serialization_XML.Exercise
{
	public class Update
	{
		public static Func<List<Student>> GetList;
		public static void Updater()
		{
			List<Student> Group = new();
			GetList += Read.Reader;
			Group = GetList.Invoke();
			Console.WriteLine("To update your profile we need to confirm your Identity !");
			Console.Write(" Please write your number : "); string? number = Console.ReadLine();

			if (Methods.IsvalidNumber(number))
			{
                Console.WriteLine(" Enter your name and ID to update your profile info");
                Console.Write("Name : "); string name = Console.ReadLine();
                Console.Write("ID : "); int ID = int.Parse(Console.ReadLine());

                if (Methods.IsvalidName_ID(name, ID))
				{
					
					Console.WriteLine(" Choose the update option you want to do :\n1.Update name.\n2.Update ID" +
						"\n3. Press any key to Exit");
					int choice = int.Parse(Console.ReadLine());
					switch (choice)
					{
						case 1:
							{
								Console.Write("New name : "); string newName = Console.ReadLine(); break;
								
							}
						case 2:
							{
								Console.Write("New ID : "); int newID = int.Parse(Console.ReadLine()); break;
							}
						default: Console.WriteLine(" Thanks for using ! "); break;
					}

					Console.WriteLine(" Your profile data has been changed successfully !");

				}
				else
				{
					Console.WriteLine("No user found with this Name and ID !!!");
				}
				


			}
			else
			{
				Console.WriteLine(" No user found with this Phone number !!!");
			}
		}
		

	}
}

