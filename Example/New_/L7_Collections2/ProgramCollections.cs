using System;
using System.Collections.Generic;
namespace L7_Collections2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //MyGeneric_Collection<uint, Group, StudentDetails> Person1 = new()
            //{ 2; new Group(123); new StudentDetails("Tom", 20)};
            //Leetcode_Design_Hashset_705 leetcode_ = new();


            #region Classwork
            ////LinkedListNode<int> node1 = new(1);
            ////    var t = (1, 2, 3, 4, 5, 6);
            ////    Console.WriteLine(t.ToString);
            ////Tuple<int, int, int, int> tuple;

            //int? a = 10;
            //int? b = null;
            //int? c = 10;

            ////a++; Console.WriteLine(a);       // a is 11
            ////a = a * c; Console.WriteLine(a);  // a is 110
            ////a = a%b; Console.WriteLine(a);  // a is null

            //object[] eea =  {2,3,5,"Asdf","asd" };
            ////Console.WriteLine( eea.GetType());
            ////Console.WriteLine(eea[0].GetType());

            ////HashSet<int> values =new(  ){ 1,2,3,3,4,};
            ////values.Contains(3);
            ////foreach (var item in values)
            ////{
            ////    Console.WriteLine(item);

            #endregion
        }


    }

    class MyClass<T>
    {
        public int A()
        { Console.WriteLine(); return 0; }

        public T MyGetter(T a)
        {
            return a;
        }

    }

     class VendingMachine
     {
            private Dictionary<string, double> beverages = new Dictionary<string, double>();
            private Dictionary<int, double> cards = new Dictionary<int, double>();
            private Dictionary<int, Tuple<string, int>> columns = new Dictionary<int, Tuple<string, int>>();

            public void AddBeverage(string name, double price)
            {
                beverages.Add(name, price);
            }

            public double GetPrice(string name)
            {
                if (beverages.ContainsKey(name))
                    return beverages[name];
                else
                    return -1.0;
            }

            public void RechargeCard(int id, double credit)
            {
                if (cards.ContainsKey(id))
                    cards[id] += credit;
                else
                    cards.Add(id, credit);
            }

            public double GetCredit(int id)
            {
                if (cards.ContainsKey(id))
                    return cards[id];
                else
                    return -1.0;
            }

            public void RefillColumn(int column, string name, int cans)
            {
                columns[column] = Tuple.Create(name, cans);
            }

            public int AvailableCans(string name)
            {
                int count = 0;
                foreach (var column in columns.Values)
                {
                    if (column.Item1 == name)
                        count += column.Item2;
                }
                return count;
            }

            public int Sell(string name, int id)
            {
                if (!beverages.ContainsKey(name) || !cards.ContainsKey(id))
                    return -1;

                double price = beverages[name];
                if (cards[id] < price)
                    return -1;

                int column = -1;
                foreach (var col in columns)
                {
                    if (col.Value.Item1 == name && col.Value.Item2 > 0)
                    {
                        column = col.Key;
                        break;
                    }
                }
                if (column == -1)
                    return -1;

                columns[column] = Tuple.Create(name, columns[column].Item2 - 1);
                cards[id] -= price;
                return column;
            }
     }
  
}