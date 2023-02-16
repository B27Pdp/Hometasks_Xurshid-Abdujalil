using System;
using System.Linq;

namespace L7_Collections2
{
	public class Leetcode_Design_Hashset_705
	{
		public Leetcode_Design_Hashset_705()
		{
		}
        List<int> list = new();
            public void Add(int key)
            {
               if(!list.Contains(key))
                list.Add(key);
            }

            public void Remove(int key)
            {
               if (list.Contains(key))
                list.Remove(key);
            }

            public bool Contains(int key)
            {
            return list.Contains(key);
            }
        

    }
}

