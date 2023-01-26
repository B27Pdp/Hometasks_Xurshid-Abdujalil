using System.Collections;
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
            if (s1Enabled) stack1.Push(x);
           else stack2.Push(x);

        }

        public int Pop()
        {
            int counter = s1Enabled ? stack1.Count : stack2.Count;
            for (int i = 0; i < counter; i++)
            {
                if (s1Enabled) stack2.Push(stack2.Pop());
                else stack1.Push(stack2.Pop());
            } s1Enabled = false;
            return s1Enabled? (int)stack1.Pop() : (int)stack2.Pop();
           
        }

        public int Peek()
        {
            return s1Enabled ? (int)stack1.Peek() : (int)stack2.Peek();
        }

        public bool Empty()
        {
            return stack1.Count == 0 & stack2.Count == 0 ? true : false;
        }
    }

    
}