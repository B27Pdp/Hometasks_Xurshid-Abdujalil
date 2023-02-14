using System;
namespace Home.Module_3.L5_Serialization_XML
{
	public class Person
	{
		 public string Name { get; set; }
		 public byte Age { get; set; }
		public Person()
		{	}
		public Person(string name,byte age)
		{
			Name = name;
			Age = age;
		}
		public override string ToString()
		{ return $"Name :{Name},Age :{Age}"; }
    }
}

