using System;
namespace Home.L10_Delegates.HomeWork
{
    public partial class Anonyms
    {
        public Func<string> func1 = () => "Hi ,string returned !";
        Func<(string, string)> func2 = () => ("Hi , this is tuple,item1", "And this is item2");
        Func<string, string, (string, string)> func3 = (str1, str2) =>
        (str1 += (str2 + "Item1"), str2 += (str1 + "Item2") + "This is Tuple");



        public static void AnonymFunc()
        {
            Anonyms anonyms = new();
            anonyms.func1();
            anonyms.func2();
            anonyms.func3("I wrote one text here", "Wrote another there");

            anonyms.func1 += anonyms.Func1;
            anonyms.func1();


        }

        public string Func1()
        {
            return "This is method1";
        }
    }

}

