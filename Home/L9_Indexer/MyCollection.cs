using System;
namespace Home.L9_Indexer
{
	public class MyCollection<T>
	{
        
        private List<T> IndexList;
        public T this[int i]
        {
            get
            {
                return IndexList[i];
            }
            set
            {
                byte inputCounter = 0;
                while (true)
                {
                    if (IndexList[i] != null)
                    {
                        Console.WriteLine("This index[{0}] already has its value \nDo you want to override ? " +
                        "\n type 'y' for yes ,'n' for no", i);
                        string? str = Console.ReadLine();
                        if (str == "y")
                        { IndexList[i] = value; Console.WriteLine(" Value changed !!!"); break; }
                        else if (str == "n") { Console.WriteLine("Thanks"); break; }
                        else
                        {
                            Console.WriteLine(" Incorrect input");
                            inputCounter++;
                            if (inputCounter == 3)
                            {
                                Console.WriteLine(" You tried max times (max incorrect entries = 3)"); break;
                            }
                        }
                    }
                    if (IndexList.Contains(value)) Console.WriteLine(" Collection already contains this value at this index");
                    else IndexList[i] = value; continue;

                }
            }
            
        }
        public void Add( T item) { IndexList.Add(item); }
        public  void PrintOne(int index)
        { Console.WriteLine(this[index]); }
         

        public MyCollection(T index, string name)
		{
            IndexList.Add(index);

        }
	}
}

