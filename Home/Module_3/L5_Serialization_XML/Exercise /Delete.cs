using System;
namespace Home.Module_3.L5_Serialization_XML.Exercise
{
    public class Delete
    {
        public static void Deletor()
        {

            Func<List<Student>> GetList;

            List<Student> Group = new();
            GetList = Read.Reader;
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

                    Console.WriteLine("Do you want to delete your account?\n1.Yes to confirm.\n2.No to decline!");

                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Group.Any(User =>
                                {
                                    if (User.Phone == number & User.Name == name & User.ID == ID)
                                        Group.Remove(User);
                                    return true;
                                    
                                }
                                );
                                Console.WriteLine(" Your profile  has been deleted successfully !");
                                break;
                            }
                        case 2:
                            {
                                break;
                            }
                        default: Console.WriteLine(" Thanks for using ! "); break;
                    }
                }

                else {Console.WriteLine("No user found with this Name and ID !!!"); }
            }

            else {Console.WriteLine(" No user found with this Phone number !!!");}
        }
    }
}


