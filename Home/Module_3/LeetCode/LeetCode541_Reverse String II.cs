using System;
namespace Home.Module_3.LeetCode
{
	public class LeetCode541_Reverse_String_II
	{
        public static string ReverseStr(string s, int k)
        {
            Console.Write("s ="); s = Console.ReadLine();
            Console.Write("k ="); k = int.Parse(Console.ReadLine());
            string res;
            char[] chars;
            int i = 0;
            int elementLeft = s.Length - i;
            while (elementLeft >= 2 * k)
            {
                chars = (s.Substring(i, k)).ToCharArray();
                Array.Reverse(chars);
                res = String.Concat(chars);
                //string.Join("", chars);
                s = s.Remove(i, k);
                s = s.Insert(i, res);

                i += 2 * k;
                elementLeft -= 2 * k;
            }
            if (elementLeft > 0 & elementLeft < k)
            {
                chars = (s.Substring(i)).ToCharArray();
                Array.Reverse(chars);
                res = string.Join("", chars);
                s = s.Remove(i);
                s = s.Insert(i, res);
            }
            if (elementLeft >= k & elementLeft < 2 * k)
            {
                chars = (s.Substring(i, k)).ToCharArray();
                Array.Reverse(chars);
                res = String.Concat(chars);
                s = s.Remove(i, k);
                s = s.Insert(i, res);
            }



            return s;
        }

            public LeetCode541_Reverse_String_II()
		{
		}
	}
}

