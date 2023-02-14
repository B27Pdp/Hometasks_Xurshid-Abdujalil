using System;
using System.Xml.Serialization;

namespace Home.Module_3.L5_Serialization_XML.Exercise
{
	public class Create
	{
		public static void CreatorXML()
        {
            string XMLpath = "../../../Module_3/L5_Serialization_XML/GroupInfo.xml";
            XmlSerializer serializer = new(typeof(List<Student>));
            List<Student> Group = new();
            Group.Add(new Student
            {
                ID = 1111,
                Name = "Abdulatif",
                Surname = "Mirzayev",
                Phone = "+998901402020"
            });
            Group.Add(new Student
            {
                ID = 2222,
                Name = "Ulug'bek",
                Surname = "Toshtemirov",
                Phone = "+998990564969"
            });
            Group.Add(new Student
            {
                ID = 3333,
                Name = "Xurshid",
                Surname = "Abdujalilov",
                Phone = "+998905046484"
            });
            Console.WriteLine(" To sign up as a new user enter your info :");
            Console.Write("Phone :");string phone = Console.ReadLine();
            Console.Write("Surname :");string surname = Console.ReadLine();
            Console.Write("Name :"); string name = Console.ReadLine();
            

    
            using (StreamWriter stream = new StreamWriter(XMLpath))
            {
                serializer.Serialize(stream, Group);
            }

        }
    }
}

