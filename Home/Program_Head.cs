using Home.L10_Delegates.ClassWork;
using Home.L10_Delegates;
using Home.Module_3.L1_Regex;
using Home.Module_3.LeetCode;
using Home.Module_3.L5_Serialization_XML;
using Home.Module_3.L5_Serialization_XML.Exercise;
using Home.Module_3.L4_Files_Directory;
using Home.Module_3.L6_Serialization_JSON;
using Home.Module_3.L6_Serialization_JSON.CRUD_JSON;
using Newtonsoft.Json;

internal class Program_Head
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World! It is Main_Head");
        //List<int> va = new();

        //Program_L10.Main_L10();
        //Regex1.RegexDo();
        //LeetcCode389_Find_the_Difference.DoLeetCode389();

        //Files_Do.Do();
        //Xml1.DoXml1();
        //Exercise.DoExercise();
        //Read.Reader();
        //CRUD_JSON.CRUD_JSONRunner();

        // Convert a JSON string to a strongly-typed object

//        string json = @"{
//    'name': 'Charlie',
//    'age': 20,
//    'isStudent': true
//}";
//        dynamic data = JsonConvert.DeserializeObject(json);
//        Console.WriteLine(data.name);
//        var Myvar = "Hello";
        
//        object myObj = "HI"+123;
//        myObj = 1;
//        decimal s = 1234;
//        int x = 42;

        // This will generate a compile-time error
        //decimal result = s + x;
        var x1 = 42;
        var y = "hello";

        // This will generate a compile-time error
        var result1 = x1 + y; Console.WriteLine(result1.GetType() +"  result's type :");

    }
}