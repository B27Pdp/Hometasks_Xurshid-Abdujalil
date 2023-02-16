// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace L9_Iterator;
internal class Program
{
    private static void Main_L9(string[] args)
    {
        //L9_Iterator.MyClass.STR();
        //MyClass.First();
        //MyClass.Second();
        MyClass1.Third();
    }
}




#region 1
class MyClass1
{


    public static void First()
    {
        List<string> names = new() { "Salima", "Nozima", "Muslima", "Madina", "Sitora" };
        names.Add("Anvar");
        names.Add("Sanjar");
        names.Add("Sarvar");
        names.Add("Bobur");
        names.Add("Salim");

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\v");

        names.Add("Xurshid");
        names[9] = "Abdujalilov";
        names[8] = "Abdujalilov";

        string[] names1 = names.ToArray();

        foreach (var item in names1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\v");


        //IEnumerable<string> result=names1.ToList().SkipWhile(x => x == "Xurshid" & x == "Abdujalilov");
        //IEnumerable<string> result = names1.TakeWhile(x => x == "Xurshid" & x == "Abdujalilov");
        names = names1.ToList();
        if (names.Contains("Xurshid")) names.Remove("Xurshid");

        foreach (var item in names)
        { Console.WriteLine(item); }
        Console.WriteLine("\v");

        while (names.Contains("Abdujalilov")) names.Remove("Abdujalilov");

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
        #endregion
    }

    #region 2
    public static void Second()
    {
        List<int> numbers = new(50);
        Random random = new Random();

        for (int i = 0; i < 50; i++)
        { numbers[i] = random.Next(1, 100); }
        #endregion
    }


    #region 3
    public static void Third()
    {
        //Console.WriteLine(" Enter necessary string with $keywords$ ");
        //string str = Console.ReadLine();
        //Dictionary<string, string> dict = new Dictionary<string, string>();
        //dict.Add("keyword", "mykey");
        //dict.Add("myword", "mykey");
        //while (str.IndexOf("$")!=-1&& str.IndexOf("$", str.IndexOf("$") + 1)!=-1)
        //{
        //    int index1 = str.IndexOf("$");
        //    int index2 = str.IndexOf("$", index1 + 1);
        //    string sub = str.Substring(index1, index2 - index1 + 1);
        //   string sub2=sub.Trim('$');
        //    Console.WriteLine($"sub is {sub}");
           
        //    str = str.Replace(sub, dict[sub2]);
        //    Console.WriteLine($" Replaced  {sub} to {dict[sub2]}");
        //}
        //Console.WriteLine("The final result : \n {0}",str);

                    ////////
        //List<int> l = new() { 1,3,4,1,5,0,9,2,3};

        //ArrayList l1 = new(12);
        
        //l1.Add(1122);
        //l1.Add("Asd");
        //foreach (var item in l1)
        //{
        //    Console.WriteLine(item);
        //}
        //Hashtable hashtable = new();
        //hashtable.Add("Aas", 22);
        //hashtable.Add(2, "uhavd");
        //hashtable.Add(3, "uhavd");

        //foreach (var item in hashtable)
        //{
        //    Console.WriteLine(item);
        //}

        //LinkedList<string> LinkedList = new();
        //LinkedListNode<string> listNode = new("Him");
        //LinkedList.AddFirst(listNode);
        //foreach (var item in LinkedList)
        //{
        //    Console.WriteLine(item);
        //}
        SortedList j=new();
        SortedList<string,int> asd = new();
        j.Add(1, 78); j[-11] = 009;
        Console.WriteLine(j[0]);
        j.GetByIndex(-11);

        
        #endregion
    }

}