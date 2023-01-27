internal class Program
{
    private static void Main(string[] args)
    {
        //LinkedListNode<int> node1 = new(1);
        //    var t = (1, 2, 3, 4, 5, 6);
        //    Console.WriteLine(t.ToString);
        //Tuple<int, int, int, int> tuple;

        int? a = 10;
        int? b = null;
        int? c = 10;

        //a++; Console.WriteLine(a);       // a is 11
        //a = a * c; Console.WriteLine(a);  // a is 110
        //a = a%b; Console.WriteLine(a);  // a is null
      
        object[] eea =  {2,3,5,"Asdf","asd" };
        Console.WriteLine( eea.GetType());
        Console.WriteLine(eea[0].GetType());


        //HashSet<int> values =new(  ){ 1,2,3,3,4,};
        //values.Contains(3);
        //foreach (var item in values)
        //{
        //    Console.WriteLine(item);
    }

}
