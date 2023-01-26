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



    public class MyStack
    {
        public MyStack()
        {

        }
        private Queue queue2 = new();
        private Queue queue1 = new();
        bool q1Enabled = true;
        public void Push(int x)
        {
            if (q1Enabled)
            {
                queue1.Enqueue(x);
                if (queue1.Count > 1) queue2.Enqueue(queue1.Dequeue());
            }
            else
            {
                queue2.Enqueue(x);
                if (queue2.Count > 1) queue1.Enqueue(queue1.Dequeue());
            }


        }

        public int Pop()
        {
            if (q1Enabled)
            {
                for (int i = 1; i < queue2.Count; i++)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }
                q1Enabled = false;
                return ((int)queue1.Dequeue());
            }
            else
            {
                for (int i = 1; i < queue1.Count; i++)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }q1Enabled = true;
                return ((int)queue2.Dequeue());
            }
        }

        public int Top()
        {
            return q1Enabled?  (int)queue1.Peek(): (int)queue2.Peek();

        }

        public bool Empty()
        {
            return queue1.Count == 0 & queue2.Count == 0 ? true : false;
        }
    }
}