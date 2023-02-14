using System;
using System.Xml;
using System.Xml.Serialization;

namespace Home.Module_3.L5_Serialization_XML
{
	public class Xml1
	{

		public static void DoXml1()
		{
			XmlDocument? xDoc = new XmlDocument();

			DirectoryInfo curentdir = new("../../../Module_3/L5_Serialization_XML");
			//string XMLFile1 = curentdir.FullName + "/XMLFile1.xml";
			string XMLFile1 = "../../../Module_3/L5_Serialization_XML/XMLFile1.xml";


            

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
			List<Person> people = new();

			using (FileStream fs = new(XMLFile1, FileMode.Open))
			{
				for (int i = 0; i < 3; i++)
				{ 
					people.Add(new Person { Name = "Eldor" + i + 1, Age = (byte)(i + 5) });
				}
				
				people.ForEach(person=>xmlSerializer.Serialize(fs,person));
				Person person1=xmlSerializer.Deserialize(fs) as Person;
				Console.WriteLine(person1);
			}

			using (FileStream fs = new(XMLFile1, FileMode.OpenOrCreate))
			{

				people.Add(xmlSerializer.Deserialize(fs) as Person ?? new("Undefined", 0));
				//XmlNodeList nodeList = xDoc.ChildNodes;
				people.ForEach(x => Console.WriteLine(x));
			}


			//XmlElement xRoot = new XmlElement();
		}
	}
}

