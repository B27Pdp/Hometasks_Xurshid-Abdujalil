using System;
namespace Home.L10_Delegates.HomeWork
{
    public partial class Anonyms
    {
        public delegate string Mydel2(string a);
        public static void AnonymLambda()
        {
            Mydel2 mydel2 = (str) =>
            { Console.WriteLine(" this is the text {0}", str); return str; };
            Mydel2 mydel21 = (str) => { _ = str.Length; return "the length is {0}" + str.Length; };

            mydel2.Invoke("this is mytext1 model2");  // <=> mydel2("this is mytext1 model2");
            mydel21.Invoke("This is mytext2"); // <=> // <=> mydel2("this is mytext1 model2");

        }
        public static string PrintString(string a)
        {
            return "Asd";
        }

    }
  

    public partial class Anonyms
    {
        
    }
}