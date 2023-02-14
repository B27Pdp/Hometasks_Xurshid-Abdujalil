using System;
using System.Xml.Serialization;

namespace Home.Module_3.L5_Serialization_XML.Exercise
{
	public class Read
	{
		public static List<Student> Reader()
		{ 
            string XMLpath = "../../../Module_3/L5_Serialization_XML/GroupInfo.xml";
            
                XmlSerializer serializer = new(typeof(List<Student>));
            List<Student> Group = new();
			using (FileStream stream = new(XMLpath, FileMode.Open))
			{
				//Console.WriteLine(serializer.Deserialize(stream).ToString());
				Group = (List<Student>)serializer.Deserialize(stream);

			}
			Console.WriteLine(" List of members in the group :\v");
			foreach (var item in Group)
			{
				Console.WriteLine(item);
			}
			return Group;
                

        }
	}
}

