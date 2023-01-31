namespace Homework_OOP_L1
{  
    public class Program
    {
         static void Main(string[] args)
        {
           Point();
            //Triangle() ;
            //MyClass() ;
            //MyDate() ;
            //Student() ;

        }
        static void Point()
        {
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);
            Point point = new(x, y);
            point.PrintXY();
        }

        static void Triangle()
        {
            double a = double.Parse(Console.ReadLine()!);
            double b = double.Parse(Console.ReadLine()!);
            Triangel triangel = new(a, b);
            triangel.Perimetr();
            triangel.Yuza();
        }

        static void MyClass()
        {
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            MyClass myClass = new(a, b);
            myClass.AboutFields();
            int sum = myClass.SumOfFields();
            Console.WriteLine(sum);
            int max = myClass.MaxField();
            Console.WriteLine(max);

        }

        static void MyDate()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            MyDate myDate = new(year, month, day);
            myDate.PrintDate();
        }

        static void Student()
        {
            string surname = Console.ReadLine()!;
            string name = Console.ReadLine()!;
            int group_ID = int.Parse(Console.ReadLine()!);
            string[] subjects = new string[5];
            for (int i = 0; i < 5; i++)
            {
                subjects[i] = Console.ReadLine()!;
            }
            Student student = new Student(surname, name, group_ID, subjects);
            student.PrintSubject();

        }
    }
}