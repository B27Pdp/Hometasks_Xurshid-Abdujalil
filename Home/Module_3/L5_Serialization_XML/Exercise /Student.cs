using System;
namespace Home.Module_3.L5_Serialization_XML.Exercise
{
	public class Student
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Phone { get; set; }
		public Student()
		{
		}
        public override string ToString()
        {
            return $"ID:{ID},Name:{Name},Surname:{Surname},Phone:{Phone}";
        }
    }
}

