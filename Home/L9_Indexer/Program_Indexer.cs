using System;
using System.Collections;
using System.Collections.Generic;

namespace Home.L9_Indexer
{

    public class MyClass<T>:IEnumerable<T>
    {
         List<T> list = new();
        public void Add(T item)
        {
            list.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }



    }


    public class Program_Indexer
    {
        public Program_Indexer()
        { }

        public static void Main(string[] args)
        {
            MyClass<int> collection = new MyClass<int>();
            collection.Add(11);
            collection.Add(12);
            collection.Add(13);
            collection.Add(14);
            collection.Add(15);

            foreach (var item in collection)
            {
                Console.WriteLine(item);

            }


        }
    }
}


