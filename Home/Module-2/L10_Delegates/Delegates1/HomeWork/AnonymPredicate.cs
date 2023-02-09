using System;
namespace Home.L10_Delegates.HomeWork
{
    public partial class Anonyms
    {
        public static void AnonymPredicate()
        {
            Predicate<string> predicate1 = (str) => str.Contains('@');
            Predicate<int> predicate2 = (number) => number.ToString().StartsWith("+998");
            Predicate<List<string>> predicate3 = (list) => list.Exists(x => x == "Jason");

            predicate1.Invoke("harrypotter@gmail.uz");
            predicate2.Invoke(+99899);
            predicate3.Invoke(  new List<string>{ "Name1", "Name2", "Name3", "Name4","Jason" } );
        }
        
	}
}

