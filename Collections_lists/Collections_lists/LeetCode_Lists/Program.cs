using System.Collections;
using System.Diagnostics.Metrics;

namespace Program
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Queue values1 = new();
            Queue values2 = new();

            Stack stack = new Stack();
            values1.Enqueue(2);
            values2.Enqueue(values1.Dequeue());
        }
    }

    public class MyQueue
    {

        public MyQueue()
        {

        }
        Stack stack1 = new();
        Stack stack2 = new();
        bool s1Enabled = true;
        public void Push(int x)
        {

            for (int i = 0; i < stack2.Count; i++)
            {
               stack1.Push(stack2.Pop());
            }
            stack1.Push(x);
           

        }

        public int Pop()
        {
            
            for (int i = 0; i < stack1.Count; i++)
            {
                 stack2.Push(stack1.Pop());
            }
            return (int)stack2.Pop() ;
           
        }

        public int Peek()
        {
            for (int i = 0; i < stack1.Count; i++)
            {
                stack2.Push(stack1.Pop());
            }
            return (int)stack2.Peek();
        }

        public bool Empty()
        {
            return stack1.Count == 0 & stack2.Count == 0 ? true : false;
        }
    }

    
}