using System;
using Home.L10_Delegates.ClassWork;
using Home.L10_Delegates.HomeWork;
namespace Home.L10_Delegates;

public class Program_L10
{
    public delegate void NumericOperation(int a, int b);
    public delegate void NumericAll();
    public string message = " Hi this is a test message from this class";

    public static void Main_L10()
    {
        #region Ex

        //Program_L10 classObject = new();
        //Console.WriteLine("Hello Delegates !!!\n");
        //DelegateMethod(classObject.message, delegate1, delegate2, delegate4);
        //Console.WriteLine(" It is another Delegate namely ,myDelegate1 !");
        //MyDelegate1 myDelegate1 = new(Start1);
        //myDelegate1();

        #endregion

        #region Exercise
        //delegate1.Invoke();
        //delegate1 += Start2;
        //Console.WriteLine("Start2() was added to delegate1 ");
        //Console.WriteLine(" Invoking delegate1 again !\v ");
        //delegate1();
        //delegate2(12);
        #endregion

        //NumericOperation operationSum = new(Mathematics<int>.Sum);
        //NumericOperation operationSubstract = new(Mathematics<int>.Substract);
        //NumericOperation operationMultiply = new(Mathematics<int>.Multiply);
        //NumericOperation operationDevide = new(Mathematics<int>.Devide);
        
        //operationDevide(12, 2);
        //operationMultiply(12, 2);
        //operationSubstract(12, 2);
        //operationSum(12, 2);
        TupleMaxMin tupleMaxMin = new();
        TupleMaxMin.MyTuple myTuple = TupleMaxMin.GetMaxMin;
        Console.WriteLine(myTuple(tupleMaxMin.List));
        
        
    }
  




    public delegate void MyDelegate1();
    public delegate int Mydelegate2(int s);
    public delegate void Mydelegate3();

    public static MyDelegate1 delegate1 = Start1;
    public static Mydelegate2 delegate2 = Start3;
    public static Mydelegate2 delegate4 = Start4;

    public static void Start1()
    { Console.WriteLine("		Start1 worked !"); }
    #region Start2-4
    public static void Start2()
    {
        Console.WriteLine(" Start2 Worked! ");
    }

    public static int Start3(int a)
    {
        Console.WriteLine("this is Start3");
        return a;
    }

    public static int Start4(int b)
    {
        Console.WriteLine("this is Start3");
        return b;
    }
    #endregion

    public static void DelegateMethod(string sms, MyDelegate1 del11, Mydelegate2 del21, Mydelegate2 del22)
    {
        Console.WriteLine(sms);
        del11();
        del21(1122);
        del22(123);


    }





}	
	
