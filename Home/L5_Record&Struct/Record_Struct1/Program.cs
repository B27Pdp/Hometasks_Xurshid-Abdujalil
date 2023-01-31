using Record_Struct1;
namespace Record_Struct1
{
    internal partial class Program
    {
        private static void Main_L5_RecStruct(string[] args)
        {
            Class1Triangle triangle1 = new Class1Triangle();
            triangle1.SMS_Status = EnumSMS_Status.Delivered;
            triangle1.A = 4;
            triangle1.B = 5;
            triangle1.GetPerimetr();
        }
    }
}