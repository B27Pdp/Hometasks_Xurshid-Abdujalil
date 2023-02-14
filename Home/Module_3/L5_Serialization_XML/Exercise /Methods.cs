using System;
namespace Home.Module_3.L5_Serialization_XML.Exercise
{
	public static class Methods
	{

        public static bool IsvalidNumber(string number)
        {
            List<Student> Group = Update.GetList.Invoke();
            return Group.Any(x => x.Phone == number);
        }
        public static bool IsvalidName_ID(string name, int ID)
        {
            List<Student> Group = Update.GetList.Invoke();
            Student student = new();
            //Group.Take(x => studnex.Name == name & x.ID == ID? student=x:)  ;
            return Group.Any(x => x.Name == name & x.ID == ID);
        }
        public static void SwitcheCase()
        {

        }
    }
}

